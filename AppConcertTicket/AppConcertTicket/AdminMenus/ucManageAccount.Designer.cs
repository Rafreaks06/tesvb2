namespace AppConcertTicket.AdminMenus
{
    partial class ucManageAccount
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
            label1 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            dgvCustomers = new DataGridView();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 85);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 147);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(194, 215);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 215);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(340, 75);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(298, 317);
            dgvCustomers.TabIndex = 6;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            //dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(29, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(127, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(224, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(29, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(287, 36);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Coral;
            lblStatus.Location = new Point(82, 267);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 16);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "...";
            // 
            // ucManageAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgvCustomers);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "ucManageAccount";
            Size = new Size(660, 462);
            Load += ucManageAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label3;
        private DataGridView dgvCustomers;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblStatus;
    }
}
