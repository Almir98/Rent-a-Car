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
    public partial class frmRatingReport : Form
    {
        private List<frmRatingVM> _source;
         
        public frmRatingReport(List<frmRatingVM> source)
        {
            InitializeComponent();
            this._source = source;
        }

        private void frmRatingReport_Load(object sender, EventArgs e)
        {
            frmRatingVMBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}
