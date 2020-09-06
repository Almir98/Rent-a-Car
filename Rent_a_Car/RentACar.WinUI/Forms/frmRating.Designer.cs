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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRatingValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRating.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RatingId,
            this.FirstName,
            this.LastName,
            this.RatingValue,
            this.ManufacturerName,
            this.ModelName});
            this.dgvRating.Location = new System.Drawing.Point(56, 275);
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
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // RatingValue
            // 
            this.RatingValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RatingValue.DataPropertyName = "RatingValue";
            this.RatingValue.HeaderText = "Rating value";
            this.RatingValue.MinimumWidth = 6;
            this.RatingValue.Name = "RatingValue";
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturerName.DataPropertyName = "ManufacturerName";
            this.ManufacturerName.HeaderText = "Manufacturer name";
            this.ManufacturerName.MinimumWidth = 6;
            this.ManufacturerName.Name = "ManufacturerName";
            // 
            // ModelName
            // 
            this.ModelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelName.DataPropertyName = "ModelName";
            this.ModelName.HeaderText = "Model name";
            this.ModelName.MinimumWidth = 6;
            this.ModelName.Name = "ModelName";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRatingValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVehicle);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(274, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "By rating value";
            // 
            // txtRatingValue
            // 
            this.txtRatingValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRatingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRatingValue.Location = new System.Drawing.Point(182, 115);
            this.txtRatingValue.Name = "txtRatingValue";
            this.txtRatingValue.Size = new System.Drawing.Size(232, 26);
            this.txtRatingValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "By manufacturer name";
            // 
            // txtVehicle
            // 
            this.txtVehicle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVehicle.Location = new System.Drawing.Point(182, 51);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(232, 26);
            this.txtVehicle.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(237, 168);
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
            this.btnPrintRating.Location = new System.Drawing.Point(868, 667);
            this.btnPrintRating.Name = "btnPrintRating";
            this.btnPrintRating.Size = new System.Drawing.Size(165, 49);
            this.btnPrintRating.TabIndex = 2;
            this.btnPrintRating.Text = "Generate report";
            this.btnPrintRating.UseVisualStyleBackColor = false;
            this.btnPrintRating.Click += new System.EventHandler(this.btnPrintRating_Click);
            // 
            // panelPrinting1
            // 
            this.panelPrinting1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrinting1.Controls.Add(this.label8);
            this.panelPrinting1.Controls.Add(this.txtSelected);
            this.panelPrinting1.Controls.Add(this.label6);
            this.panelPrinting1.Controls.Add(this.groupBox1);
            this.panelPrinting1.Controls.Add(this.btnPrintRating);
            this.panelPrinting1.Controls.Add(this.dgvRating);
            this.panelPrinting1.Location = new System.Drawing.Point(59, 12);
            this.panelPrinting1.Name = "panelPrinting1";
            this.panelPrinting1.Size = new System.Drawing.Size(1103, 735);
            this.panelPrinting1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(820, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "* double click on record to read details";
            // 
            // txtSelected
            // 
            this.txtSelected.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSelected.Location = new System.Drawing.Point(369, 687);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(90, 32);
            this.txtSelected.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 13F);
            this.label6.Location = new System.Drawing.Point(66, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Average value of all vehicles : ";
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
        private System.Windows.Forms.Button btnPrintRating;
        private System.Windows.Forms.Panel panelPrinting1;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRatingValue;
    }
}