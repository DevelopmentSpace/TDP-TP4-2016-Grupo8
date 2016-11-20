using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo arch=null;

            Console.WriteLine("Ingrese la ruta al archivo: ");

            string ruta = Console.ReadLine();
            try
            {
                arch = new Archivo(ruta);
            }
            catch (ArgumentNullException) //Ruta vacia
            {
                Console.WriteLine("Debe ingresar una ruta.");
                Console.ReadKey();
                return;
            }
            catch (ArgumentException) //Ruta no valida
            {
                Console.WriteLine("La ruta ingresada no es valida.");
                Console.ReadKey();
                return;
            }
            catch (FileNotFoundException) //Archivo Inexistente
            {
                Console.WriteLine("El archivo no existe.");
                Console.ReadKey();
                return;
            }
            catch(Exception)
            {
                Console.Write("Se produjo un error desconocido.");
                Console.ReadKey();
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Presione una tecla para mostrar el contenido del archivo");
            Console.ReadKey();
            Console.WriteLine();

            try
            {
                Console.WriteLine(arch.LeerArchivo());
            }
            catch
            {
                Console.Write("Se produjo un error al leer el archivo");
                Console.ReadKey();
                return;
            }          
            Console.ReadKey();


        }
    }
}
