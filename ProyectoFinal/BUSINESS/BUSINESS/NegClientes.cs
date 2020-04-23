using System;
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
            Rol = "user";
            clint.Insertar_Cliente(Cedula, Nombre, Apellidos, Telefono, Direccion);
            clint.Insertar_Usuario(Usuario, Pass, Rol);
        }
        public DataSet datagrip(string Cedula)
        {
            DataSet datagrp;

            datagrp = clint.ConsultarCliente(Cedula);

            return datagrp;
        }

        public bool EnviarInfoValidarRol( string rol)
        {
            bool estado;
            estado = clint.validarRol(rol);
            return estado;
        }

        public string[] EnviarInfoLogin(string usua, string pass)
        {
            string[] usuario = new string[3];

           usuario= clint.validarIngreso(usua, pass);

            return usuario;
        }

        public void modificar (string Cedula, string Nombre, string Apellidos, string Telefono, string Direccion)
        {
            clint.ActualizarCliente(  Nombre,  Apellidos,  Telefono,  Direccion, Cedula);
        }

        public void eliminar(string Cedula)
        {
            clint.Eliminar_Cliente(Cedula);
        }
        /*public string EnviarAutoCmplt()
        {
            string ced;
            ced=clint.Autocompletar();

            return ced;
        }*/
    }
}
