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
    public partial class InicioSesion : Form
    {
        NegClientes negClt = new NegClientes();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario iss = new NuevoUsuario();
            iss.Show();
            this.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] usuario = new string[3];
            string user, rol;
            bool est;

            usuario = negClt.EnviarInfoLogin(txtUsuario.Text, txtPass.Text);
            user = usuario[1].ToString();
            rol = usuario[2].ToString();
            est = negClt.EnviarInfoValidarRol(rol);
            if(est)
            {
                MenuAdmin menad = new MenuAdmin();
                menad.Show();
                this.Visible = false;
            }
            else 
            {
                MenuCliente mencl = new MenuCliente();
                mencl.Show();
                this.Hide();
            }


        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
