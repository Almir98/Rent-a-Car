namespace RentACar.WinUI.Forms
{
    partial class frmCommReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.frmAllCommentsVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.frmAllCommentsVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAllCommentsVMBindingSource
            // 
            this.frmAllCommentsVMBindingSource.DataSource = typeof(RentaCar.Data.ViewModel.frmAllCommentsVM);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "frmPrikaz";
            reportDataSource1.Value = this.frmAllCommentsVMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentACar.WinUI.Reports.CommentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1309, 597);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmCommReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmCommReport";
            this.Text = "frmCommReport";
            this.Load += new System.EventHandler(this.frmCommReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmAllCommentsVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource frmAllCommentsVMBindingSource;
    }
}