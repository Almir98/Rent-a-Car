using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmCommReport : Form
    {
        private List<frmAllCommentsVM> _source;

        public frmCommReport(List<frmAllCommentsVM> source)
        {
            InitializeComponent();
            this._source = source;
        }

        private void frmCommReport_Load(object sender, EventArgs e)
        {
            frmAllCommentsVMBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}
