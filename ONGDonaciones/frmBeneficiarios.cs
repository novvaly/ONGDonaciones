using System;
using System.Data;
using System.Windows.Forms;
using Negocios;
using SistemaONG.Modelos;

namespace Presentacion
{
    public partial class frmBeneficiarios : Form
    {
        //==================================================
        // CAPA DE NEGOCIOS
        //==================================================
        private GestionONG gestion = new GestionONG();

        // Id del beneficiario seleccionado
        private int idBeneficiarioSeleccionado = 0;

        //==================================================
        // CONSTRUCTOR
        //==================================================
        public frmBeneficiarios()
        {
            InitializeComponent();

            CargarBeneficiarios();
            CargarProyectos();
        }

        //==================================================
        // CARGAR BENEFICIARIOS
        //==================================================
        private void CargarBeneficiarios()
        {
            dgvBeneficiarios.DataSource = gestion.ObtenerBeneficiarios();
        }

        //==================================================
        // CARGAR PROYECTOS
        //==================================================
        private void CargarProyectos()
        {
            cmbProyecto.DataSource = gestion.ObtenerProyectos();
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";
        }

        //==================================================
        // LIMPIAR CONTROLES
        //==================================================
        private void LimpiarCampos()
        {
            txtNombreBeneficiario.Clear();
            txtTelefonoBeneficiario.Clear();
            txtTelefonoBeneficiario.Clear();
            txtDireccionBeneficiario.Clear();

            cmbProyecto.SelectedIndex = -1;

            dtpFechaBeneficiario.Value = DateTime.Today;

            dgvBeneficiarios.ClearSelection();

            idBeneficiarioSeleccionado = 0;

            txtNombreBeneficiario.Focus();
        }

        //==================================================
        // BOTÓN NUEVO
        //==================================================
        private void btnNuevoBeneficiario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //==================================================
        // BOTÓN GUARDAR
        //==================================================
        private void btnGuardarBeneficiario_Click(object sender, EventArgs e)
        {
            
            try
            {
                Beneficiario b = new Beneficiario(
     txtNombreBeneficiario.Text,
     txtCedulaBeneficiario.Text,
     txtTelefonoBeneficiario.Text,
     txtDireccionBeneficiario.Text,
     Convert.ToInt32(cmbProyecto.SelectedValue),
     "",
     cmbProyecto.Text
 );

                gestion.AsignarBeneficiario(b);
                double impacto = b.CalcularImpacto();

                MessageBox.Show("Impacto del beneficiario: " + impacto);
                MessageBox.Show(
                    "Beneficiario registrado correctamente.",
                    "Sistema ONG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarBeneficiarios();

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombreBeneficiario.Text))
            {
                MessageBox.Show("Ingrese el nombre del beneficiario.");
                txtNombreBeneficiario.Focus();
                return;
            }

            // Validar cédula
            if (!txtCedulaBeneficiario.MaskCompleted)
            {
                MessageBox.Show("Ingrese una cédula válida.");
                txtCedulaBeneficiario.Focus();
                return;
            }

            // Validar teléfono
            if (!txtTelefonoBeneficiario.MaskCompleted)
            {
                MessageBox.Show("Ingrese un teléfono válido.");
                txtTelefonoBeneficiario.Focus();
                return;
            }

            // Validar proyecto
            if (cmbProyecto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proyecto.");
                cmbProyecto.Focus();
                return;
            }
        }


        //==================================================
        // SELECCIONAR BENEFICIARIO
        //==================================================
        private void dgvBeneficiarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvBeneficiarios.Rows[e.RowIndex];

            txtDireccionBeneficiario.Text =
                fila.Cells["Direccion"].Value.ToString();

            idBeneficiarioSeleccionado =
                Convert.ToInt32(fila.Cells["IdBeneficiario"].Value);

            txtNombreBeneficiario.Text =
                fila.Cells["Nombre"].Value.ToString();

            txtCedulaBeneficiario.Text =
                fila.Cells["Cedula"].Value.ToString();

            txtTelefonoBeneficiario.Text =
                fila.Cells["Telefono"].Value.ToString();

            cmbProyecto.Text =
                fila.Cells["Proyecto"].Value.ToString();
        }

        //==================================================
        // EDITAR
        //==================================================
        private void btnEditarBeneficiario_Click(object sender, EventArgs e)
        {
            if (idBeneficiarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un beneficiario.");
                return;
            }
            Beneficiario b = new Beneficiario(
                txtNombreBeneficiario.Text,
                txtCedulaBeneficiario.Text,
                txtTelefonoBeneficiario.Text,
                txtDireccionBeneficiario.Text,
                Convert.ToInt32(cmbProyecto.SelectedValue),
                "",
                cmbProyecto.Text
            );

            gestion.EditarBeneficiario(idBeneficiarioSeleccionado, b);

            MessageBox.Show("Beneficiario actualizado correctamente.");

            CargarBeneficiarios();

            LimpiarCampos();
        }

        //==================================================
        // ELIMINAR
        //==================================================
        private void btnEliminarBeneficiario_Click(object sender, EventArgs e)
        {
            if (idBeneficiarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un beneficiario.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea eliminar este beneficiario?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                gestion.EliminarBeneficiario(
                    idBeneficiarioSeleccionado);

                MessageBox.Show(
                    "Beneficiario eliminado correctamente.");

                CargarBeneficiarios();

                LimpiarCampos();
            }
        }

        //==================================================
        // BUSCAR
        //==================================================
        private void btnBuscarBeneficiario_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Nombre del beneficiario:",
                "Buscar");

            if (nombre == "")
                return;

            dgvBeneficiarios.DataSource =
                gestion.BuscarBeneficiarios(nombre);
        }

        //==================================================
        // LIMPIAR
        //==================================================
        private void btnLimpiarBeneficiario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtCedulaBeneficiario.ResetText();
            txtTelefonoBeneficiario.ResetText();
        }

        //==================================================
        // EVENTOS VACÍOS
        //==================================================
        private void frmBeneficiarios_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaBeneficiario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            private void txtNombreBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtNombreBeneficiario.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del beneficiario.");
                txtNombreBeneficiario.Focus();
                return;
            }
            // Que el nombre no empiece con espacio
            txtNombreBeneficiario.Text = txtNombreBeneficiario.Text.Trim();
        }

        
    }

    }

        