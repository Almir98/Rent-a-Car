namespace RentACar.WinUI.Forms
{
    partial class frmViewAllVehicles
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
            this.txtSearchVehicle = new System.Windows.Forms.TextBox();
            this.btnShowVehicles = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchVehicle
            // 
            this.txtSearchVehicle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchVehicle.Location = new System.Drawing.Point(38, 72);
            this.txtSearchVehicle.Name = "txtSearchVehicle";
            this.txtSearchVehicle.Size = new System.Drawing.Size(312, 26);
            this.txtSearchVehicle.TabIndex = 1;
            // 
            // btnShowVehicles
            // 
            this.btnShowVehicles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShowVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowVehicles.Location = new System.Drawing.Point(431, 66);
            this.btnShowVehicles.Name = "btnShowVehicles";
            this.btnShowVehicles.Size = new System.Drawing.Size(104, 34);
            this.btnShowVehicles.TabIndex = 2;
            this.btnShowVehicles.Text = "Search";
            this.btnShowVehicles.UseVisualStyleBackColor = false;
            this.btnShowVehicles.Click += new System.EventHandler(this.btnShowVehicles_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleId,
            this.ManufacturerName,
            this.ModelName,
            this.RegistrationNumber,
            this.Mileage,
            this.Transmission,
            this.NumberOfSeats,
            this.FuelName});
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehicles.Location = new System.Drawing.Point(48, 328);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(1211, 398);
            this.dgvVehicles.TabIndex = 3;
            this.dgvVehicles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVehicles_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtSearchVehicle);
            this.groupBox1.Controls.Add(this.btnShowVehicles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(306, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by manufacturer name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(984, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "* double click on record to read details";
            // 
            // VehicleId
            // 
            this.VehicleId.DataPropertyName = "VehicleId";
            this.VehicleId.HeaderText = "VehicleId";
            this.VehicleId.MinimumWidth = 6;
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.Visible = false;
            this.VehicleId.Width = 125;
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
            // RegistrationNumber
            // 
            this.RegistrationNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumber.HeaderText = "Registration number";
            this.RegistrationNumber.MinimumWidth = 6;
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.ReadOnly = true;
            // 
            // Mileage
            // 
            this.Mileage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mileage.DataPropertyName = "Mileage";
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.MinimumWidth = 6;
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            // 
            // Transmission
            // 
            this.Transmission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Transmission.DataPropertyName = "Transmission";
            this.Transmission.HeaderText = "Transmission";
            this.Transmission.MinimumWidth = 6;
            this.Transmission.Name = "Transmission";
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberOfSeats.DataPropertyName = "NumberOfSeats";
            this.NumberOfSeats.HeaderText = "Number of seats";
            this.NumberOfSeats.MinimumWidth = 6;
            this.NumberOfSeats.Name = "NumberOfSeats";
            // 
            // FuelName
            // 
            this.FuelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FuelName.DataPropertyName = "FuelName";
            this.FuelName.HeaderText = "Fuel name";
            this.FuelName.MinimumWidth = 6;
            this.FuelName.Name = "FuelName";
            // 
            // frmViewAllVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 738);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "frmViewAllVehicles";
            this.Text = "frmViewAllVehicles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewAllVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchVehicle;
        private System.Windows.Forms.Button btnShowVehicles;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelName;
    }
}