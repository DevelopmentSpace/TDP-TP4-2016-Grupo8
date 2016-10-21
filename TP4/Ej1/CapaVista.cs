using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaVista
    {
        CapaControlador iCapaControlador;

        public CapaVista(CapaControlador pCapaControlador)
        {
            iCapaControlador = pCapaControlador;
        }

        public void Ejecutar()
        {
            try
            {
                iCapaControlador.Ejecutar();
            }
            catch (CapaAplicacionException e)
            {
                
                Console.WriteLine("Fecha:");
                Console.WriteLine(" " + ((DateTime)e.Data["fecha"]).ToString());
                Console.WriteLine();
                Console.WriteLine("Mensaje: ");
                Console.WriteLine(" " + e.Message);
                Console.WriteLine();
                Console.WriteLine("MensajeFuente: ");
                Console.WriteLine(" " + e.InnerException.Message);
                Console.WriteLine();
                Console.WriteLine("CallStack: ");
                Console.WriteLine(" " + e.StackTrace);
    
            }

        }
    }
}
