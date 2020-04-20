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
    public partial class MenúCliente : Form
    {
        public MenúCliente()
        {
            InitializeComponent();
        }

        private void MenúCliente_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            panel3_Paint(new Cliente());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
