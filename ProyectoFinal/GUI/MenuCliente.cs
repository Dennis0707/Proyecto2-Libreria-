using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicioSesion iss = new InicioSesion();
            iss.Show();
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FacturaCliente fac = new FacturaCliente();
            fac.Show();
            this.Visible = false;
        }
    }
}
