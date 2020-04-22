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
    public partial class MantenimientoAccesorios : Form
    {
        public MantenimientoAccesorios()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarAccesorios ias = new InsertarAccesorios();
            ias.Show();
            this.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarAccesorio mas = new ModificarAccesorio();
            mas.Show();
            this.Visible = false;
        }
    }
}
