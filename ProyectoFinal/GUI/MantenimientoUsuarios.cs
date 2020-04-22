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
    public partial class MantenimientoUsuarios : Form
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarUsuario ius = new InsertarUsuario();
            ius.Show();
            this.Visible = false;
        }
    }
}
