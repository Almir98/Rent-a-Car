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
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCanceled = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberOfDays.Location = new System.Drawing.Point(50, 316);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.ReadOnly = true;
            this.txtNumberOfDays.Size = new System.Drawing.Size(295, 26);
            this.txtNumberOfDays.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(46, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of days";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotalPrice.Location = new System.Drawing.Point(50, 398);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(295, 26);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(52, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total price";
            // 
            // txtDisscount
            // 
            this.txtDisscount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDisscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDisscount.Location = new System.Drawing.Point(571, 239);
            this.txtDisscount.Name = "txtDisscount";
            this.txtDisscount.Size = new System.Drawing.Size(321, 26);
            this.txtDisscount.TabIndex = 7;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(568, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(568, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Discount";
            // 
            // chkCanceled
            // 
            this.chkCanceled.AutoSize = true;
            this.chkCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkCanceled.Location = new System.Drawing.Point(51, 478);
            this.chkCanceled.Name = "chkCanceled";
            this.chkCanceled.Size = new System.Drawing.Size(101, 24);
            this.chkCanceled.TabIndex = 17;
            this.chkCanceled.Text = "Canceled";
            this.chkCanceled.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(571, 328);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(321, 166);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
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
            this.btnback.Location = new System.Drawing.Point(639, 537);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(166, 43);
            this.btnback.TabIndex = 25;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.txtReservationID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtNumberOfDays);
            this.groupBox1.Controls.Add(this.Prezime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkCanceled);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.txtDisscount);
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
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkCanceled;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}