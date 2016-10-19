using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Matematica
    {

        public static double Dividir(int pDividendo,int pDivisor)
        {
            if (pDividendo == 0)
            {
                throw new DivisionPorCeroException("Dividendo igual a 0");
            }
            return (double)pDividendo / pDivisor;
        }
    }
}
