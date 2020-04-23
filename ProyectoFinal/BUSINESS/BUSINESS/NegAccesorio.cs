using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS
{
   public class NegAccesorio
    {
        Accesorio accesorio = new Accesorio();


        public void insertar(int Id_Accesorio, string Nombre, string Descripcion, int Id_Libreria, int Cantidad, int Precio)
        {
            accesorio.InsertarAccesorio(Id_Accesorio, Nombre, Descripcion, Id_Libreria, Cantidad, Precio);
        }
        public void actualizar(int Id_Accesorio, string Nombre, string Descripcion, int Id_Libreria, int Cantidad, int Precio)
        {
            accesorio.ActualizarAccesorio(Id_Accesorio, Nombre, Descripcion, Id_Libreria, Cantidad, Precio);
        }
        public void eliminar(int Id_Accesorio)
        {
            accesorio.EliminarAccesorio(Id_Accesorio);
        }
    }
}

