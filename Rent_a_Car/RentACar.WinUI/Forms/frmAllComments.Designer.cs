namespace RentACar.WinUI.Forms
{
    partial class frmAllComments
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
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.CommentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintRating = new System.Windows.Forms.Button();
            this.panelPrinting2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelPrinting2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComments
            // 
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentId,
            this.FirstName,
            this.LastName,
            this.ManufacturerName,
            this.ModelName});
            this.dgvComments.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.Location = new System.Drawing.Point(123, 170);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(960, 373);
            this.dgvComments.TabIndex = 0;
            this.dgvComments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvComments_MouseDoubleClick);
            // 
            // CommentId
            // 
            this.CommentId.DataPropertyName = "CommentId";
            this.CommentId.HeaderText = "CommentId";
            this.CommentId.MinimumWidth = 6;
            this.CommentId.Name = "CommentId";
            this.CommentId.Visible = false;
            this.CommentId.Width = 125;
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(30, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(321, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(321, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesite proizvođača vozila";
            // 
            // btnPrintRating
            // 
            this.btnPrintRating.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrintRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintRating.Location = new System.Drawing.Point(895, 596);
            this.btnPrintRating.Name = "btnPrintRating";
            this.btnPrintRating.Size = new System.Drawing.Size(165, 49);
            this.btnPrintRating.TabIndex = 4;
            this.btnPrintRating.Text = "Print preview";
            this.btnPrintRating.UseVisualStyleBackColor = false;
            this.btnPrintRating.Click += new System.EventHandler(this.btnPrintRating_Click);
            // 
            // panelPrinting2
            // 
            this.panelPrinting2.Controls.Add(this.groupBox1);
            this.panelPrinting2.Controls.Add(this.dgvComments);
            this.panelPrinting2.Controls.Add(this.btnPrintRating);
            this.panelPrinting2.Location = new System.Drawing.Point(70, 23);
            this.panelPrinting2.Name = "panelPrinting2";
            this.panelPrinting2.Size = new System.Drawing.Size(1164, 682);
            this.panelPrinting2.TabIndex = 5;
            // 
            // frmAllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 760);
            this.Controls.Add(this.panelPrinting2);
            this.Name = "frmAllComments";
            this.Text = "frmAllComments";
            this.Load += new System.EventHandler(this.frmAllComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPrinting2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.Button btnPrintRating;
        private System.Windows.Forms.Panel panelPrinting2;
    }
}