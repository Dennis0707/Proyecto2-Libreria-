﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA;


namespace BUSINESS
{
    public class NegClientes
    {
        Clientes clint = new Clientes();
       
        public void EnviarInfo(string Cedula, string Nombre, string Apellidos, string Telefono, string Direccion, string Usuario, string Pass, string Rol)
        {
            clint.Insertar_Cliente(Cedula, Nombre, Apellidos, Telefono, Direccion);
            clint.Insertar_Usuario(Usuario, Pass, Rol);
        }
        public DataSet datagrip(string Cedula)
        {
            DataSet datagrp;

            datagrp = clint.ConsultarCliente(Cedula);

            return datagrp;
        }
    }
}
