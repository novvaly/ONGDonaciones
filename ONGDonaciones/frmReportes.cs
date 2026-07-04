using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Negocios;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentacion
{
    public partial class frmReportes : Form
    {
        private GestionONG gestion = new GestionONG();

        public frmReportes()
        {
            InitializeComponent();

            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Donantes");
            cmbTipoReporte.Items.Add("Donaciones");
            cmbTipoReporte.Items.Add("Beneficiarios");
            cmbTipoReporte.Items.Add("Ranking de Donantes");

            cmbTipoReporte.SelectedIndex = 0;

            CargarProyectos();
        }

        //==================================================
        // DONANTES
        //==================================================
        private void btnVerDonantes_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = gestion.ObtenerDonantes();
            lblTitulo.Text = "Reporte de Donantes";
        }

        //==================================================
        // DONACIONES
        //==================================================
        private void btnVerDonaciones_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = gestion.ObtenerDonaciones();
            lblTitulo.Text = "Reporte de Donaciones";
        }

        //==================================================
        // BENEFICIARIOS
        //==================================================
        private void btnVerBeneficiarios_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = gestion.ObtenerBeneficiarios();
            lblTitulo.Text = "Reporte de Beneficiarios";
        }
        //==================================================
        // GENERAR REPORTE
        //==================================================
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {


            if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un tipo de reporte.",
                    "Sistema ONG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            switch (cmbTipoReporte.Text)
            {
                case "Donantes":
                    dgvReportes.DataSource = gestion.ObtenerDonantes();
                    lblTitulo.Text = "Reporte de Donantes";
                    break;

                case "Donaciones":

                    if (cmbProyecto.SelectedIndex != -1)
                    {
                        dgvReportes.DataSource =
                            gestion.ObtenerDonacionesPorProyecto(
                                Convert.ToInt32(cmbProyecto.SelectedValue));
                    }
                    else
                    {
                        dgvReportes.DataSource =
                            gestion.ObtenerDonaciones();
                    }

                    lblTitulo.Text = "Reporte de Donaciones";
                    break;

                case "Beneficiarios":
                    dgvReportes.DataSource = gestion.ObtenerBeneficiarios();
                    lblTitulo.Text = "Reporte de Beneficiarios";
                    break;

                case "Ranking de Donantes":

                    List<string> ranking = gestion.ObtenerRankingDonantes();

                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("Ranking");

                    foreach (string item in ranking)
                    {
                        tabla.Rows.Add(item);
                    }

                    dgvReportes.DataSource = tabla;
                    lblTitulo.Text = "Ranking de Donantes";
                    break;
            }

            MessageBox.Show(
                "Reporte generado correctamente.",
                "Sistema ONG",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CargarProyectos()
        {
            DataTable dt = gestion.ObtenerProyectos();

            cmbProyecto.DataSource = dt;
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";
            cmbProyecto.SelectedIndex = -1;
        }
       
        //==================================================
        // EXPORTAR A PDF
        //==================================================
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReportes.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Primero genere un reporte.",
                    "Sistema ONG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo PDF|*.pdf";
                guardar.Title = "Guardar reporte";
                guardar.FileName = "ReporteONG.pdf";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    Document documento = new Document(PageSize.A4, 20, 20, 20, 20);

                    PdfWriter.GetInstance(
                        documento,
                        new FileStream(guardar.FileName, FileMode.Create));

                    documento.Open();

                    Paragraph titulo = new Paragraph(
                        lblTitulo.Text + "\n\n",
                        FontFactory.GetFont(
                            FontFactory.HELVETICA_BOLD,
                            18));

                    titulo.Alignment = Element.ALIGN_CENTER;

                    documento.Add(titulo);

                    documento.Add(new Paragraph(
                        "Fecha: " +
                        DateTime.Now.ToString("dd/MM/yyyy HH:mm")));

                    documento.Add(new Paragraph(" "));

                    PdfPTable tabla = new PdfPTable(dgvReportes.Columns.Count);

                    foreach (DataGridViewColumn columna in dgvReportes.Columns)
                    {
                        tabla.AddCell(new Phrase(columna.HeaderText));
                    }

                    foreach (DataGridViewRow fila in dgvReportes.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                tabla.AddCell(celda.Value?.ToString() ?? "");
                            }
                        }
                    }

                    documento.Add(tabla);

                    documento.Close();

                    MessageBox.Show(
                        "PDF generado correctamente.",
                        "Sistema ONG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==================================================
        // CERRAR
        //==================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //==================================================
        // EVENTOS
        //==================================================
        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            if (dgvReportes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una donación.");
                return;
            }

            int idDonacion = Convert.ToInt32(dgvReportes.CurrentRow.Cells["IdDonacion"].Value);
            int idDonante = Convert.ToInt32(dgvReportes.CurrentRow.Cells["IdDonante"].Value);
            int idProyecto = Convert.ToInt32(dgvReportes.CurrentRow.Cells["IdProyecto"].Value);

            Certificados frm = new Certificados(idDonacion, idDonante, idProyecto);
            frm.ShowDialog();
        }
    }
}