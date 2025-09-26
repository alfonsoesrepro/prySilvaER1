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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            cmdCancelar = new Button();
            lblBienvenido = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(187, 192);
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
            lblBienvenido.Location = new Point(12, 39);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(127, 30);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(444, 251);
            Controls.Add(pictureBox1);
            Controls.Add(cmdCancelar);
            Controls.Add(lblBienvenido);
            Name = "frmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += frmBienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCancelar;
        private Label lblBienvenido;
        private PictureBox pictureBox1;
    }
}