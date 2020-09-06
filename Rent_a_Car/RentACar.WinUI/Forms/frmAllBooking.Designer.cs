namespace RentACar.WinUI.Forms
{
    partial class frmAllBooking
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBookingSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookingSearch
            // 
            this.txtBookingSearch.Location = new System.Drawing.Point(163, 45);
            this.txtBookingSearch.Name = "txtBookingSearch";
            this.txtBookingSearch.Size = new System.Drawing.Size(225, 26);
            this.txtBookingSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBooking.Location = new System.Drawing.Point(191, 210);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(118, 41);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Search";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBooking);
            this.groupBox1.Controls.Add(this.txtBookingSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(377, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(293, 116);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(223, 26);
            this.dtEndDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reservation from";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(30, 116);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(223, 26);
            this.dtStartDate.TabIndex = 4;
            // 
            // dgvBooking
            // 
            this.dgvBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.FirstName,
            this.LastName,
            this.ManufacturerName,
            this.ModelName,
            this.StartDate,
            this.EndDate});
            this.dgvBooking.Location = new System.Drawing.Point(74, 304);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1155, 329);
            this.dgvBooking.TabIndex = 5;
            this.dgvBooking.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooking_CellMouseDoubleClick);
            // 
            // BookingId
            // 
            this.BookingId.DataPropertyName = "BookingId";
            this.BookingId.HeaderText = "BookingId";
            this.BookingId.MinimumWidth = 6;
            this.BookingId.Name = "BookingId";
            this.BookingId.Visible = false;
            this.BookingId.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturerName.DataPropertyName = "ManufacturerName";
            this.ManufacturerName.HeaderText = "Manufacturer name";
            this.ManufacturerName.MinimumWidth = 6;
            this.ManufacturerName.Name = "ManufacturerName";
            // 
            // ModelName
            // 
            this.ModelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "Model name";
            this.ModelName.MinimumWidth = 6;
            this.ModelName.Name = "ModelName";
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(979, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "* double click on record to read details";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(293, 159);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(227, 24);
            this.chkDate.TabIndex = 8;
            this.chkDate.Text = "Disable the filter by period";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "By first name";
            // 
            // frmAllBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 674);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAllBooking";
            this.Text = "frmAllBooking";
            this.Load += new System.EventHandler(this.frmAllBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookingSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label4;
    }
}