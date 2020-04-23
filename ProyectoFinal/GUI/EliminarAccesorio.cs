using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EliminarAccesorio : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public EliminarAccesorio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoAccesorios eas = new MantenimientoAccesorios();
            eas.Show();
            this.Visible = false;
        }

        private void dgvAccesorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BUSINESS.NegAccesorio negAccesorio = new BUSINESS.NegAccesorio();
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar el accesorio");
            }
            else
            {
                negAccesorio.eliminar(Convert.ToInt32(txtId.Text));
                MessageBox.Show("El accesorio fue eliminado con exito");
                ActualizarTabla();
            }
            txtId.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ActualizarTabla()
        {
            DATA.Accesorio conexion = new DATA.Accesorio();
            adpt = new SqlDataAdapter("SELECT *  FROM [ProyectoFinal].[dbo].[Accesorio]", conexion.AbrirConexion());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvAccesorios.DataSource = dt;
            conexion.CerrarConexion();

        }
    }
}
