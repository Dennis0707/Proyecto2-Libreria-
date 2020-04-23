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
    public partial class InsertarLibro : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

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

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
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

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            BUSINESS.NegLibro negLibro = new BUSINESS.NegLibro();
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtAutor.Text) || string.IsNullOrEmpty(cbLibreria.Text) || string.IsNullOrEmpty(cbCantidad.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                negLibro.insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtAutor.Text, Convert.ToInt32(cbLibreria.SelectedItem.ToString()), Convert.ToInt32(cbCantidad.Value), Convert.ToInt32(txtPrecio.Text));
                ActualizarTabla();
            }
            txtId.Text = "";
            txtNombre.Text = "";
            txtAutor.Text = "";
            cbLibreria.Text = "";
            cbCantidad.Text = "";
            txtPrecio.Text = "";
        }
        private void ActualizarTabla()
        {
            DATA.Libro conexion = new DATA.Libro();
            adpt = new SqlDataAdapter("SELECT * FROM [ProyectoFinal].[dbo].[Libro]", conexion.AbrirConexion());
            dt = new DataTable();
            adpt.Fill(dt);
            dgvLibros.DataSource = dt;
            conexion.CerrarConexion();

        }

        private void InsertarLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreria._Libreria' Puede moverla o quitarla según sea necesario.
            this.libreriaTableAdapter.Fill(this.libreria._Libreria);
            // TODO: esta línea de código carga datos en la tabla 'libro._Libro' Puede moverla o quitarla según sea necesario.
            this.libroTableAdapter.Fill(this.libro._Libro);

        }
    }
}
