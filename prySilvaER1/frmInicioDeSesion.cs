namespace prySilvaER1
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        frmBienvenida bienvenida = new frmBienvenida();
        int intentos = 0;
        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContrase�a.Text == "@1a" && lstModulo.Text != "SIST")
            {
                intentos = 0;
                this.Hide();
                bienvenida.sujeto = "Administrador";
                bienvenida.ShowDialog();
                this.Show();
            }
            else if (txtUsuario.Text == "John" && txtContrase�a.Text == "*2b" && lstModulo.Text == "SIST")
            {
                intentos = 0;
                this.Hide();
                bienvenida.sujeto = "John";
                bienvenida.ShowDialog();
                this.Show();
            }
            else if (txtUsuario.Text == "Ceci" && txtContrase�a.Text == "*@3c" && (lstModulo.Text == "ADM" || lstModulo.Text == "VTA"))
            {
                intentos = 0;
                this.Hide();
                bienvenida.sujeto = "Ceci";
                bienvenida.ShowDialog();
                this.Show();
            }
            else if (txtUsuario.Text == "God" && txtContrase�a.Text == "*@#4d" && lstModulo.Text != "")
            {
                intentos = 0;
                this.Hide();
                bienvenida.sujeto = "God";
                bienvenida.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrase�a.Clear();
                lstModulo.Text = "";
                txtUsuario.Focus();

                intentos++;
                if (intentos == 2)
                {
                    this.Close();
                }
            }
        }

        private void lstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
