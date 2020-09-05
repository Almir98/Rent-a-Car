namespace RentACar.WinUI.Forms
{
    partial class frmAddVehicleModel
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
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveVehicleModel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtModelName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbManufacturer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveVehicleModel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(184, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 397);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new vehicle model";
            // 
            // txtModelName
            // 
            this.txtModelName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModelName.Location = new System.Drawing.Point(143, 223);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(270, 26);
            this.txtModelName.TabIndex = 32;
            this.txtModelName.Validating += new System.ComponentModel.CancelEventHandler(this.txtModelName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(186, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter the model name";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(143, 95);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(270, 28);
            this.cmbManufacturer.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(186, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose manufacturer ";
            // 
            // btnSaveVehicleModel
            // 
            this.btnSaveVehicleModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveVehicleModel.Location = new System.Drawing.Point(182, 312);
            this.btnSaveVehicleModel.Name = "btnSaveVehicleModel";
            this.btnSaveVehicleModel.Size = new System.Drawing.Size(177, 41);
            this.btnSaveVehicleModel.TabIndex = 15;
            this.btnSaveVehicleModel.Text = "Save";
            this.btnSaveVehicleModel.UseVisualStyleBackColor = false;
            this.btnSaveVehicleModel.Click += new System.EventHandler(this.btnSaveManufacturer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddVehicleModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddVehicleModel";
            this.Text = "frmAddVehicleModel";
            this.Load += new System.EventHandler(this.frmAddVehicleModel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveVehicleModel;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}