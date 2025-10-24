namespace AppConcertTicket.AdminMenus
{
    partial class ucManageConcert
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
            lblStatus = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dgvConcerts = new DataGridView();
            txtLocation = new TextBox();
            label3 = new Label();
            txtArtist = new TextBox();
            label2 = new Label();
            txtConcertName = new TextBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            numPrice = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            numStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Coral;
            lblStatus.Location = new Point(86, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 16);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "...";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(26, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(287, 36);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(221, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 30);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 313);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 30);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 30);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvConcerts
            // 
            dgvConcerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcerts.Location = new Point(337, 73);
            dgvConcerts.Name = "dgvConcerts";
            dgvConcerts.Size = new Size(298, 317);
            dgvConcerts.TabIndex = 18;
            dgvConcerts.CellClick += dgvConcerts_CellClick;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(191, 141);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 16;
            label3.Text = "Location";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(191, 112);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(100, 23);
            txtArtist.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 112);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 14;
            label2.Text = "Artist";
            // 
            // txtConcertName
            // 
            txtConcertName.Location = new Point(191, 83);
            txtConcertName.Name = "txtConcertName";
            txtConcertName.Size = new Size(100, 23);
            txtConcertName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 83);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 12;
            label1.Text = "Concert Name";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(91, 170);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 173);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 25;
            label4.Text = "Date";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(171, 199);
            numPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 203);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 27;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 234);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 28;
            label6.Text = "Stock";
            // 
            // numStock
            // 
            numStock.Location = new Point(171, 230);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 29;
            // 
            // ucManageConcert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numStock);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numPrice);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(lblStatus);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgvConcerts);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtArtist);
            Controls.Add(label2);
            Controls.Add(txtConcertName);
            Controls.Add(label1);
            Name = "ucManageConcert";
            Size = new Size(660, 462);
            Load += ucManageConcert_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgvConcerts;
        private TextBox txtLocation;
        private Label label3;
        private TextBox txtArtist;
        private Label label2;
        private TextBox txtConcertName;
        private Label label1;
        private DateTimePicker dtpDate;
        private Label label4;
        private NumericUpDown numPrice;
        private Label label5;
        private Label label6;
        private NumericUpDown numStock;
    }
}
