namespace ONGDonaciones
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            blbTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            picLogo = new PictureBox();
            lblClave = new Label();
            pnLinea = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // blbTitulo
            // 
            blbTitulo.AutoSize = true;
            blbTitulo.Font = new Font("Segoe UI", 14F);
            blbTitulo.ForeColor = Color.Navy;
            blbTitulo.Location = new Point(125, 93);
            blbTitulo.Name = "blbTitulo";
            blbTitulo.Size = new Size(181, 32);
            blbTitulo.TabIndex = 0;
            blbTitulo.Text = "INICIAR SESIÓN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(70, 141);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(150, 138);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(150, 173);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(200, 27);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.ForestGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(106, 217);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 35);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(232, 217);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 35);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Presentacion.Properties.Resources.ChatGPT_Image_1_jul_2026__12_20_49_a_m_;
            picLogo.Location = new Point(167, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(90, 90);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(46, 176);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(86, 20);
            lblClave.TabIndex = 7;
            lblClave.Text = "Contraseña:";
            lblClave.Click += lblClave_Click;
            // 
            // pnLinea
            // 
            pnLinea.BackColor = Color.ForestGreen;
            pnLinea.Location = new Point(312, 111);
            pnLinea.Name = "pnLinea";
            pnLinea.Size = new Size(100, 2);
            pnLinea.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(19, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 2);
            panel1.TabIndex = 9;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(432, 273);
            Controls.Add(panel1);
            Controls.Add(pnLinea);
            Controls.Add(lblClave);
            Controls.Add(picLogo);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(blbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Secion - Sistema ONG";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blbTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox picLogo;
        private Label lblClave;
        private Panel pnLinea;
        private Panel panel1;
    }
}
