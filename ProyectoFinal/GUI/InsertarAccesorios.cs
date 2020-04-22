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
    public partial class InsertarAccesorios : Form
    {
        public InsertarAccesorios()
        {
            InitializeComponent();
        }

        private void InsertarAccesorios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoAccesorios ias = new MantenimientoAccesorios();
            ias.Show();
            this.Visible = false;
        }
    }
}
