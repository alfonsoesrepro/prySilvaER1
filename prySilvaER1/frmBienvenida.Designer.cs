namespace prySilvaER1
{
    partial class frmBienvenida
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
            cmdCancelar = new Button();
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(182, 186);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 3;
            cmdCancelar.Text = "&Aceptar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBienvenido.Location = new Point(12, 9);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(127, 30);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 251);
            Controls.Add(cmdCancelar);
            Controls.Add(lblBienvenido);
            Name = "frmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += frmBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCancelar;
        private Label lblBienvenido;
    }
}