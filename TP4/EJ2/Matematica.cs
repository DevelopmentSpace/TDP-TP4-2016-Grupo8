using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class Matematica
    {
        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="pDividendo">Dividendo</param>
        /// <param name="pDivisor">Divisor</param>
        /// <returns>Resultado de la division dividendo / divisor</returns>
        public static double Dividir(int pDividendo,int pDivisor)
        {
            if (pDividendo == 0)
            {
                throw new DivisionPorCeroException("Dividendo no puede ser 0");
            }
            return (double)pDividendo / pDivisor;
        }
    }
}
