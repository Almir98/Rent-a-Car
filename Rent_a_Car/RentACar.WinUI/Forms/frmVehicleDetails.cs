using RentaCar.Data.Requests;
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
    public partial class frmVehicleDetails : Form
    {
        private readonly APIService _apiservice = new APIService("Vehicle");
        private int? _id = null;

        public frmVehicleDetails(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var vehicle = await _apiservice.GetById<VehicleRequest>(_id);

                //txt polja


            }

        }
    }
}
