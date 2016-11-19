using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            CapaPersistencia cp = new CapaPersistencia();
            CapaDominio cd = new CapaDominio(cp);
            CapaAplicacion ca = new CapaAplicacion(cd);
            CapaControlador cc = new CapaControlador(ca);
            CapaVista cv = new CapaVista(cc);

            cv.Ejecutar();
            Console.ReadKey();

        }
    }
}
