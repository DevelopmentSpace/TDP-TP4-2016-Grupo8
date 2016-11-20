using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ2;

namespace Ej2_test
{
    [TestClass]
    public class MatematicaTest
    {
        [TestMethod]
        public void Ej2MatematicaDividirDividendoMultiploDivisor()
        {
            int dividendo = 28;
            int divisor = 7;

            double esperado = 4;
            double obtenido = Matematica.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Ej2MatematicaDividirDividendoNoMultiploDivisor()
        {
            int dividendo = 25;
            int divisor = 7;

            double esperado = 3.5714285714285716;
            double obtenido = Matematica.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        [ExpectedException(typeof(DivisionPorCeroException))]
        public void Ej2MatematicaDividirDividendo0()
        {
            int dividendo = 0;
            int divisor = 5;

            Matematica.Dividir(dividendo, divisor);

            Assert.Fail();
        }


    }
}
