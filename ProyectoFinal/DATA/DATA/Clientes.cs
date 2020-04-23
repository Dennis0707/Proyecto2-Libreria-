using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DATA
{
    public class Clientes
    {
        public string connecion = "Data Source=LAPTOP-3SNBQ5QJ\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True";


        public void Insertar_Cliente(string Cedula, string Nombre, string Apellidos, string Telefono, string Direccion)
        {
            try
            {
                SqlConnection Coneccion = new SqlConnection(connecion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter cedula = new SqlParameter("@Cedula", SqlDbType.NVarChar);
                cedula.Value = Cedula;

                SqlParameter nombre = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                nombre.Value = Nombre;

                SqlParameter apellidos = new SqlParameter("@Apellidos", SqlDbType.NVarChar);
                apellidos.Value = Apellidos;

                SqlParameter telefono = new SqlParameter("@Telefono", SqlDbType.NVarChar);
                telefono.Value = Telefono;

                SqlParameter direccion = new SqlParameter("@Direccion", SqlDbType.NVarChar);
                direccion.Value = Direccion;


                Comando.Parameters.Add(cedula);
                Comando.Parameters.Add(nombre);
                Comando.Parameters.Add(apellidos);
                Comando.Parameters.Add(telefono);
                Comando.Parameters.Add(direccion);


                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "Insertar_Clientes";
                Coneccion.Open();
                Comando.Connection = Coneccion;
                Comando.ExecuteNonQuery();
                Coneccion.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public void Insertar_Usuario(string Usuario, string Pass, string Rol)
        {
            SqlConnection Coneccion = new SqlConnection(connecion);
            SqlCommand Comando = new SqlCommand();

            SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar);
            usuario.Value = Usuario;

            SqlParameter pass = new SqlParameter("@pass", SqlDbType.NVarChar);
            pass.Value = Pass;

            SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar);
            rol.Value = Rol;

            Comando.Parameters.Add(usuario);
            Comando.Parameters.Add(pass);
            Comando.Parameters.Add(rol);

            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "Insertar_Usuarios";
            Coneccion.Open();
            Comando.Connection = Coneccion;
            Comando.ExecuteNonQuery();
            Coneccion.Close();


        }

        public void ActualizarCliente(string nombre, string apellidos, string telefono, string direccion, string cedula)
        {
            SqlConnection Coneccion = new SqlConnection(this.connecion);
            string query = "UPDATE Clientes SET Nombre = @Nombre , Apellidos = @Apellidos, Telefono = @Telefono, Direccion = @Direccion WHERE Cedula =@Cedula)";
            Coneccion.Open();
            SqlCommand comando = new SqlCommand(query, Coneccion);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.ExecuteNonQuery();
            Coneccion.Close();

        }

        public void Eliminar_Cliente(string cedula)
        {
            SqlConnection Coneccion = new SqlConnection(this.connecion);
            string query = "DELETE from Clientes where Cedula = @Cedula";

            Coneccion.Open();
            SqlCommand comando = new SqlCommand(query, Coneccion);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.ExecuteNonQuery();
            Coneccion.Close();

        }

        public DataSet ConsultarCliente(string cedula)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlConnection conn = new SqlConnection(connecion);


                SqlDataAdapter consulta = new SqlDataAdapter("select * from Clientes where Cedula= '" + cedula + "'", conn);

                consulta.Fill(ds);

                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return ds;
        }

        public string[] validarIngreso(string Usuario, string Pass)
        {
            string[] usuario = new string[3];

            try
            {
                SqlConnection Conection = new SqlConnection(connecion);
                SqlCommand Comando = new SqlCommand("select * from Usuarios where usuario = '" + Usuario + "' and pass ='" + Pass + "'", Conection);


                Conection.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario[1] = reader["Usuario"].ToString();
                    usuario[0] = reader["pass"].ToString();
                    usuario[2] = reader["rol"].ToString();
                }

                Conection.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return usuario;
        }

        public bool validarRol( string rol)
        {


            if (rol.Equals("Admin"))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
      /*  string cmplt;

        public string Autocompletar()
    {
           
        string query = "select Codigo_Producto from Producto";
        SqlConnection Coneccion = new SqlConnection(this.connecion);
        SqlCommand comando = new SqlCommand(query, Coneccion);
        SqlDataReader dr;
        Coneccion.Open();
        dr = comando.ExecuteReader();

        while(dr.Read())
        {
            cmplt=(dr["Codigo_Producto"].ToString());
        }
        dr.Close();
        Coneccion.Close();
        return cmplt;
    }*/

     
    }
}
