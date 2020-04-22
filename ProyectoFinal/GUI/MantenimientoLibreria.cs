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
    public partial class MantenimientoLibreria : Form
    {
        public MantenimientoLibreria()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarLibreria alis = new InsertarLibreria();
            alis.Show();
            this.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarLibreria mls = new ModificarLibreria();
            mls.Show();
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarLibreria els = new EliminarLibreria();
            els.Show();
            this.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarLibreria cls = new ConsultarLibreria();
            cls.Show();
            this.Visible = false;
        }
    }
}
