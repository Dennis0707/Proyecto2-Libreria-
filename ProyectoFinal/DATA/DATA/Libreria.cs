using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    class Libreria
    {
        private string conexion;
        private bool funciono;
        private bool funcionoRol;
        SqlCommand comando = new SqlCommand();
        private SqlConnection Conex = new SqlConnection("Server=LAPTOP-3SNBQ5QJ\\SQLEXPRESS;DataBase= ProyectoFinal;Integrated Security=true");


        public Libreria()
        {

        }

        public SqlConnection AbrirConexion()
        {
            if (Conex.State == ConnectionState.Closed)
                Conex.Open();
            return Conex;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conex.State == ConnectionState.Open)
                Conex.Close();
            return Conex;
        }
        public void InsertarLibreria(int Id_Libreria, string Nombre, string Localizacion, string Telefono, string Mail)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_InsertarLibreria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Localizacion", Localizacion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Mail", Mail);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }


        public void ActualizarLibreria(int Id_Libreria, string Nombre, string Localizacion, string Telefono, string Mail)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_ActualizarLibreria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Localizacion", Localizacion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Mail", Mail);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }

        public void EliminarLibreria(int Id_Libreria)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_EliminarLibreria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
    }
}
