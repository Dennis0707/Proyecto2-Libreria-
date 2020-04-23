﻿using System;
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
    public partial class InsertarLibreria : Form
    {
        System.Data.SqlClient.SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public InsertarLibreria()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MantenimientoLibreria als = new MantenimientoLibreria();
            als.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            BUSINESS.NegLibreria libreria= new BUSINESS.NegLibreria();

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtLoc.Text) || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                libreria.insertar(Convert.ToInt32(txtId.Text), txtNom.Text, txtLoc.Text, txtTel.Text, txtMail.Text);
                ActualizarTabla();
            }
            txtId.Text = "";
            txtNom.Text = "";
            txtLoc.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";

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
