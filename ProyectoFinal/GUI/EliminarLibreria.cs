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
    public partial class EliminarLibreria : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public EliminarLibreria()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoLibreria elbs = new MantenimientoLibreria();
            elbs.Show();
            this.Visible = false;
        }

        private void dgvLibreria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUSINESS.NegLibreria libreria = new BUSINESS.NegLibreria();

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar una libreria");
            }
            else
            {
                libreria.eliminar(Convert.ToInt32(txtId.Text));
                MessageBox.Show("La libreria fue eliminada con exito");
                ActualizarTabla();
            }
            txtId.Text = "";
        }
        private void ActualizarTabla()
        {
            DATA.Libreria conexion = new DATA.Libreria();
            adpt = new SqlDataAdapter("SELECT *  FROM [ProyectoFinal].[dbo].[Libreria]", conexion.AbrirConexion());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvLibreria.DataSource = dt;
            conexion.CerrarConexion();

        }
    }
}
