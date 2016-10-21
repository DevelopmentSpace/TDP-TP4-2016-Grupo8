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

            string ruta = Console.ReadLine();
            try
            {
                arch = new Archivo(ruta);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Debe ingresar una ruta.");
                Console.ReadKey();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("La ruta ingresada no es valida.");
                Console.ReadKey();
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no existe.");
                Console.ReadKey();
                return;
            }
            catch(Exception)
            {
                Console.Write("Se produjo un error inesperado.");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine(arch.LeerArchivo());
            Console.ReadKey();




        }
    }
}
