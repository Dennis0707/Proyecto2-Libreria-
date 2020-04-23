using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS
{
  public  class NegLibreria
    {
        Libreria libreria = new Libreria();


        public void insertar(int Id_Libreria, string Nombre, string Localizacion, string Telefono, string Mail)
        {
            libreria.InsertarLibreria(Id_Libreria, Nombre, Localizacion, Telefono, Mail);
        }
        public void actualizar(int Id_Libreria, string Nombre, string Localizacion, string Telefono, string Mail)
        {
            libreria.ActualizarLibreria(Id_Libreria, Nombre, Localizacion, Telefono, Mail);
        }
        public void eliminar(int Id_Libreria, string Nombre, string Localizacion, string Telefono, string Mail)
        {
            libreria.EliminarLibreria(Id_Libreria);
        }
    }
}
