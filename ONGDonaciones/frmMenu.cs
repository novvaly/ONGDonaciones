using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnDonantes_Click(object sender, EventArgs e)
        {
            frmDonantes frm = new frmDonantes();
            frm.ShowDialog();
        }

        private void btnDonaciones_Click(object sender, EventArgs e)
        {
            frmDonaciones frm = new frmDonaciones();
            frm.ShowDialog();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            frmBeneficiarios frm = new frmBeneficiarios();
            frm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}