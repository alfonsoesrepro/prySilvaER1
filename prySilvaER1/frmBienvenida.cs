using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaER1
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        public string sujeto;
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido " + sujeto + "!";
        }
    }
}
