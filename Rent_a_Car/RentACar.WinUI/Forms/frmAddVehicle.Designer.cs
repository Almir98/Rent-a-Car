namespace RentACar.WinUI.Forms
{
    partial class frmAddVehicle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbVehicleModel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.dtDte = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration number";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRegistrationNumber.Location = new System.Drawing.Point(27, 315);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(300, 26);
            this.txtRegistrationNumber.TabIndex = 1;
            this.txtRegistrationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegistrationNumber_Validating);
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVehicleNumber.Location = new System.Drawing.Point(27, 380);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(300, 26);
            this.txtVehicleNumber.TabIndex = 3;
            this.txtVehicleNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtVehicleNumber_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of vehicle";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDailyPrice.Location = new System.Drawing.Point(27, 465);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(300, 26);
            this.txtDailyPrice.TabIndex = 5;
            this.txtDailyPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtDailyPrice_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price per day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manufacturing date";
            // 
            // txtMileage
            // 
            this.txtMileage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMileage.Location = new System.Drawing.Point(399, 158);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(303, 26);
            this.txtMileage.TabIndex = 11;
            this.txtMileage.Validating += new System.ComponentModel.CancelEventHandler(this.txtMileage_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kilometer";
            // 
            // txtTransmission
            // 
            this.txtTransmission.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTransmission.Location = new System.Drawing.Point(399, 239);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(303, 26);
            this.txtTransmission.TabIndex = 13;
            this.txtTransmission.Validating += new System.ComponentModel.CancelEventHandler(this.txtTransmission_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Transmission";
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumberOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberOfSeats.Location = new System.Drawing.Point(401, 315);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(301, 26);
            this.txtNumberOfSeats.TabIndex = 15;
            this.txtNumberOfSeats.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfSeats_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of seats";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(399, 442);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(303, 28);
            this.cmbFuelType.TabIndex = 16;
            this.cmbFuelType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbFuelType_Validating);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.SystemColors.Control;
            this.chkStatus.Location = new System.Drawing.Point(399, 371);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(98, 24);
            this.chkStatus.TabIndex = 17;
            this.chkStatus.Text = "Available";
            this.chkStatus.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSacuvaj.Location = new System.Drawing.Point(770, 647);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(228, 53);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Save";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type of fuel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Model ";
            // 
            // cmbVehicleModel
            // 
            this.cmbVehicleModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbVehicleModel.FormattingEnabled = true;
            this.cmbVehicleModel.Location = new System.Drawing.Point(27, 158);
            this.cmbVehicleModel.Name = "cmbVehicleModel";
            this.cmbVehicleModel.Size = new System.Drawing.Size(300, 28);
            this.cmbVehicleModel.TabIndex = 23;
            this.cmbVehicleModel.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVehicleModel_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Type";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(27, 239);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(300, 28);
            this.cmbVehicleType.TabIndex = 25;
            this.cmbVehicleType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVehicleType_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(395, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Branch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Manufacturer";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(27, 79);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(300, 28);
            this.cmbManufacturer.TabIndex = 29;
            this.cmbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cmbManufacturer_SelectedIndexChanged);
            this.cmbManufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.cmbManufacturer_Validating);
            // 
            // dtDte
            // 
            this.dtDte.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtDte.Location = new System.Drawing.Point(27, 558);
            this.dtDte.Name = "dtDte";
            this.dtDte.Size = new System.Drawing.Size(300, 26);
            this.dtDte.TabIndex = 32;
            this.dtDte.Validating += new System.ComponentModel.CancelEventHandler(this.dtDte_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmbBranch);
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.btnAddImage);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rtxDescription);
            this.groupBox1.Controls.Add(this.cmbVehicleModel);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.dtDte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbManufacturer);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDailyPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.txtVehicleNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMileage);
            this.groupBox1.Controls.Add(this.txtRegistrationNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTransmission);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbFuelType);
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 723);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New vehicle";
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(401, 79);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(301, 28);
            this.cmbBranch.TabIndex = 37;
            this.cmbBranch.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBranch_Validating);
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImage.Location = new System.Drawing.Point(737, 325);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(261, 26);
            this.txtImage.TabIndex = 36;
            this.txtImage.Validating += new System.ComponentModel.CancelEventHandler(this.txtImage_Validating);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddImage.Location = new System.Drawing.Point(791, 380);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(160, 37);
            this.btnAddImage.TabIndex = 35;
            this.btnAddImage.Text = "Add photo";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentACar.WinUI.Properties.Resources.addPhotoIcon;
            this.pictureBox1.Location = new System.Drawing.Point(753, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // rtxDescription
            // 
            this.rtxDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxDescription.Location = new System.Drawing.Point(402, 536);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(300, 164);
            this.rtxDescription.TabIndex = 33;
            this.rtxDescription.Text = "";
            this.rtxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.rtxDescription_Validating);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 751);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddVehicle";
            this.Text = "frmAddVehicle";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVehicleModel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.DateTimePicker dtDte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}