using RentACar.WinUI.Forms;
using System;
using System.Windows.Forms;

namespace RentACar.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllCustomers frm = new frmAllCustomers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAllVehicles frm = new frmViewAllVehicles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novoVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicle form = new frmAddVehicle();
            form.MdiParent = this;
            form.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewAllBranches form = new frmViewAllBranches();
            form.MdiParent = this;
            form.Show();
        }

        private void novaPoslovnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBranch form = new frmAddBranch();
            form.MdiParent = this;
            form.Show();
        }

        private void sveRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllBooking form = new frmAllBooking();
            form.MdiParent = this;
            form.Show();
        }

        private void pregledKomentaraKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllComments form = new frmAllComments();
            form.MdiParent = this;
            form.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.MdiParent = this;
            form.Show();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.MdiParent = this;
            form.Show();
        }

        private void informacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.MdiParent = this;
            form.Show();
        }

        private void pregledOcjenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRating form = new frmRating();
            form.MdiParent = this;
            form.Show();

        }

        private void newManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddManufacturer form = new frmAddManufacturer();
            form.MdiParent = this;
            form.Show();
        }

        private void newVehicleModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicleModel form = new frmAddVehicleModel();
            form.MdiParent = this;
            form.Show();
        }
    }
}
