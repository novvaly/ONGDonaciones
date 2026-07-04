namespace Presentacion
{
    partial class frmDonantes
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
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlDatos = new Panel();
            dtpFechaDonante = new DateTimePicker();
            lblFecha = new Label();
            lblDireccion = new Label();
            txtCedula = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblCedula = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvDonante = new DataGridView();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonante).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.SeaGreen;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(picLogo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1020, 60);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(73, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(345, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE DONANTES";
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
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(dtpFechaDonante);
            pnlDatos.Controls.Add(lblFecha);
            pnlDatos.Controls.Add(lblDireccion);
            pnlDatos.Controls.Add(txtCedula);
            pnlDatos.Controls.Add(txtDireccion);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(txtCorreo);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(lblCedula);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Location = new Point(10, 66);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(980, 180);
            pnlDatos.TabIndex = 1;
            // 
            // dtpFechaDonante
            // 
            dtpFechaDonante.Format = DateTimePickerFormat.Short;
            dtpFechaDonante.Location = new Point(574, 120);
            dtpFechaDonante.Name = "dtpFechaDonante";
            dtpFechaDonante.Size = new Size(123, 27);
            dtpFechaDonante.TabIndex = 12;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(461, 120);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(109, 20);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha Registro:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(495, 70);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Direccion:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(91, 73);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(290, 27);
            txtCedula.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(576, 70);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(290, 27);
            txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(576, 22);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(290, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(91, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(290, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(500, 25);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.ForeColor = Color.Black;
            lblCorreo.Location = new Point(27, 120);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.BackColor = Color.Transparent;
            lblCedula.ForeColor = Color.Black;
            lblCedula.Location = new Point(27, 73);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(58, 20);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cedula:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(18, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DodgerBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(58, 262);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 38);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "➕ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(212, 262);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SlateBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(364, 262);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "✏️ Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(520, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.HotTrack;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(822, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumPurple;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(677, 262);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 38);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvDonante
            // 
            dgvDonante.AllowUserToAddRows = false;
            dgvDonante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonante.Location = new Point(49, 318);
            dgvDonante.Name = "dgvDonante";
            dgvDonante.ReadOnly = true;
            dgvDonante.RowHeadersWidth = 51;
            dgvDonante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
            dgvDonante.Size = new Size(897, 193);
            dgvDonante.TabIndex = 8;
            dgvDonante.CellClick += dgvDonantes_CellClick;

            // 
            // frmDonantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1002, 573);
            Controls.Add(dgvDonante);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(pnlDatos);
            Controls.Add(pnlEncabezado);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(320, 12);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmDonantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Donantes - Sistema ONG";
            Load += frmDonantes_Load;
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEncabezado;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblCedula;
        private Label lblFecha;
        private Label lblDireccion;
        private TextBox txtCedula;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DataGridView dgvDonante;
        private DateTimePicker dtpFechaDonante;
    }

}
