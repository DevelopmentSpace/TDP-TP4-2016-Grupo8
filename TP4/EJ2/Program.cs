using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo, divisor;
            Calculadora calc = new Calculadora();

            Console.Write("Ingrese el dividendo: ");
            int.TryParse(Console.ReadLine(), out dividendo);

            Console.Write("Ingrese el divisor:");
            int.TryParse(Console.ReadLine(), out divisor);

            double res=double.MaxValue;
            try
            {
                res = calc.Dividir(dividendo, divisor);
            }
            catch (DivisionPorCeroException e)
            {
                Console.WriteLine("Error: El dividendo ingresado no es valido. Ingrese un numero mayor a 0");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Resultado: "+ res);
            Console.ReadKey();


        }
    }
}
