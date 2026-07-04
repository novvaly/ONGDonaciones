namespace Presentacion
{
    partial class frmDonaciones
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
            dgvDonaciones = new DataGridView();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            pnlDatos = new Panel();
            cmbDonante = new ComboBox();
            dtpFechaDonacion = new DateTimePicker();
            cmbProyecto = new ComboBox();
            cmbTipo = new ComboBox();
            lblFecha = new Label();
            lblDireccion = new Label();
            txtBien = new TextBox();
            txtMonto = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblCedula = new Label();
            lblNombre = new Label();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).BeginInit();
            pnlDatos.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvDonaciones
            // 
            dgvDonaciones.AllowUserToAddRows = false;
            dgvDonaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonaciones.Location = new Point(40, 349);
            dgvDonaciones.Name = "dgvDonaciones";
            dgvDonaciones.ReadOnly = true;
            dgvDonaciones.RowHeadersWidth = 51;
            dgvDonaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonaciones.Size = new Size(897, 193);
            dgvDonaciones.TabIndex = 17;
            dgvDonaciones.CellClick += dgvDonaciones_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumPurple;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(669, 287);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 38);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(820, 287);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.PaleVioletRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(508, 287);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.OrangeRed;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(355, 287);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "✏️ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OliveDrab;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(201, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightSkyBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(40, 287);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 38);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "➕ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(cmbDonante);
            pnlDatos.Controls.Add(dtpFechaDonacion);
            pnlDatos.Controls.Add(cmbProyecto);
            pnlDatos.Controls.Add(cmbTipo);
            pnlDatos.Controls.Add(lblFecha);
            pnlDatos.Controls.Add(lblDireccion);
            pnlDatos.Controls.Add(txtBien);
            pnlDatos.Controls.Add(txtMonto);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(lblCedula);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Cursor = Cursors.SizeAll;
            pnlDatos.Location = new Point(12, 66);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(967, 185);
            pnlDatos.TabIndex = 10;
            // 
            // cmbDonante
            // 
            cmbDonante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonante.FormattingEnabled = true;
            cmbDonante.Location = new Point(92, 29);
            cmbDonante.Name = "cmbDonante";
            cmbDonante.Size = new Size(151, 28);
            cmbDonante.TabIndex = 15;
            // 
            // dtpFechaDonacion
            // 
            dtpFechaDonacion.Format = DateTimePickerFormat.Short;
            dtpFechaDonacion.Location = new Point(576, 120);
            dtpFechaDonacion.Name = "dtpFechaDonacion";
            dtpFechaDonacion.Size = new Size(104, 27);
            dtpFechaDonacion.TabIndex = 14;
            // 
            // cmbProyecto
            // 
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Items.AddRange(new object[] { "Educación", "Salud", "Alimentación", "Vivienda" });
            cmbProyecto.Location = new Point(576, 70);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(151, 28);
            cmbProyecto.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Efectivo", "En especie" });
            cmbTipo.Location = new Point(89, 70);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 12;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(515, 120);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(495, 70);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(70, 20);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Proyecto:";
            // 
            // txtBien
            // 
            txtBien.Location = new Point(576, 22);
            txtBien.Name = "txtBien";
            txtBien.Size = new Size(290, 27);
            txtBien.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(91, 113);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(290, 27);
            txtMonto.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(473, 25);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Bien donado:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.ForeColor = Color.Black;
            lblCorreo.Location = new Point(27, 120);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(56, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Monto:";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.Transparent;
            lblCedula.ForeColor = Color.Black;
            lblCedula.Location = new Point(41, 70);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(42, 20);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Tipo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(18, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Donante:";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.Navy;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(picLogo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1081, 60);
            pnlEncabezado.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(73, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(378, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE DONACIONES";
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
            // frmDonaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 633);
            Controls.Add(dgvDonaciones);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezado);
            Name = "frmDonaciones";
            Text = "Gestión de Donaciones - Sistema ONG";
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDonaciones;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Panel pnlDatos;
        private Label lblFecha;
        private Label lblDireccion;
        private TextBox txtBien;
        private TextBox txtMonto;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblCedula;
        private Label lblNombre;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private PictureBox picLogo;
        private ComboBox cmbTipo;
        private DateTimePicker dtpFechaDonacion;
        private ComboBox cmbProyecto;
        private ComboBox cmbDonante;
    }
}