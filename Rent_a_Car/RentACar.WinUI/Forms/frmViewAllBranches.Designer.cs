namespace RentACar.WinUI.Forms
{
    partial class frmViewAllBranches
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
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite naziv poslovnice";
            // 
            // dgvBranch
            // 
            this.dgvBranch.AllowUserToAddRows = false;
            this.dgvBranch.AllowUserToDeleteRows = false;
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Location = new System.Drawing.Point(114, 160);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.ReadOnly = true;
            this.dgvBranch.RowHeadersWidth = 51;
            this.dgvBranch.RowTemplate.Height = 24;
            this.dgvBranch.Size = new System.Drawing.Size(971, 382);
            this.dgvBranch.TabIndex = 3;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(404, 79);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(282, 24);
            this.cmbCity.TabIndex = 4;
            this.cmbCity.Text = "Izaberite";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // frmViewAllBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 648);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dgvBranch);
            this.Controls.Add(this.label1);
            this.Name = "frmViewAllBranches";
            this.Text = "frmViewAllBranches";
            this.Load += new System.EventHandler(this.frmViewAllBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBranch;
        private System.Windows.Forms.ComboBox cmbCity;
    }
}