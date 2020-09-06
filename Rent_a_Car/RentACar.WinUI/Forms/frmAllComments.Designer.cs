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
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintRating = new System.Windows.Forms.Button();
            this.panelPrinting2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOfComment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDisable = new System.Windows.Forms.CheckBox();
            this.CommentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelPrinting2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComments
            // 
            this.dgvComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentId,
            this.FirstName,
            this.LastName,
            this.ManufacturerName,
            this.ModelName,
            this.DateOfComment});
            this.dgvComments.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.Location = new System.Drawing.Point(152, 277);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(996, 373);
            this.dgvComments.TabIndex = 0;
            this.dgvComments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvComments_MouseDoubleClick);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtManufacturerName.Location = new System.Drawing.Point(78, 55);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(203, 26);
            this.txtManufacturerName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(265, 202);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.chkDisable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtOfComment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtManufacturerName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(269, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters options";
            // 
            // btnPrintRating
            // 
            this.btnPrintRating.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrintRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrintRating.Location = new System.Drawing.Point(983, 656);
            this.btnPrintRating.Name = "btnPrintRating";
            this.btnPrintRating.Size = new System.Drawing.Size(165, 49);
            this.btnPrintRating.TabIndex = 4;
            this.btnPrintRating.Text = "Generate report";
            this.btnPrintRating.UseVisualStyleBackColor = false;
            this.btnPrintRating.Click += new System.EventHandler(this.btnPrintRating_Click);
            // 
            // panelPrinting2
            // 
            this.panelPrinting2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrinting2.Controls.Add(this.label8);
            this.panelPrinting2.Controls.Add(this.btnPrintRating);
            this.panelPrinting2.Controls.Add(this.groupBox1);
            this.panelPrinting2.Controls.Add(this.dgvComments);
            this.panelPrinting2.Location = new System.Drawing.Point(70, 12);
            this.panelPrinting2.Name = "panelPrinting2";
            this.panelPrinting2.Size = new System.Drawing.Size(1250, 723);
            this.panelPrinting2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(898, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "* double click on record to read details";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(360, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "By manufacturer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "By first name";
            // 
            // dtOfComment
            // 
            this.dtOfComment.Location = new System.Drawing.Point(156, 143);
            this.dtOfComment.Name = "dtOfComment";
            this.dtOfComment.Size = new System.Drawing.Size(203, 26);
            this.dtOfComment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "By date of comment";
            // 
            // chkDisable
            // 
            this.chkDisable.AutoSize = true;
            this.chkDisable.Location = new System.Drawing.Point(381, 143);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Size = new System.Drawing.Size(88, 24);
            this.chkDisable.TabIndex = 8;
            this.chkDisable.Text = "Disable";
            this.chkDisable.UseVisualStyleBackColor = true;
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
            // DateOfComment
            // 
            this.DateOfComment.DataPropertyName = "DateOfComment";
            this.DateOfComment.HeaderText = "Date of comment";
            this.DateOfComment.MinimumWidth = 6;
            this.DateOfComment.Name = "DateOfComment";
            this.DateOfComment.Width = 125;
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
            this.panelPrinting2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrintRating;
        private System.Windows.Forms.Panel panelPrinting2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOfComment;
        private System.Windows.Forms.CheckBox chkDisable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfComment;
    }
}