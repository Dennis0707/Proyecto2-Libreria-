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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
            //panel5_Paint(new MantenimientoUsuarios());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender)
        {
            if (this.panel5.Controls.Count > 0)
                this.panel5.Controls.RemoveAt(0);
            Form fact = sender as Form;
            fact.TopLevel = false;
            fact.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(fact);
            this.panel5.Tag = fact;
            fact.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            panel5_Paint(new MantenimientoLibreria());
        }

        private void btnLibros_Click_1(object sender, EventArgs e)
        {
            panel5_Paint(new MantenimientoLibros());
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            panel5_Paint(new MantenimientoAccesorios());
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            panel5_Paint(new MantenimientoUsuarios());
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InicioSesion iss = new InicioSesion();
            iss.Show();
            this.Visible = false;
        }
    }
}
