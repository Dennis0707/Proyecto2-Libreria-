using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS;

namespace GUI
{
    public partial class NuevoUsuario : Form
    {
        NegClientes neg = new NegClientes();
        public NuevoUsuario()
        {
            InitializeComponent();
            neg.EnviarAutoCmplt(TextBox aut);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion iss = new InicioSesion();
            iss.Show();
            this.Visible = false;
        }
    }
}
