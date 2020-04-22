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
    public partial class InsertarLibro : Form
    {
        public InsertarLibro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoLibros alis = new MantenimientoLibros();
            alis.Show();
            this.Visible = false;
        }

        private void txtConstraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
