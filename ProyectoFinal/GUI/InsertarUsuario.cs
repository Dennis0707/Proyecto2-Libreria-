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
    public partial class InsertarUsuario : Form
    {
        public InsertarUsuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MantenimientoUsuarios uss = new MantenimientoUsuarios();
            uss.Show();
            this.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void InsertarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
