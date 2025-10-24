namespace AppConcertTicket.AdminMenus
{
    partial class ucManageTicket
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTickets = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCustomer = new ComboBox();
            cmbConcert = new ComboBox();
            numQuantity = new NumericUpDown();
            txtBookingCode = new TextBox();
            txtTotalPrice = new TextBox();
            dtpBookingDate = new DateTimePicker();
            lblStatus = new Label();
            btnClear = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(338, 73);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.Size = new Size(298, 317);
            dgvTickets.TabIndex = 19;
            dgvTickets.CellClick += dgvTickets_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 201);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 34;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 231);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 33;
            label5.Text = "Total Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 173);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 32;
            label4.Text = "Booking Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 31;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 112);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 30;
            label2.Text = "Concert";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 83);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 29;
            label1.Text = "Customer";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(194, 79);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(121, 23);
            cmbCustomer.TabIndex = 35;
            // 
            // cmbConcert
            // 
            cmbConcert.FormattingEnabled = true;
            cmbConcert.Location = new Point(193, 108);
            cmbConcert.Name = "cmbConcert";
            cmbConcert.Size = new Size(121, 23);
            cmbConcert.TabIndex = 36;
            cmbConcert.SelectedIndexChanged += cmbConcert_SelectedIndexChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(194, 137);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 37;
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // txtBookingCode
            // 
            txtBookingCode.Location = new Point(214, 169);
            txtBookingCode.Name = "txtBookingCode";
            txtBookingCode.Size = new Size(100, 23);
            txtBookingCode.TabIndex = 38;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(214, 231);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(100, 23);
            txtTotalPrice.TabIndex = 39;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Location = new Point(115, 202);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(200, 23);
            dtpBookingDate.TabIndex = 40;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Coral;
            lblStatus.Location = new Point(97, 288);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 16);
            lblStatus.TabIndex = 45;
            lblStatus.Text = "...";
            lblStatus.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(136, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(192, 38);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(25, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 38);
            btnSave.TabIndex = 41;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ucManageTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dtpBookingDate);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtBookingCode);
            Controls.Add(numQuantity);
            Controls.Add(cmbConcert);
            Controls.Add(cmbCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTickets);
            Name = "ucManageTicket";
            Size = new Size(660, 462);
            Load += ucManageTicket_Load;
            Enter += ucManageTicket_Enter;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTickets;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCustomer;
        private ComboBox cmbConcert;
        private NumericUpDown numQuantity;
        private TextBox txtBookingCode;
        private TextBox txtTotalPrice;
        private DateTimePicker dtpBookingDate;
        private Label lblStatus;
        private Button btnClear;
        private Button btnSave;
    }
}
