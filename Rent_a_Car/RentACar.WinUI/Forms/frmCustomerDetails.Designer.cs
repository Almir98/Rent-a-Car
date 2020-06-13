namespace RentACar.WinUI.Forms
{
    partial class frmCustomerDetails
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAllCustomersBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(405, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(405, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(75, 346);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(405, 22);
            this.txtCityName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(75, 195);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(405, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 123);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(405, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Naziv grada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Broj telefona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prezime";
            // 
            // btnAllCustomersBack
            // 
            this.btnAllCustomersBack.Location = new System.Drawing.Point(400, 406);
            this.btnAllCustomersBack.Name = "btnAllCustomersBack";
            this.btnAllCustomersBack.Size = new System.Drawing.Size(80, 32);
            this.btnAllCustomersBack.TabIndex = 15;
            this.btnAllCustomersBack.Text = "Nazad";
            this.btnAllCustomersBack.UseVisualStyleBackColor = true;
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.btnAllCustomersBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerDetails";
            this.Text = "frmCustomerDetails";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAllCustomersBack;
    }
}