namespace RentACar.WinUI.Forms
{
    partial class frmAddManufacturer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveManufacturer = new System.Windows.Forms.Button();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveManufacturer);
            this.groupBox1.Controls.Add(this.txtManufacturerName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(165, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 351);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(153, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer name";
            // 
            // btnSaveManufacturer
            // 
            this.btnSaveManufacturer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveManufacturer.Location = new System.Drawing.Point(157, 204);
            this.btnSaveManufacturer.Name = "btnSaveManufacturer";
            this.btnSaveManufacturer.Size = new System.Drawing.Size(177, 41);
            this.btnSaveManufacturer.TabIndex = 15;
            this.btnSaveManufacturer.Text = "Save";
            this.btnSaveManufacturer.UseVisualStyleBackColor = false;
            this.btnSaveManufacturer.Click += new System.EventHandler(this.btnSaveManufacturer_Click);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtManufacturerName.Location = new System.Drawing.Point(119, 127);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(267, 26);
            this.txtManufacturerName.TabIndex = 1;
            this.txtManufacturerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtManufacturerName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 640);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddManufacturer";
            this.Text = "frmAddManufacturer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}