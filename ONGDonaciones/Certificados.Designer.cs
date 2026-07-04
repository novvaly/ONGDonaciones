namespace Presentacion
{
    partial class Certificados
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
            cmbProyecto = new ComboBox();
            cmbDonante = new ComboBox();
            lblDonante = new Label();
            lblTitulo = new Label();
            lblProyecto = new Label();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // cmbProyecto
            // 
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Items.AddRange(new object[] { "Donantes", "Donaciones", "Beneficiarios", "Certificados" });
            cmbProyecto.Location = new Point(65, 253);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(151, 28);
            cmbProyecto.TabIndex = 14;
            cmbProyecto.Click += cmbProyecto_SelectedIndexChanged;
            // 
            // cmbDonante
            // 
            cmbDonante.AutoCompleteCustomSource.AddRange(new string[] { "Todos", "Educación", "Salud", "Alimentación", "Vivienda" });
            cmbDonante.FormattingEnabled = true;
            cmbDonante.Items.AddRange(new object[] { "Educación", "Salud", "Alimentos", "Vivienda" });
            cmbDonante.Location = new Point(65, 156);
            cmbDonante.Name = "cmbDonante";
            cmbDonante.Size = new Size(151, 28);
            cmbDonante.TabIndex = 13;
            cmbDonante.Click += cmbDonante_SelectedIndexChanged;
            // 
            // lblDonante
            // 
            lblDonante.AutoSize = true;
            lblDonante.BackColor = Color.Transparent;
            lblDonante.Font = new Font("Segoe UI", 12F);
            lblDonante.ForeColor = Color.Black;
            lblDonante.Location = new Point(65, 106);
            lblDonante.Name = "lblDonante";
            lblDonante.Size = new Size(91, 28);
            lblDonante.TabIndex = 2;
            lblDonante.Text = "Donante:";
            lblDonante.Click += lblCedula_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(46, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(458, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CERTIFICADO DE DONACIÓN";
            lblTitulo.Click += lblNombre_Click;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.BackColor = Color.Transparent;
            lblProyecto.Font = new Font("Segoe UI", 12F);
            lblProyecto.ForeColor = Color.Black;
            lblProyecto.Location = new Point(65, 202);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(94, 28);
            lblProyecto.TabIndex = 16;
            lblProyecto.Text = "Proyecto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(180, 322);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(297, 322);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 19;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(62, 322);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 20;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Certificados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 431);
            Controls.Add(btnGenerar);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblProyecto);
            Controls.Add(lblTitulo);
            Controls.Add(cmbDonante);
            Controls.Add(cmbProyecto);
            Controls.Add(lblDonante);
            Name = "Certificados";
            Text = "Certificados";
            ResumeLayout(false);
            PerformLayout();
        }
       
        #endregion

        private ComboBox cmbProyecto;
        private ComboBox cmbDonante;
        private Label lblDonante;
        private Label lblTitulo;
        private Label lblProyecto;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Button btnGenerar;
    }
}