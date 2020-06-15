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
            this.VehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchVehicle
            // 
            this.txtSearchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchVehicle.Location = new System.Drawing.Point(38, 72);
            this.txtSearchVehicle.Name = "txtSearchVehicle";
            this.txtSearchVehicle.Size = new System.Drawing.Size(312, 26);
            this.txtSearchVehicle.TabIndex = 1;
            // 
            // btnShowVehicles
            // 
            this.btnShowVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowVehicles.Location = new System.Drawing.Point(431, 66);
            this.btnShowVehicles.Name = "btnShowVehicles";
            this.btnShowVehicles.Size = new System.Drawing.Size(104, 34);
            this.btnShowVehicles.TabIndex = 2;
            this.btnShowVehicles.Text = "Pretraži";
            this.btnShowVehicles.UseVisualStyleBackColor = true;
            this.btnShowVehicles.Click += new System.EventHandler(this.btnShowVehicles_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleId,
            this.VehicleNumber,
            this.RegistrationNumber,
            this.Mileage,
            this.Status});
            this.dgvVehicles.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehicles.Location = new System.Drawing.Point(73, 253);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(794, 398);
            this.dgvVehicles.TabIndex = 3;
            this.dgvVehicles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVehicles_MouseDoubleClick);
            // 
            // VehicleId
            // 
            this.VehicleId.DataPropertyName = "VehicleID";
            this.VehicleId.HeaderText = "VehicleId";
            this.VehicleId.MinimumWidth = 6;
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.Visible = false;
            this.VehicleId.Width = 125;
            // 
            // VehicleNumber
            // 
            this.VehicleNumber.DataPropertyName = "VehicleNumber";
            this.VehicleNumber.HeaderText = "Broj vozila";
            this.VehicleNumber.MinimumWidth = 6;
            this.VehicleNumber.Name = "VehicleNumber";
            this.VehicleNumber.ReadOnly = true;
            this.VehicleNumber.Width = 150;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumber.HeaderText = "Broj registracije";
            this.RegistrationNumber.MinimumWidth = 6;
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.ReadOnly = true;
            this.RegistrationNumber.Width = 150;
            // 
            // Mileage
            // 
            this.Mileage.DataPropertyName = "Mileage";
            this.Mileage.HeaderText = "Kilometraža";
            this.Mileage.MinimumWidth = 6;
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            this.Mileage.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Dostupan";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchVehicle);
            this.groupBox1.Controls.Add(this.btnShowVehicles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.groupBox1.Location = new System.Drawing.Point(151, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po broju registracije";
            // 
            // frmViewAllVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 738);
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

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchVehicle;
        private System.Windows.Forms.Button btnShowVehicles;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}