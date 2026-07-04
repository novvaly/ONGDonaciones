namespace Presentacion
{
    partial class frmBeneficiarios
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
            dgvBeneficiarios = new DataGridView();
            btnBuscarBeneficiario = new Button();
            btnLimpiarBeneficiario = new Button();
            btnEliminarBeneficiario = new Button();
            btnEditarBeneficiario = new Button();
            btnGuardarBeneficiario = new Button();
            btnNuevoBeneficiario = new Button();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlDatos = new Panel();
            txtCedulaBeneficiario = new MaskedTextBox();
            txtTelefonoBeneficiario = new MaskedTextBox();
            dtpFechaBeneficiario = new DateTimePicker();
            cmbProyecto = new ComboBox();
            lblProyecto = new Label();
            lblFecha = new Label();
            lblDireccion = new Label();
            txtDireccionBeneficiario = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblCedula = new Label();
            txtNombreBeneficiario = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBeneficiarios).BeginInit();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBeneficiarios
            // 
            dgvBeneficiarios.AllowUserToAddRows = false;
            dgvBeneficiarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBeneficiarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeneficiarios.Location = new Point(42, 352);
            dgvBeneficiarios.Name = "dgvBeneficiarios";
            dgvBeneficiarios.ReadOnly = true;
            dgvBeneficiarios.RowHeadersWidth = 51;
            dgvBeneficiarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeneficiarios.Size = new Size(897, 193);
            dgvBeneficiarios.TabIndex = 26;
            dgvBeneficiarios.CellClick += dgvBeneficiarios_CellClick;
            // 
            // btnBuscarBeneficiario
            // 
            btnBuscarBeneficiario.BackColor = Color.MediumPurple;
            btnBuscarBeneficiario.FlatStyle = FlatStyle.Flat;
            btnBuscarBeneficiario.ForeColor = Color.White;
            btnBuscarBeneficiario.Location = new Point(671, 290);
            btnBuscarBeneficiario.Name = "btnBuscarBeneficiario";
            btnBuscarBeneficiario.Size = new Size(110, 38);
            btnBuscarBeneficiario.TabIndex = 25;
            btnBuscarBeneficiario.Text = "🔍 Buscar";
            btnBuscarBeneficiario.UseVisualStyleBackColor = false;
            btnBuscarBeneficiario.Click += btnBuscarBeneficiario_Click;
            // 
            // btnLimpiarBeneficiario
            // 
            btnLimpiarBeneficiario.BackColor = Color.IndianRed;
            btnLimpiarBeneficiario.FlatStyle = FlatStyle.Flat;
            btnLimpiarBeneficiario.ForeColor = Color.White;
            btnLimpiarBeneficiario.Location = new Point(822, 290);
            btnLimpiarBeneficiario.Name = "btnLimpiarBeneficiario";
            btnLimpiarBeneficiario.Size = new Size(110, 38);
            btnLimpiarBeneficiario.TabIndex = 24;
            btnLimpiarBeneficiario.Text = "Limpiar";
            btnLimpiarBeneficiario.UseVisualStyleBackColor = false;
            btnLimpiarBeneficiario.Click += btnLimpiarBeneficiario_Click;
            // 
            // btnEliminarBeneficiario
            // 
            btnEliminarBeneficiario.BackColor = Color.Crimson;
            btnEliminarBeneficiario.FlatStyle = FlatStyle.Flat;
            btnEliminarBeneficiario.ForeColor = Color.White;
            btnEliminarBeneficiario.Location = new Point(510, 290);
            btnEliminarBeneficiario.Name = "btnEliminarBeneficiario";
            btnEliminarBeneficiario.Size = new Size(110, 38);
            btnEliminarBeneficiario.TabIndex = 23;
            btnEliminarBeneficiario.Text = "🗑️ Eliminar";
            btnEliminarBeneficiario.UseVisualStyleBackColor = false;
            btnEliminarBeneficiario.Click += btnEliminarBeneficiario_Click;
            // 
            // btnEditarBeneficiario
            // 
            btnEditarBeneficiario.BackColor = Color.OrangeRed;
            btnEditarBeneficiario.FlatStyle = FlatStyle.Flat;
            btnEditarBeneficiario.ForeColor = Color.White;
            btnEditarBeneficiario.Location = new Point(357, 290);
            btnEditarBeneficiario.Name = "btnEditarBeneficiario";
            btnEditarBeneficiario.Size = new Size(110, 38);
            btnEditarBeneficiario.TabIndex = 22;
            btnEditarBeneficiario.Text = "✏️ Editar";
            btnEditarBeneficiario.UseVisualStyleBackColor = false;
            btnEditarBeneficiario.Click += btnEditarBeneficiario_Click;
            // 
            // btnGuardarBeneficiario
            // 
            btnGuardarBeneficiario.BackColor = Color.OliveDrab;
            btnGuardarBeneficiario.FlatStyle = FlatStyle.Flat;
            btnGuardarBeneficiario.ForeColor = Color.White;
            btnGuardarBeneficiario.Location = new Point(203, 290);
            btnGuardarBeneficiario.Name = "btnGuardarBeneficiario";
            btnGuardarBeneficiario.Size = new Size(110, 38);
            btnGuardarBeneficiario.TabIndex = 21;
            btnGuardarBeneficiario.Text = "💾 Guardar";
            btnGuardarBeneficiario.UseVisualStyleBackColor = false;
            btnGuardarBeneficiario.Click += btnGuardarBeneficiario_Click;
            // 
            // btnNuevoBeneficiario
            // 
            btnNuevoBeneficiario.BackColor = Color.DodgerBlue;
            btnNuevoBeneficiario.FlatStyle = FlatStyle.Flat;
            btnNuevoBeneficiario.ForeColor = Color.White;
            btnNuevoBeneficiario.Location = new Point(42, 290);
            btnNuevoBeneficiario.Name = "btnNuevoBeneficiario";
            btnNuevoBeneficiario.Size = new Size(110, 38);
            btnNuevoBeneficiario.TabIndex = 20;
            btnNuevoBeneficiario.Text = "➕ Nuevo";
            btnNuevoBeneficiario.UseVisualStyleBackColor = false;
            btnNuevoBeneficiario.Click += btnNuevoBeneficiario_Click;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.Crimson;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(picLogo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1081, 60);
            pnlEncabezado.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(73, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(394, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE BENEFICIARIOS";
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
            pnlDatos.Controls.Add(txtCedulaBeneficiario);
            pnlDatos.Controls.Add(txtTelefonoBeneficiario);
            pnlDatos.Controls.Add(dtpFechaBeneficiario);
            pnlDatos.Controls.Add(cmbProyecto);
            pnlDatos.Controls.Add(lblProyecto);
            pnlDatos.Controls.Add(lblFecha);
            pnlDatos.Controls.Add(lblDireccion);
            pnlDatos.Controls.Add(txtDireccionBeneficiario);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(lblCedula);
            pnlDatos.Controls.Add(txtNombreBeneficiario);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Location = new Point(12, 75);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(980, 180);
            pnlDatos.TabIndex = 27;
            // 
            // txtCedulaBeneficiario
            // 
            txtCedulaBeneficiario.Location = new Point(91, 73);
            txtCedulaBeneficiario.Mask = "000-0000000-0";
            txtCedulaBeneficiario.Name = "txtCedulaBeneficiario";
            txtCedulaBeneficiario.PromptChar = ' ';
            txtCedulaBeneficiario.Size = new Size(290, 27);
            txtCedulaBeneficiario.TabIndex = 16;
            // 
            // txtTelefonoBeneficiario
            // 
            txtTelefonoBeneficiario.Location = new Point(91, 120);
            txtTelefonoBeneficiario.Mask = "000-000-0000";
            txtTelefonoBeneficiario.Name = "txtTelefonoBeneficiario";
            txtTelefonoBeneficiario.PromptChar = ' ';
            txtTelefonoBeneficiario.Size = new Size(290, 27);
            txtTelefonoBeneficiario.TabIndex = 15;
            txtTelefonoBeneficiario.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // dtpFechaBeneficiario
            // 
            dtpFechaBeneficiario.Format = DateTimePickerFormat.Short;
            dtpFechaBeneficiario.Location = new Point(577, 124);
            dtpFechaBeneficiario.Name = "dtpFechaBeneficiario";
            dtpFechaBeneficiario.Size = new Size(125, 27);
            dtpFechaBeneficiario.TabIndex = 14;
            dtpFechaBeneficiario.ValueChanged += dtpFechaBeneficiario_ValueChanged;
            // 
            // cmbProyecto
            // 
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Items.AddRange(new object[] { "Educación", "Salud", "Alimentos", "Vivienda" });
            cmbProyecto.Location = new Point(577, 20);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(151, 28);
            cmbProyecto.TabIndex = 13;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(501, 21);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(70, 20);
            lblProyecto.TabIndex = 12;
            lblProyecto.Text = "Proyecto:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(440, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(130, 20);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha de Registro:";
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
            // txtDireccionBeneficiario
            // 
            txtDireccionBeneficiario.Location = new Point(576, 70);
            txtDireccionBeneficiario.Name = "txtDireccionBeneficiario";
            txtDireccionBeneficiario.Size = new Size(233, 27);
            txtDireccionBeneficiario.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Black;
            lblTelefono.Location = new Point(15, 124);
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
            lblCorreo.Size = new Size(0, 20);
            lblCorreo.TabIndex = 3;
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
            // txtNombreBeneficiario
            // 
            txtNombreBeneficiario.Location = new Point(91, 28);
            txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            txtNombreBeneficiario.Size = new Size(290, 27);
            txtNombreBeneficiario.TabIndex = 1;
            
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
            // frmBeneficiarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1002, 633);
            Controls.Add(pnlDatos);
            Controls.Add(dgvBeneficiarios);
            Controls.Add(btnBuscarBeneficiario);
            Controls.Add(btnLimpiarBeneficiario);
            Controls.Add(btnEliminarBeneficiario);
            Controls.Add(btnEditarBeneficiario);
            Controls.Add(btnGuardarBeneficiario);
            Controls.Add(btnNuevoBeneficiario);
            Controls.Add(pnlEncabezado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBeneficiarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Beneficiarios - Sistema ONG";
            Load += frmBeneficiarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBeneficiarios).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBeneficiarios;
        private Button btnBuscarBeneficiario;
        private Button btnLimpiarBeneficiario;
        private Button btnEliminarBeneficiario;
        private Button btnEditarBeneficiario;
        private Button btnGuardarBeneficiario;
        private Button btnNuevoBeneficiario;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Panel pnlDatos;
        private Label lblFecha;
        private Label lblDireccion;
        private TextBox txtDireccionBeneficiario;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblCedula;
        private TextBox txtNombreBeneficiario;
        private Label lblNombre;
        private Label lblProyecto;
        private ComboBox cmbProyecto;
        private DateTimePicker dtpFechaBeneficiario;
        private MaskedTextBox txtTelefonoBeneficiario;
        private MaskedTextBox txtCedulaBeneficiario;
    }
}