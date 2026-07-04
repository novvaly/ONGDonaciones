using System;
using System.Data;
using System.Windows.Forms;
using Negocios;
using SistemaONG.Modelos;

namespace Presentacion
{
    public partial class frmDonaciones : Form
    {
        private GestionONG gestion = new GestionONG();
        private int idDonacionSeleccionada = 0;

        public frmDonaciones()
        {
            InitializeComponent();
            CargarDonantes();
            CargarProyectos();
            CargarDonaciones();
        }

        // =====================================================
        // CARGA DE DATOS
        // =====================================================
        private void CargarDonantes()
        {
            DataTable dt = gestion.ObtenerDonantes();
            cmbDonante.DataSource = dt;
            cmbDonante.DisplayMember = "Nombre";
            cmbDonante.ValueMember = "IdDonante";
        }

        private void CargarProyectos()
        {
            DataTable dt = gestion.ObtenerProyectos();
            cmbProyecto.DataSource = dt;
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";
        }

        private void CargarDonaciones()
        {
            dgvDonaciones.DataSource = gestion.ObtenerDonaciones();
        }

        // =====================================================
        // LIMPIAR CAMPOS
        // =====================================================
        private void LimpiarCampos()
        {
            txtMonto.Clear();
            cmbTipo.SelectedIndex = 0;
            txtBien.Clear();

            txtBien.Enabled = false;
            txtMonto.Enabled = true;

            dtpFechaDonacion.Value = DateTime.Now;

            idDonacionSeleccionada = 0;

            cmbDonante.Focus();
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
        // VALIDAR CAMPOS (compartido por Guardar y Editar)
        // =====================================================
        private bool ValidarCampos(out double monto)
        {
            monto = 0;

            // ---- Donante obligatorio ----
            if (cmbDonante.SelectedValue == null)
            {
                MostrarAdvertencia("Seleccione un donante.");
                cmbDonante.Focus();
                return false;
            }

            // ---- Proyecto obligatorio ----
            if (cmbProyecto.SelectedValue == null)
            {
                MostrarAdvertencia("Seleccione un proyecto.");
                cmbProyecto.Focus();
                return false;
            }

            bool esEfectivo = cmbTipo.Text == "Efectivo";

            if (esEfectivo)
            {
                // ---- Monto obligatorio y numérico ----
                string textoMonto = txtMonto.Text.Trim();

                if (string.IsNullOrWhiteSpace(textoMonto))
                {
                    MostrarAdvertencia("Ingrese el monto.");
                    txtMonto.Focus();
                    return false;
                }

                if (!double.TryParse(textoMonto, out monto) || monto <= 0)
                {
                    MostrarAdvertencia("Ingrese un monto válido, mayor que cero.");
                    txtMonto.Focus();
                    return false;
                }
            }
            else
            {
                // ---- Bien donado obligatorio ----
                if (string.IsNullOrWhiteSpace(txtBien.Text.Trim()))
                {
                    MostrarAdvertencia("Ingrese el bien donado.");
                    txtBien.Focus();
                    return false;
                }
            }

            return true;
        }

        // =====================================================
        // CREAR OBJETO DONACIÓN A PARTIR DEL FORMULARIO
        // =====================================================
        private Donacion CrearDonacionDesdeFormulario(double monto)
        {
            Donante d = new Donante("", "", "", "", "", DateTime.Now)
            {
                Id = Convert.ToInt32(cmbDonante.SelectedValue)
            };

            Donacion donacion = cmbTipo.Text == "Efectivo"
                ? new Donacion(d, monto)
                : new Donacion(d, txtBien.Text.Trim());

            donacion.IdProyecto = Convert.ToInt32(cmbProyecto.SelectedValue);
            donacion.Fecha = dtpFechaDonacion.Value;

            return donacion;
        }

        // =====================================================
        // CAMBIO DE TIPO DE DONACIÓN
        // =====================================================
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esEspecie = cmbTipo.Text == "En especie";

            txtBien.Enabled = esEspecie;
            txtMonto.Enabled = !esEspecie;

            if (esEspecie)
                txtMonto.Clear();
            else
                txtBien.Clear();
        }

        // =====================================================
        // BOTÓN GUARDAR
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(out double monto))
                    return;

                Donacion donacion = CrearDonacionDesdeFormulario(monto);

                gestion.RegistrarDonacion(donacion);

                MostrarExito("Donación registrada correctamente.");

                CargarDonaciones();
                cmbTipo_SelectedIndexChanged(null, null);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // =====================================================
        // BOTÓN EDITAR
        // =====================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDonacionSeleccionada == 0)
                {
                    MostrarAdvertencia("Seleccione una donación para editar.");
                    return;
                }

                if (!ValidarCampos(out double monto))
                    return;

                gestion.EditarDonacion(
                    idDonacionSeleccionada,
                    Convert.ToInt32(cmbDonante.SelectedValue),
                    Convert.ToInt32(cmbProyecto.SelectedValue),
                    monto,
                    dtpFechaDonacion.Value,
                    cmbTipo.Text);

                MostrarExito("Donación actualizada correctamente.");

                CargarDonaciones();
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
            if (idDonacionSeleccionada == 0)
            {
                MostrarAdvertencia("Seleccione una donación para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar esta donación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                gestion.EliminarDonacion(idDonacionSeleccionada);

                MostrarExito("Donación eliminada correctamente.");

                CargarDonaciones();
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
        private void dgvDonaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvDonaciones.Rows[e.RowIndex];

            idDonacionSeleccionada = Convert.ToInt32(fila.Cells["IdDonacion"].Value);

            cmbDonante.Text = fila.Cells["Donante"].Value?.ToString() ?? "";
            cmbProyecto.Text = fila.Cells["Proyecto"].Value?.ToString() ?? "";
            txtMonto.Text = fila.Cells["Monto"].Value?.ToString() ?? "";
            cmbTipo.Text = fila.Cells["MetodoPago"].Value?.ToString() ?? "";

            dtpFechaDonacion.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
        }

        // =====================================================
        // BOTÓN NUEVO / LIMPIAR
        // =====================================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // =====================================================
        // BOTÓN CERRAR
        // =====================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // BOTÓN BUSCAR
        // =====================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el nombre del donante:",
                "Buscar");

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                dgvDonaciones.DataSource = gestion.BuscarDonaciones(nombre.Trim());
            }
        }

        // =====================================================
        // FILTRO DE TECLADO: MONTO (solo números y un punto decimal)
        // =====================================================
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir un único punto decimal
            if (e.KeyChar == '.' && !txtMonto.Text.Contains("."))
                return;

            e.Handled = true;
        }
    }
}