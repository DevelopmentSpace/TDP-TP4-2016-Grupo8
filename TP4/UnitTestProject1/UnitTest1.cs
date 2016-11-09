using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarEvento()
        {
            Calendario calendario = new Calendario("Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento("Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Agregar(evento1);

            Evento obtenido = calendario.ObtenerEventos()[0];
            Evento esperado = evento1;

            Assert.AreEqual(obtenido, esperado);
        }

    }
}
