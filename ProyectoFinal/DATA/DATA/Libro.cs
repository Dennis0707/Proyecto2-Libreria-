using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    class Libro
    {

        private string conexion;
        private bool funciono;
        private bool funcionoRol;
        SqlCommand comando = new SqlCommand();
        private SqlConnection Conex = new SqlConnection("Server=LAPTOP-3SNBQ5QJ\\SQLEXPRESS;DataBase= ProyectoFinal;Integrated Security=true");


        public Libro()
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
        public void InsertarLibro(int Id_Libro, string Nombre, string Autor, int Id_Libreria, int Cantidad, int Precio)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_InsertarAccesorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libro", Id_Libro);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Autor", Autor);
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }


        public void ActualizarLibro(int Id_Libro, string Nombre, string Autor, int Id_Libreria, int Cantidad, int Precio)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_ActualizarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libro", Id_Libro);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Autor", Autor);
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }

        public void EliminarLibro(int Id_Libro)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_EliminarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Libro", Id_Libro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
    }
}
