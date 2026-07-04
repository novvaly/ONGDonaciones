using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocios;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace Presentacion
{
    public partial class Certificados : Form
    {
        private int idDonacion;
        private int idDonante;
        private int idProyecto;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCertificado();
        }
        private void GenerarCertificado()
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo PDF|*.pdf";
                guardar.FileName = "CertificadoDonacion.pdf";

                if (guardar.ShowDialog() != DialogResult.OK)
                    return;

                Document documento = new Document(PageSize.A4, 50, 50, 50, 50);

                PdfWriter.GetInstance(
                    documento,
                    new FileStream(guardar.FileName, FileMode.Create));

                documento.Open();

                Font titulo =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);

                Font texto =
                    FontFactory.GetFont(FontFactory.HELVETICA, 13);

                Paragraph pTitulo = new Paragraph(
                    "CERTIFICADO DE DONACIÓN",
                    titulo);

                pTitulo.Alignment = Element.ALIGN_CENTER;

                documento.Add(pTitulo);

                documento.Add(new Paragraph("\n"));

                documento.Add(new Paragraph(
                    "La Organización No Gubernamental (ONG) certifica que:",
                    texto));

                documento.Add(new Paragraph("\n"));

                Paragraph donante = new Paragraph(
                    cmbDonante.Text.ToUpper(),
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));

                donante.Alignment = Element.ALIGN_CENTER;

                documento.Add(donante);

                documento.Add(new Paragraph("\n"));

                documento.Add(new Paragraph(
                    "Realizó una donación al proyecto:",
                    texto));

                documento.Add(new Paragraph("\n"));

                Paragraph proyecto = new Paragraph(
                    cmbProyecto.Text.ToUpper(),
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));

                proyecto.Alignment = Element.ALIGN_CENTER;

                documento.Add(proyecto);

                documento.Add(new Paragraph("\n\n"));

                documento.Add(new Paragraph(
                    "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"),
                    texto));

                documento.Add(new Paragraph("\n\n\n"));

                Paragraph gracias = new Paragraph(
                    "Agradecemos su valioso aporte y compromiso con nuestra institución.",
                    texto);

                gracias.Alignment = Element.ALIGN_CENTER;

                documento.Add(gracias);

                documento.Add(new Paragraph("\n\n\n"));

                Paragraph firma = new Paragraph(
                    "__________________________\nFirma autorizada",
                    texto);

                firma.Alignment = Element.ALIGN_CENTER;

                documento.Add(firma);

                documento.Close();

                MessageBox.Show(
                    "Certificado generado correctamente.",
                    "Sistema ONG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbDonante.SelectedIndex = -1;
            cmbProyecto.SelectedIndex = -1;

            cmbDonante.Focus();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDonante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Certificados(int idDonacion, int idDonante, int idProyecto)
        {
            InitializeComponent();

            this.idDonacion = idDonacion;
            this.idDonante = idDonante;
            this.idProyecto = idProyecto;

            CargarDonantes();
            CargarProyectos();

            cmbDonante.SelectedValue = idDonante;
            cmbProyecto.SelectedValue = idProyecto;

            cmbDonante.Enabled = false;
            cmbProyecto.Enabled = false;
        }

        private GestionONG gestion = new GestionONG();


        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblCedula_Click(object sender, EventArgs e)
        {

        }

        private void CargarDonantes()
        {
            DataTable dt = gestion.ObtenerDonantes();

            cmbDonante.DataSource = null;
            cmbDonante.DataSource = dt;
            cmbDonante.DisplayMember = "Nombre";
            cmbDonante.ValueMember = "IdDonante";

            cmbDonante.SelectedIndex = 0;
        }
        private void CargarProyectos()
        {
            DataTable dt = gestion.ObtenerProyectos();

            cmbProyecto.DataSource = null;
            cmbProyecto.DataSource = dt;
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";

            cmbProyecto.SelectedIndex = 0;
        }


    }
}