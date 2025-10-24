using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppConcertTicket.Data;
using AppConcertTicket.Models;

namespace AppConcertTicket.AdminMenus
{
    public partial class ucManageConcert : UserControl
    {
        private readonly AppDbContext _context;
        private Concert _selectedConcert = null;

        public ucManageConcert()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void ucManageConcert_Load(object sender, EventArgs e)
        {
            LoadConcertData();
            //HideStatus();
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

        private void LoadConcertData()
        {
            var concerts = _context.Concerts.Select(c => new
            {
                c.Id,
                c.ConcertName,
                c.Artist,
                c.Date,
                c.Location,
                c.TicketPrice,
                c.TicketStock
            }).ToList();

            dgvConcerts.DataSource = concerts;
            dgvConcerts.Columns["Id"].Visible = false;
        }

        private void ClearForm()
        {
            _selectedConcert = null;
            txtConcertName.Clear();
            txtArtist.Clear();
            txtLocation.Clear();
            dtpDate.Value = DateTime.Now;
            numPrice.Value = 0;
            numStock.Value = 0;
            //HideStatus();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtConcertName.Text) || string.IsNullOrWhiteSpace(txtArtist.Text))
            {
                ShowError("Error: Concert Name and Artist cannot be empty.");
                return false;
            }

            if (numPrice.Value <= 0)
            {
                ShowError("Error: Ticket Price must be greater than 0.");
                return false;
            }

            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //HideStatus();
            if (!IsValid()) return;

            try
            {
                var newConcert = new Concert
                {
                    ConcertName = txtConcertName.Text,
                    Artist = txtArtist.Text,
                    Location = txtLocation.Text,
                    Date = dtpDate.Value.ToUniversalTime(),
                    TicketPrice = numPrice.Value,
                    TicketStock = (int)numStock.Value
                };

                _context.Concerts.Add(newConcert);
                await _context.SaveChangesAsync();

                ShowSuccess("Success: Concert data saved.");
                LoadConcertData();
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

        private void dgvConcerts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int concertId = (int)dgvConcerts.Rows[e.RowIndex].Cells["Id"].Value;
                _selectedConcert = _context.Concerts.Find(concertId);

                if (_selectedConcert != null)
                {
                    txtConcertName.Text = _selectedConcert.ConcertName;
                    txtArtist.Text = _selectedConcert.Artist;
                    txtLocation.Text = _selectedConcert.Location;
                    dtpDate.Value = _selectedConcert.Date.ToLocalTime();
                    numPrice.Value = _selectedConcert.TicketPrice;
                    numStock.Value = _selectedConcert.TicketStock;
                    //HideStatus();
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            //HideStatus();
            if (_selectedConcert == null)
            {
                ShowError("Error: Please select a concert to update.");
                return;
            }

            if (!IsValid()) return;

            try
            {
                _selectedConcert.ConcertName = txtConcertName.Text;
                _selectedConcert.Artist = txtArtist.Text;
                _selectedConcert.Location = txtLocation.Text;
                _selectedConcert.Date = dtpDate.Value.ToUniversalTime();
                _selectedConcert.TicketPrice = numPrice.Value;
                _selectedConcert.TicketStock = (int)numStock.Value;

                await _context.SaveChangesAsync();

                ShowSuccess("Success: Concert data updated.");
                LoadConcertData();
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //HideStatus();
            if (_selectedConcert == null)
            {
                ShowError("Error: Please select a concert to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _context.Concerts.Remove(_selectedConcert);
                    await _context.SaveChangesAsync();

                    ShowSuccess("Success: Concert data deleted.");
                    LoadConcertData();
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}