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
    public partial class InicioSesión : Form
    {
        public InicioSesión()
        {
            InitializeComponent();

           
        }

        private void InicioSesión_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btnCancelar_Click(object sender, EventArgs e)
        {

=======
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MenuAdmin menad = new MenuAdmin();
            menad.Show();
            this.Visible = false;
>>>>>>> 12b3b68d7676a8f30ba08b9f6f338bf5c0d6cc10
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            Usuario uss = new Usuario();
            uss.Show();
            this.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
>>>>>>> 12b3b68d7676a8f30ba08b9f6f338bf5c0d6cc10

        }
    }
}
