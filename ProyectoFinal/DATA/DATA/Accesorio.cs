using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
   public class Accesorio
    {
        private string conexion;
        private bool funciono;
        private bool funcionoRol;
        SqlCommand comando = new SqlCommand();
        private SqlConnection Conex = new SqlConnection("Server=LAPTOP-3SNBQ5QJ\\SQLEXPRESS;DataBase= ProyectoFinal;Integrated Security=true");
        public Accesorio()
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
        public void InsertarAccesorio(int Id_Accesorio, string Nombre, string Descripcion, int Id_Libreria, int Cantidad, int Precio)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_InsertarAccesorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Accesorio", Id_Accesorio);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CerrarConexion();
        }


        public void ActualizarAccesorio(int Id_Accesorio, string Nombre, string Descripcion, int Id_Libreria, int Cantidad, int Precio)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_ActualizarAccesorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Accesorio", Id_Accesorio);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Id_Libreria", Id_Libreria);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); CerrarConexion();
        }

        public void EliminarAccesorio(int Id_Accesorio)
        {
            comando.Connection = AbrirConexion();
            comando.CommandText = "SP_EliminarAccesorio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Accesorio", Id_Accesorio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
    }
}
