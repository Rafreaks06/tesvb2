using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConcertTicket.Data;
using Microsoft.EntityFrameworkCore;
using AppConcertTicket.Models;
using ConcertTicketAdmin.Helpers;
using System.Diagnostics;
using QuestPDF.Fluent;

namespace AppConcertTicket.AdminMenus
{
    public partial class ucManageTicket : UserControl
    {
        private readonly AppDbContext _context;
        private int? _selectedTicketId = null;

        public ucManageTicket()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void ucManageTicket_Load(object sender, EventArgs e)
        {
            LoadTicketData();
            LoadComboBoxes();
            ClearForm();
        }

        private void ShowSuccess(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Visible = true;
        }

        private void ShowError(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Visible = true;
        }

        //private void HideStatus()
        //{
        //    lblStatus.Visible = false;
        //}

        private void LoadComboBoxes()
        {
            cmbCustomer.DataSource = _context.Accounts.ToList();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
            cmbCustomer.SelectedIndex = -1;

            cmbConcert.DataSource = _context.Concerts.ToList();
            cmbConcert.DisplayMember = "ConcertName";
            cmbConcert.ValueMember = "Id";
            cmbConcert.SelectedIndex = -1;
        }

        private void LoadTicketData()
        {
            var tickets = _context.Tickets
                .Include(t => t.Cust)
                .Include(t => t.Concert)
                .Select(t => new
                {
                    t.Id,
                    t.BookingCode,
                    Customer = t.Cust.Name,
                    Concert = t.Concert.ConcertName,
                    t.Quantity,
                    t.TotalPrice,
                    t.BookingDate
                })
                .ToList();

            dgvTickets.DataSource = tickets;

            if (dgvTickets.Columns["Id"] != null)
            {
                dgvTickets.Columns["Id"].Visible = false;
            }
        }

        private void ClearForm()
        {
            txtBookingCode.Text = GenerateBookingCode();
            cmbCustomer.SelectedIndex = -1;
            cmbConcert.SelectedIndex = -1;
            numQuantity.Value = 1;
            txtTotalPrice.Clear();
            dtpBookingDate.Value = DateTime.Now;
            //HideStatus();
            _selectedTicketId = null;
        }

        private string GenerateBookingCode()
        {
            return $"BOOK-{DateTime.Now:yyyyMMddHHmmss}-{new Random().Next(100, 999)}";
        }

        private bool IsValid()
        {
            if (cmbCustomer.SelectedValue == null || cmbConcert.SelectedValue == null)
            {
                ShowError("Error: Customer and Concert must be selected.");
                return false;
            }

            if (numQuantity.Value <= 0)
            {
                ShowError("Error: Quantity must be at least 1.");
                return false;
            }

            return true;
        }

        private void CalculateTotalPrice()
        {
            if (cmbConcert.SelectedItem is Concert selectedConcert)
            {
                decimal unitPrice = selectedConcert.TicketPrice;
                int quantity = (int)numQuantity.Value;
                txtTotalPrice.Text = (unitPrice * quantity).ToString("C");
            }
            else
            {
                txtTotalPrice.Text = (0).ToString("C");
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void cmbConcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //HideStatus();
            if (!IsValid()) return;

            try
            {
                int concertId = (int)cmbConcert.SelectedValue;
                int quantityToBuy = (int)numQuantity.Value;

                var concert = _context.Concerts.Find(concertId);
                if (concert.TicketStock < quantityToBuy)
                {
                    ShowError($"Stock is insufficient. Only {concert.TicketStock} tickets left.");
                    return;
                }

                concert.TicketStock -= quantityToBuy;

                var newTicket = new Ticket
                {
                    BookingCode = txtBookingCode.Text,
                    BookingDate = dtpBookingDate.Value.ToUniversalTime(),
                    CustId = (int)cmbCustomer.SelectedValue,
                    ConcertId = concertId,
                    Quantity = quantityToBuy,
                    TotalPrice = concert.TicketPrice * quantityToBuy
                };

                _context.Tickets.Add(newTicket);
                await _context.SaveChangesAsync();

                ShowSuccess("Success: Ticket saved. Stock has been updated.");
                LoadTicketData();
                LoadComboBoxes();
                ClearForm();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nDETAIL ERROR:\n" + ex.InnerException.Message;
                }
                ShowError($"Error: {errorMessage}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ucManageTicket_Enter(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (_selectedTicketId == null)
            {
                ShowError("Error: Please select a ticket from the table first.");
                return;
            }

            try
            {
                var ticketToPrint = await _context.Tickets
                    .Include(t => t.Cust)
                    .Include(t => t.Concert)
                    .FirstOrDefaultAsync(t => t.Id == _selectedTicketId.Value);

                if (ticketToPrint == null)
                {
                    ShowError("Error: Ticket not found.");
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF File|*.pdf",
                    FileName = $"Ticket_{ticketToPrint.BookingCode}_{ticketToPrint.Cust.Name}.pdf",
                    Title = "Save Ticket PDF"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var document = new TicketDocument(ticketToPrint);
                    document.GeneratePdf(saveDialog.FileName);

                    if (MessageBox.Show($"PDF saved successfully at:\n{saveDialog.FileName}\n\nWould you like to open it now?",
                        "Print Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nDETAIL ERROR:\n" + ex.InnerException.Message;
                }
                ShowError($"Error: Failed to create PDF. {errorMessage}");
            }
        }

        private async void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var idValue = dgvTickets.Rows[e.RowIndex].Cells["Id"].Value;
                if (idValue == null) return;

                int clickedTicketId = (int)idValue;
                _selectedTicketId = clickedTicketId;

                var bookingCodeValue = dgvTickets.Rows[e.RowIndex].Cells["BookingCode"].Value;
                string bookingCode = (bookingCodeValue != null) ? bookingCodeValue.ToString() : "N/A";

                if (MessageBox.Show($"You selected ticket: {bookingCode}\n\nDo you want to print it now?",
                                   "Confirm Print",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                var ticketToPrint = await _context.Tickets
                    .Include(t => t.Cust)
                    .Include(t => t.Concert)
                    .FirstOrDefaultAsync(t => t.Id == clickedTicketId);

                if (ticketToPrint == null)
                {
                    ShowError("Error: Ticket not found in database.");
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF File|*.pdf",
                    FileName = $"Ticket_{ticketToPrint.BookingCode}_{ticketToPrint.Cust.Name}.pdf",
                    Title = "Save Ticket PDF"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var document = new TicketDocument(ticketToPrint);
                    document.GeneratePdf(saveDialog.FileName);

                    if (MessageBox.Show($"PDF saved successfully at:\n{saveDialog.FileName}\n\nOpen file now?",
                        "Print Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nDETAIL ERROR:\n" + ex.InnerException.Message;
                }
                ShowError($"Error: {errorMessage}");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}