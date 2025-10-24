namespace AppConcertTicket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            masterDataToolStripMenuItem = new ToolStripMenuItem();
            customerAccountsToolStripMenuItem = new ToolStripMenuItem();
            concertsToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            ticketBookingsToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterDataToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(668, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterDataToolStripMenuItem
            // 
            masterDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerAccountsToolStripMenuItem, concertsToolStripMenuItem });
            masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            masterDataToolStripMenuItem.Size = new Size(82, 20);
            masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // customerAccountsToolStripMenuItem
            // 
            customerAccountsToolStripMenuItem.Name = "customerAccountsToolStripMenuItem";
            customerAccountsToolStripMenuItem.Size = new Size(180, 22);
            customerAccountsToolStripMenuItem.Text = "Customer Accounts";
            customerAccountsToolStripMenuItem.Click += customerAccountsToolStripMenuItem_Click;
            // 
            // concertsToolStripMenuItem
            // 
            concertsToolStripMenuItem.Name = "concertsToolStripMenuItem";
            concertsToolStripMenuItem.Size = new Size(180, 22);
            concertsToolStripMenuItem.Text = "Concerts";
            concertsToolStripMenuItem.Click += concertsToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ticketBookingsToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(85, 20);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // ticketBookingsToolStripMenuItem
            // 
            ticketBookingsToolStripMenuItem.Name = "ticketBookingsToolStripMenuItem";
            ticketBookingsToolStripMenuItem.Size = new Size(180, 22);
            ticketBookingsToolStripMenuItem.Text = "Ticket Bookings";
            ticketBookingsToolStripMenuItem.Click += ticketBookingsToolStripMenuItem_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 24);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(668, 470);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 494);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Admin Concert Ticket";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterDataToolStripMenuItem;
        private ToolStripMenuItem customerAccountsToolStripMenuItem;
        private ToolStripMenuItem concertsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem ticketBookingsToolStripMenuItem;
        private Panel panelContent;
    }
}
