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
    public partial class EliminarLibro : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public EliminarLibro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoLibros els = new MantenimientoLibros();
            els.Show();
            this.Visible = false;
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            Application.Exit();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            BUSINESS.NegLibro negLibro = new BUSINESS.NegLibro();
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un libro a eliminar");
            }
            else
            {
                negLibro.eliminar(Convert.ToInt32(txtId.Text));
                MessageBox.Show("El libro fue eliminado exitosamente");
                ActualizarTabla();
            }
            txtId.Text = "";
        }
        private void ActualizarTabla()
        {
            DATA.Libro conexion = new DATA.Libro();
            adpt = new SqlDataAdapter("SELECT * FROM [ProyectoFinal].[dbo].[Libro]", conexion.AbrirConexion());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvLibro.DataSource = dt;
            conexion.CerrarConexion();

        }
    }
}
