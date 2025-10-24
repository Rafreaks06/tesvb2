using AppConcertTicket.AdminMenus;

namespace AppConcertTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(userControl);
        }

        private void customerAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucManageAccount());
        }

        private void concertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucManageConcert());
        }

        private void ticketBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucManageTicket());
        }
    }
}
