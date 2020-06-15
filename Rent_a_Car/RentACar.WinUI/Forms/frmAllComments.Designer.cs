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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.CommentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComments
            // 
            this.dgvComments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentId});
            this.dgvComments.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComments.Location = new System.Drawing.Point(68, 168);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 24;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.Size = new System.Drawing.Size(862, 362);
            this.dgvComments.TabIndex = 0;
            this.dgvComments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvComments_MouseDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(329, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CommentId
            // 
            this.CommentId.DataPropertyName = "CommentId";
            this.CommentId.HeaderText = "CommentId";
            this.CommentId.MinimumWidth = 6;
            this.CommentId.Name = "CommentId";
            this.CommentId.Width = 125;
            // 
            // frmAllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 607);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvComments);
            this.Name = "frmAllComments";
            this.Text = "frmAllComments";
            this.Load += new System.EventHandler(this.frmAllComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentId;
    }
}