using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Calculadora
    {

        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="pDividendo">Dividendo</param>
        /// <param name="pDivisor">Divisor</param>
        /// <returns>Resultado de la division dividendo / divisor</returns>
        public double Dividir(int pDividendo,int pDivisor)
        {
            return Matematica.Dividir(pDividendo, pDivisor); 
        }

    }
}
