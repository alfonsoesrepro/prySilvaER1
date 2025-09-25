namespace prySilvaER1
{
    partial class frmInicioDeSesion
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
            cmdCancelar = new Button();
            cmdAceptar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            lblModulo = new Label();
            lstModulo = new ComboBox();
            SuspendLayout();
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(333, 105);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 11;
            cmdCancelar.Text = "&Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Location = new Point(333, 47);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(75, 23);
            cmdAceptar.TabIndex = 10;
            cmdAceptar.Text = "&Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(158, 105);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 9;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.ForeColor = Color.Blue;
            txtUsuario.Location = new Point(158, 47);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 8;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(51, 105);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 7;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(51, 55);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(51, 164);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 12;
            lblModulo.Text = "Módulo";
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstModulo.Location = new Point(158, 164);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(121, 23);
            lstModulo.TabIndex = 13;
            lstModulo.SelectedIndexChanged += lstModulo_SelectedIndexChanged;
            // 
            // frmInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 241);
            Controls.Add(lstModulo);
            Controls.Add(lblModulo);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmInicioDeSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCancelar;
        private Button cmdAceptar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private Label lblModulo;
        private ComboBox lstModulo;
    }
}
