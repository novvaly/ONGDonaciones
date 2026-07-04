using System;
using System.Windows.Forms;
using Negocios;
using SistemaONG.Modelos;

namespace Presentacion
{
    public partial class frmDonantes : Form
    {
        private GestionONG gestion = new GestionONG();
        private int idDonanteSeleccionado = 0;

        public frmDonantes()
        {
            InitializeComponent();
            CargarDonantes();
        }

        // =====================================================
        // CARGAR DONANTES
        // =====================================================
        private void CargarDonantes()
        {
            dgvDonante.DataSource = gestion.ObtenerDonantes();
        }

        // =====================================================
        // LIMPIAR CAMPOS
        // =====================================================
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

            // txtCedula y txtTelefono son MaskedTextBox:
            // se limpian asignando cadena vacía
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            dtpFechaDonante.Value = DateTime.Now;

            idDonanteSeleccionado = 0;

            txtNombre.Focus();
        }

        // =====================================================
        // VALIDAR CAMPOS (uso compartido por Guardar y Editar)
        // =====================================================
        private bool ValidarCampos()
        {
            // ---- Nombre: obligatorio y solo letras ----
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MostrarAdvertencia("Debe ingresar el nombre del donante.");
                txtNombre.Focus();
                return false;
            }

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MostrarAdvertencia("El nombre solo puede contener letras.");
                    txtNombre.Focus();
                    return false;
                }
            }
            // ---- Cédula ----
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MostrarAdvertencia("Debe ingresar la cédula.");
                txtCedula.Focus();
                return false;
            }

            if (txtCedula.Text.Length != 13)
            {
                MostrarAdvertencia("La cédula debe tener el formato 000-0000000-0.");
                txtCedula.Focus();
                return false;
            }

            // ---- Teléfono ----
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MostrarAdvertencia("Debe ingresar el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (txtTelefono.Text.Length != 12)
            {
                MostrarAdvertencia("El teléfono debe tener el formato 000-000-0000.");
                txtTelefono.Focus();
                return false;
            }

            // ---- Correo: obligatorio y con formato básico válido ----
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo))
            {
                MostrarAdvertencia("Debe ingresar el correo.");
                txtCorreo.Focus();
                return false;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MostrarAdvertencia("Ingrese un correo válido.");
                txtCorreo.Focus();
                return false;
            }

            // ---- Dirección: obligatoria ----
            if (string.IsNullOrWhiteSpace(txtDireccion.Text.Trim()))
            {
                MostrarAdvertencia("Debe ingresar la dirección.");
                txtDireccion.Focus();
                return false;
            }

            return true;
        }

        // =====================================================
        // MENSAJES UNIFORMES
        // =====================================================
        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrió un error:\n\n" + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // =====================================================
        // CREAR OBJETO DONANTE A PARTIR DE LOS CONTROLES
        // =====================================================
        private Donante ObtenerDonanteDesdeFormulario()
        {
            return new Donante(
                txtNombre.Text.Trim(),
                txtCedula.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtDireccion.Text.Trim(),
                dtpFechaDonante.Value
            );
        }

        // =====================================================
        // BOTÓN NUEVO
        // =====================================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // =====================================================
        // BOTÓN GUARDAR
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                Donante d = ObtenerDonanteDesdeFormulario();

                gestion.RegistrarDonante(d);

                MostrarExito("Donante registrado correctamente.");
                double impacto = d.CalcularImpacto();
                MessageBox.Show("Impacto del donante: " + impacto);
                CargarDonantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // =====================================================
        // SELECCIONAR FILA DEL DATAGRIDVIEW
        // =====================================================
        private void dgvDonantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvDonante.Rows[e.RowIndex];

            idDonanteSeleccionado = Convert.ToInt32(fila.Cells["IdDonante"].Value);

            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtCedula.Text = fila.Cells["Cedula"].Value.ToString();
            txtCorreo.Text = fila.Cells["Email"].Value.ToString();
            txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();

            dtpFechaDonante.Value = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value);
        }

        // =====================================================
        // BOTÓN EDITAR
        // =====================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDonanteSeleccionado == 0)
                {
                    MostrarAdvertencia("Seleccione un donante para editar.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                Donante d = ObtenerDonanteDesdeFormulario();

                gestion.EditarDonante(idDonanteSeleccionado, d);

                MostrarExito("Donante actualizado correctamente.");

                CargarDonantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // =====================================================
        // BOTÓN ELIMINAR
        // =====================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            if (idDonanteSeleccionado == 0)
            {
                MostrarAdvertencia("Seleccione un donante para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este donante?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                
                gestion.EliminarDonante(idDonanteSeleccionado);

                MostrarExito("Donante eliminado correctamente.");

                CargarDonantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // =====================================================
        // BOTÓN BUSCAR
        // =====================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            dgvDonante.DataSource = gestion.BuscarDonantes(txtNombre.Text.Trim());
        }

        // =====================================================
        // BOTÓN LIMPIAR
        // =====================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            CargarDonantes();      // ← vuelve a cargar todos los registros

            dgvDonante.ClearSelection();
        }

        // =====================================================
        // FILTRO DE TECLADO: NOMBRE (solo letras y espacio)
        // =====================================================
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void frmDonantes_Load(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}