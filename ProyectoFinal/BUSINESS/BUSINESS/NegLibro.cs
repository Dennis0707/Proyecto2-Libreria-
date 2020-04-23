using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS
{
  public  class NegLibro
    {
        Libro libro = new Libro();

        public void insertar(int Id_Libro, string Nombre, string Autor, int Id_Libreria, int Cantidad, int Precio)
        {
            libro.InsertarLibro(Id_Libro, Nombre, Autor, Id_Libreria, Cantidad, Precio);
        }
        public void actualizar(int Id_Libro, string Nombre, string Autor, int Id_Libreria, int Cantidad, int Precio)
        {
            libro.ActualizarLibro(Id_Libro, Nombre, Autor, Id_Libreria, Cantidad, Precio);
        }
        public void Eliminar(int Id_Libro)
        {
            libro.EliminarLibro(Id_Libro);
        }
    }
}
