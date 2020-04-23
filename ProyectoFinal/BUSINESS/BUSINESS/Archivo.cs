using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS
{
   public class Archivo
    {
        string patch = @"C:\Users\denni\Desktop\ProyectoFinal\Proyecto2-Libreria-\ProyectoFinal\DATA\test.txt";
        public  Archivo()
    {
            // This text is added only once to the file.
            if (!File.Exists(patch))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(patch))
                {
                    sw.WriteLine("Test");
                }
            }

            // Lee y agrega texto al archivo
            using (StreamWriter sw = File.AppendText(patch))
            {
                sw.WriteLine("Exito");
                sw.WriteLine("genial");
                sw.WriteLine("si se pudo");
            }
                    

        }

       

}
    
        

}
