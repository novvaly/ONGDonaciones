

namespace Presentacion
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDatos = new Panel();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            cmbTipoReporte = new ComboBox();
            cmbProyecto = new ComboBox();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblCedula = new Label();
            lblNombre = new Label();
            dgvReportes = new DataGridView();
            btnExportar = new Button();
            btnSalir = new Button();
            btnCertificados = new Button();
            btnGenerarReporte = new Button();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(dtpFechaFin);
            pnlDatos.Controls.Add(dtpFechaInicio);
            pnlDatos.Controls.Add(cmbTipoReporte);
            pnlDatos.Controls.Add(cmbProyecto);
            pnlDatos.Controls.Add(lblDireccion);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(lblCedula);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Location = new Point(12, 66);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(692, 131);
            pnlDatos.TabIndex = 36;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(429, 71);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(139, 27);
            dtpFechaFin.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(429, 23);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(139, 27);
            dtpFechaInicio.TabIndex = 15;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Donantes", "Donaciones", "Beneficiarios", "Certificados" });
            cmbTipoReporte.Location = new Point(153, 23);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(151, 28);
            cmbTipoReporte.TabIndex = 14;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // cmbProyecto
            // 
            cmbProyecto.AutoCompleteCustomSource.AddRange(new string[] { "Todos", "Educación", "Salud", "Alimentación", "Vivienda" });
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Items.AddRange(new object[] { "Educación", "Salud", "Alimentos", "Vivienda" });
            cmbProyecto.Location = new Point(153, 70);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(151, 28);
            cmbProyecto.TabIndex = 13;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(350, 73);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(73, 20);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Fecha Fin:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(333, 23);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(90, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Fecha Inicio:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.ForeColor = Color.Black;
            lblCorreo.Location = new Point(27, 120);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(0, 20);
            lblCorreo.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.Transparent;
            lblCedula.ForeColor = Color.Black;
            lblCedula.Location = new Point(77, 70);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 20);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Proyecto:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(27, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Tipo de Reporte:";
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(12, 268);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(692, 173);
            dgvReportes.TabIndex = 35;
            dgvReportes.CellContentClick += dgvReportes_CellContentClick;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.MediumPurple;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(90, 462);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(133, 38);
            btnExportar.TabIndex = 34;
            btnExportar.Text = "📄 Exportar PDF";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(486, 462);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 38);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "❌ Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnCerrar_Click;
            // 
            // btnCertificados
            // 
            btnCertificados.BackColor = Color.DarkOrange;
            btnCertificados.FlatStyle = FlatStyle.Flat;
            btnCertificados.ForeColor = Color.White;
            btnCertificados.Location = new Point(292, 462);
            btnCertificados.Name = "btnCertificados";
            btnCertificados.Size = new Size(129, 38);
            btnCertificados.TabIndex = 31;
            btnCertificados.Text = "📑 Certificados";
            btnCertificados.UseVisualStyleBackColor = false;
            btnCertificados.Click += btnCertificados_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.ForestGreen;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(271, 212);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(165, 38);
            btnGenerarReporte.TabIndex = 30;
            btnGenerarReporte.Text = "📊 Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.Navy;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(picLogo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1081, 60);
            pnlEncabezado.TabIndex = 28;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(73, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(412, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REPORTES DEL SISTEMA ONG";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.ChatGPT_Image_1_jul_2026__12_20_49_a_m_;
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(46, 33);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(738, 528);
            Controls.Add(pnlDatos);
            Controls.Add(dgvReportes);
            Controls.Add(btnExportar);
            Controls.Add(btnSalir);
            Controls.Add(btnCertificados);
            Controls.Add(btnGenerarReporte);
            Controls.Add(pnlEncabezado);
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes - Sistema ONG";
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatos;
        private ComboBox cmbProyecto;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblCedula;
        private Label lblNombre;
        private DataGridView dgvReportes;
        private Button btnExportar;
        private Button btnSalir;
        private Button btnCertificados;
        private Button btnGenerarReporte;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private PictureBox picLogo;
        private ComboBox cmbTipoReporte;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
    }
}