using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppConcertTicket.Data;
using AppConcertTicket.Models;

namespace AppConcertTicket.AdminMenus
{
    public partial class ucManageAccount : UserControl
    {
        private readonly AppDbContext _context;
        private Account _selectedAccount = null;

        public ucManageAccount()
        {
            InitializeComponent();
            _context = new AppDbContext();
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

        private void LoadCustomerData()
        {
            var customers = _context.Accounts.Select(c => new
            {
                c.Id,
                c.Name,
                c.Email,
                c.PhoneNumb
            }).ToList();

            dgvCustomers.DataSource = customers;
            dgvCustomers.Columns["Id"].Visible = false;
        }

        private void ClearForm()
        {
            _selectedAccount = null;
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowError("Error: Name and Email cannot be empty.");
                return false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                ShowError("Error: Email format is not valid.");
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            try
            {
                var newCustomer = new Account
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    PhoneNumb = txtPhoneNumber.Text
                };

                _context.Accounts.Add(newCustomer);
                await _context.SaveChangesAsync();

                ShowSuccess("Success: Customer data saved.");
                LoadCustomerData();
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null)
            {
                ShowError("Error: Please select a customer to update.");
                return;
            }

            if (!IsValid()) return;

            try
            {
                _selectedAccount.Name = txtName.Text;
                _selectedAccount.Email = txtEmail.Text;
                _selectedAccount.PhoneNumb = txtPhoneNumber.Text;

                await _context.SaveChangesAsync();

                ShowSuccess("Success: Customer data updated.");
                LoadCustomerData();
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

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = (int)dgvCustomers.Rows[e.RowIndex].Cells["Id"].Value;
                _selectedAccount = _context.Accounts.Find(customerId);

                if (_selectedAccount != null)
                {
                    txtName.Text = _selectedAccount.Name;
                    txtEmail.Text = _selectedAccount.Email;
                    txtPhoneNumber.Text = _selectedAccount.PhoneNumb;
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == null)
            {
                ShowError("Error: Please select a customer to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _context.Accounts.Remove(_selectedAccount);
                    await _context.SaveChangesAsync();

                    ShowSuccess("Success: Customer data deleted.");
                    LoadCustomerData();
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

        private void ucManageAccount_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
    }
}