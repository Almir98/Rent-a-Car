namespace RentACar.WinUI.Forms
{
    partial class frmRating
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
            this.dgvRating = new System.Windows.Forms.DataGridView();
            this.RatingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintRating = new System.Windows.Forms.Button();
            this.panelPrinting1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelPrinting1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRating
            // 
            this.dgvRating.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RatingId,
            this.FirstName,
            this.LastName,
            this.RatingValue,
            this.ManufacturerName,
            this.ModelName});
            this.dgvRating.Location = new System.Drawing.Point(26, 182);
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.RowHeadersWidth = 51;
            this.dgvRating.RowTemplate.Height = 24;
            this.dgvRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRating.Size = new System.Drawing.Size(1014, 382);
            this.dgvRating.TabIndex = 0;
            this.dgvRating.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRating_MouseDoubleClick);
            // 
            // RatingId
            // 
            this.RatingId.DataPropertyName = "RatingId";
            this.RatingId.HeaderText = "RatingId";
            this.RatingId.MinimumWidth = 6;
            this.RatingId.Name = "RatingId";
            this.RatingId.Visible = false;
            this.RatingId.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // RatingValue
            // 
            this.RatingValue.DataPropertyName = "RatingValue";
            this.RatingValue.HeaderText = "RatingValue";
            this.RatingValue.MinimumWidth = 6;
            this.RatingValue.Name = "RatingValue";
            this.RatingValue.Width = 125;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.DataPropertyName = "ManufacturerName";
            this.ManufacturerName.HeaderText = "ManufacturerName";
            this.ManufacturerName.MinimumWidth = 6;
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Width = 125;
            // 
            // ModelName
            // 
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "ModelName";
            this.ModelName.MinimumWidth = 6;
            this.ModelName.Name = "ModelName";
            this.ModelName.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVehicle);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(275, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesite ime vozila";
            // 
            // txtVehicle
            // 
            this.txtVehicle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVehicle.Location = new System.Drawing.Point(47, 60);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(294, 26);
            this.txtVehicle.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(452, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintRating
            // 
            this.btnPrintRating.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrintRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintRating.Location = new System.Drawing.Point(833, 600);
            this.btnPrintRating.Name = "btnPrintRating";
            this.btnPrintRating.Size = new System.Drawing.Size(165, 49);
            this.btnPrintRating.TabIndex = 2;
            this.btnPrintRating.Text = "Print preview";
            this.btnPrintRating.UseVisualStyleBackColor = false;
            this.btnPrintRating.Click += new System.EventHandler(this.btnPrintRating_Click);
            // 
            // panelPrinting1
            // 
            this.panelPrinting1.Controls.Add(this.label8);
            this.panelPrinting1.Controls.Add(this.txtSelected);
            this.panelPrinting1.Controls.Add(this.label6);
            this.panelPrinting1.Controls.Add(this.groupBox1);
            this.panelPrinting1.Controls.Add(this.btnPrintRating);
            this.panelPrinting1.Controls.Add(this.dgvRating);
            this.panelPrinting1.Location = new System.Drawing.Point(59, 38);
            this.panelPrinting1.Name = "panelPrinting1";
            this.panelPrinting1.Size = new System.Drawing.Size(1103, 691);
            this.panelPrinting1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(790, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "* double click on record to read details";
            // 
            // txtSelected
            // 
            this.txtSelected.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSelected.Location = new System.Drawing.Point(341, 596);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(90, 32);
            this.txtSelected.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 13F);
            this.label6.Location = new System.Drawing.Point(138, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total rating value : ";
            // 
            // frmRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 759);
            this.Controls.Add(this.panelPrinting1);
            this.Name = "frmRating";
            this.Text = "frmRating";
            this.Load += new System.EventHandler(this.frmRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPrinting1.ResumeLayout(false);
            this.panelPrinting1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.Button btnPrintRating;
        private System.Windows.Forms.Panel panelPrinting1;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}