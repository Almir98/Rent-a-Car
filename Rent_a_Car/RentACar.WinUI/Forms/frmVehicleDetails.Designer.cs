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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(486, 61);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(119, 17);
            this.test.TabIndex = 0;
            this.test.Text = "Registracijski broj";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(489, 90);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(344, 22);
            this.txtRegistracija.TabIndex = 1;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(489, 165);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(344, 22);
            this.txtVehicleNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj vozila";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(489, 298);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transmisija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detaljniji opis";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(489, 366);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(344, 22);
            this.txtDate.TabIndex = 11;
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(489, 495);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(344, 22);
            this.txtNumberOfSeats.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Datum proizvodnje";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Location = new System.Drawing.Point(489, 227);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(344, 22);
            this.txtDailyPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cijena po danu";
            // 
            // txtTransmission
            // 
            this.txtTransmission.Location = new System.Drawing.Point(489, 433);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(344, 22);
            this.txtTransmission.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Broj sjedećih mjesta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 165);
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
            this.chkStatus.Location = new System.Drawing.Point(489, 547);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(91, 21);
            this.chkStatus.TabIndex = 19;
            this.chkStatus.Text = "Dostupan";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumberOfSeats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.test);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}