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
    public partial class ModificarAccesorio : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public ModificarAccesorio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoAccesorios ias = new MantenimientoAccesorios();
            ias.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BUSINESS.NegAccesorio negAccesorio = new BUSINESS.NegAccesorio();
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtDescrip.Text) || string.IsNullOrEmpty(cbLibreria.Text) || string.IsNullOrEmpty(cbCantidad.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                negAccesorio.actualizar(Convert.ToInt32(txtId.Text), txtNom.Text, txtDescrip.Text, Convert.ToInt32(cbLibreria.SelectedItem.ToString()), Convert.ToInt32(cbCantidad.Value), Convert.ToInt32(txtPrecio.Text));
                ActualizarTabla();
            }
            txtId.Text = "";
            txtNom.Text = "";
            txtDescrip.Text = "";
            cbLibreria.Text = "";
            cbCantidad.Text = "";
            txtPrecio.Text = "";
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
