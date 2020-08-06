namespace RentACar.WinUI.Forms
{
    partial class frmVehicleDetails
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
            this.test = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.test.Location = new System.Drawing.Point(499, 27);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(154, 20);
            this.test.TabIndex = 0;
            this.test.Text = "Registation number";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRegistracija.Location = new System.Drawing.Point(503, 60);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.ReadOnly = true;
            this.txtRegistracija.Size = new System.Drawing.Size(344, 26);
            this.txtRegistracija.TabIndex = 1;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVehicleNumber.Location = new System.Drawing.Point(503, 130);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.ReadOnly = true;
            this.txtVehicleNumber.Size = new System.Drawing.Size(348, 26);
            this.txtVehicleNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(500, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle number";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(503, 270);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(344, 26);
            this.txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(499, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transmission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(499, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDate.Location = new System.Drawing.Point(503, 338);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(344, 26);
            this.txtDate.TabIndex = 11;
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumberOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberOfSeats.Location = new System.Drawing.Point(504, 467);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.ReadOnly = true;
            this.txtNumberOfSeats.Size = new System.Drawing.Size(343, 26);
            this.txtNumberOfSeats.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(499, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Manufacturer date";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDailyPrice.Location = new System.Drawing.Point(503, 199);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.ReadOnly = true;
            this.txtDailyPrice.Size = new System.Drawing.Size(344, 26);
            this.txtDailyPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(503, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price per day";
            // 
            // txtTransmission
            // 
            this.txtTransmission.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTransmission.Location = new System.Drawing.Point(504, 405);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.ReadOnly = true;
            this.txtTransmission.Size = new System.Drawing.Size(343, 26);
            this.txtTransmission.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(500, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number of seats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 316);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkStatus.Location = new System.Drawing.Point(507, 524);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(98, 24);
            this.chkStatus.TabIndex = 19;
            this.chkStatus.Text = "Available";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(669, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRegistracija);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.txtTransmission);
            this.groupBox1.Controls.Add(this.txtDailyPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVehicleNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(40, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 625);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle details";
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 760);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}