namespace RentACar.WinUI.Forms
{
    partial class frmBookingDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking ID";
            // 
            // txtReservationID
            // 
            this.txtReservationID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReservationID.Location = new System.Drawing.Point(51, 93);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.ReadOnly = true;
            this.txtReservationID.Size = new System.Drawing.Size(294, 26);
            this.txtReservationID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(567, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start date of reservation";
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtStart.Location = new System.Drawing.Point(571, 91);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(321, 26);
            this.dtStart.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(567, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "End date of reservation";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtEndDate.Location = new System.Drawing.Point(571, 161);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(321, 26);
            this.dtEndDate.TabIndex = 10;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Prezime.Location = new System.Drawing.Point(47, 218);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(88, 20);
            this.Prezime.TabIndex = 22;
            this.Prezime.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(50, 250);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(295, 26);
            this.txtLastName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(47, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(50, 163);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(295, 26);
            this.txtFirstName.TabIndex = 23;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnback.Location = new System.Drawing.Point(653, 486);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(166, 43);
            this.btnback.TabIndex = 25;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTotalDays);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDailyPrice);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.txtReservationID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.Prezime);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(51, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 607);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(570, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Total days";
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotalDays.Location = new System.Drawing.Point(571, 321);
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.ReadOnly = true;
            this.txtTotalDays.Size = new System.Drawing.Size(130, 26);
            this.txtTotalDays.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(707, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "KM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(705, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(567, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotalPrice.Location = new System.Drawing.Point(571, 393);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 26);
            this.txtTotalPrice.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(567, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Daily price";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDailyPrice.Location = new System.Drawing.Point(571, 250);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.ReadOnly = true;
            this.txtDailyPrice.Size = new System.Drawing.Size(128, 26);
            this.txtDailyPrice.TabIndex = 31;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtModel.Location = new System.Drawing.Point(49, 448);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(295, 26);
            this.txtModel.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(50, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Manufacturer name";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtManufacturer.Location = new System.Drawing.Point(49, 353);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(295, 26);
            this.txtManufacturer.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Model name";
            // 
            // frmBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 679);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBookingDetails";
            this.Text = "frmBookingDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBookingDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalDays;
    }
}