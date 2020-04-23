﻿using System;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario mus = new ModificarUsuario();
            mus.Show();
            this.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario eus = new EliminarUsuario();
            eus.Show();
            this.Visible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuario cus = new ConsultarUsuario();
            cus.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
