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
            this.components = new System.ComponentModel.Container();
            this.dgvBranch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBranch
            // 
            this.dgvBranch.AllowUserToAddRows = false;
            this.dgvBranch.AllowUserToDeleteRows = false;
            this.dgvBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBranch.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchId,
            this.BranchName,
            this.PhoneNumber,
            this.Adress});
            this.dgvBranch.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBranch.Location = new System.Drawing.Point(231, 216);
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.ReadOnly = true;
            this.dgvBranch.RowHeadersWidth = 51;
            this.dgvBranch.RowTemplate.Height = 24;
            this.dgvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBranch.Size = new System.Drawing.Size(762, 330);
            this.dgvBranch.TabIndex = 3;
            this.dgvBranch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBranch_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(348, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select branch";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(77, 55);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(282, 28);
            this.cmbCity.TabIndex = 4;
            this.cmbCity.Text = "Izaberite";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(743, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "* double click on record to read details";
            // 
            // BranchId
            // 
            this.BranchId.DataPropertyName = "BranchId";
            this.BranchId.HeaderText = "BranchId";
            this.BranchId.MinimumWidth = 6;
            this.BranchId.Name = "BranchId";
            this.BranchId.ReadOnly = true;
            this.BranchId.Visible = false;
            this.BranchId.Width = 125;
            // 
            // BranchName
            // 
            this.BranchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BranchName.DataPropertyName = "BranchName";
            this.BranchName.HeaderText = "BranchName";
            this.BranchName.MinimumWidth = 6;
            this.BranchName.Name = "BranchName";
            this.BranchName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // frmViewAllBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 648);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBranch);
            this.Name = "frmViewAllBranches";
            this.Text = "frmViewAllBranches";
            this.Load += new System.EventHandler(this.frmViewAllBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
    }
}