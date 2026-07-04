using Presentacion;

namespace ONGDonaciones
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Novaly" &&
                txtClave.Text == "1234")
            {
                frmMenu menu = new frmMenu();

                this.Hide();

                menu.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
