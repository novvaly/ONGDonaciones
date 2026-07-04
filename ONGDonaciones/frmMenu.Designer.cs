namespace Presentacion
{
    partial class frmMenu
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
            btnDonantes = new Button();
            lblMenu = new Label();
            btnCerrarSecion = new Button();
            btnReportes = new Button();
            btnDonaciones = new Button();
            btnBeneficiarios = new Button();
            pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.Teal;
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(picLogo);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.ForeColor = Color.Black;
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(908, 80);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(128, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(634, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SISTEMA DE CONTROL DE DONACIONES ONG";
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
            // btnDonantes
            // 
            btnDonantes.BackColor = Color.SlateBlue;
            btnDonantes.FlatStyle = FlatStyle.Flat;
            btnDonantes.Location = new Point(179, 175);
            btnDonantes.Name = "btnDonantes";
            btnDonantes.Size = new Size(212, 70);
            btnDonantes.TabIndex = 2;
            btnDonantes.Text = " 👤 Donantes ";
            btnDonantes.UseVisualStyleBackColor = false;
            btnDonantes.Click += btnDonantes_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Segoe UI", 18F);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(312, 83);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(251, 41);
            lblMenu.TabIndex = 7;
            lblMenu.Text = "MENÚ PRINCIPAL";
            // 
            // btnCerrarSecion
            // 
            btnCerrarSecion.BackColor = Color.Firebrick;
            btnCerrarSecion.FlatStyle = FlatStyle.Flat;
            btnCerrarSecion.Font = new Font("Segoe UI", 11F);
            btnCerrarSecion.Location = new Point(312, 441);
            btnCerrarSecion.Name = "btnCerrarSecion";
            btnCerrarSecion.Size = new Size(220, 55);
            btnCerrarSecion.TabIndex = 8;
            btnCerrarSecion.Text = "X Cerrar Sesión";
            btnCerrarSecion.UseVisualStyleBackColor = false;
            btnCerrarSecion.Click += btnCerrarSesion_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.LightCoral;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Location = new Point(470, 320);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(212, 70);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "📊 Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnDonaciones
            // 
            btnDonaciones.BackColor = Color.ForestGreen;
            btnDonaciones.FlatStyle = FlatStyle.Flat;
            btnDonaciones.ForeColor = Color.WhiteSmoke;
            btnDonaciones.Location = new Point(470, 175);
            btnDonaciones.Name = "btnDonaciones";
            btnDonaciones.Size = new Size(212, 70);
            btnDonaciones.TabIndex = 10;
            btnDonaciones.Text = "💰 Donaciones";
            btnDonaciones.UseVisualStyleBackColor = false;
            btnDonaciones.Click += btnDonaciones_Click;
            // 
            // btnBeneficiarios
            // 
            btnBeneficiarios.BackColor = Color.Orange;
            btnBeneficiarios.FlatStyle = FlatStyle.Flat;
            btnBeneficiarios.Location = new Point(179, 320);
            btnBeneficiarios.Name = "btnBeneficiarios";
            btnBeneficiarios.Size = new Size(212, 70);
            btnBeneficiarios.TabIndex = 11;
            btnBeneficiarios.Text = "❤️ Beneficiarios";
            btnBeneficiarios.UseVisualStyleBackColor = false;
            btnBeneficiarios.Click += btnBeneficiarios_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(908, 547);
            Controls.Add(btnBeneficiarios);
            Controls.Add(btnDonaciones);
            Controls.Add(btnReportes);
            Controls.Add(btnCerrarSecion);
            Controls.Add(lblMenu);
            Controls.Add(btnDonantes);
            Controls.Add(pnlEncabezado);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlEncabezado;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Button btnDonantes;
        private Label lblMenu;
        private Button btnCerrarSecion;
        private Button btnReportes;
        private Button btnDonaciones;
        private Button btnBeneficiarios;
    }
}