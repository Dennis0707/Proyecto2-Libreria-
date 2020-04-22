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
    public partial class MantenimientoLibros : Form
    {
        public MantenimientoLibros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertarLibro ils = new InsertarLibro();
            ils.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarLibro mols = new ModificarLibro();
            mols.Show();
            this.Visible = false;
        }
    }
}
