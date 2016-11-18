using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej7;

namespace UnitTestProject1
{
    [TestClass]
    public class EventoTest
    {
        [TestMethod]
        public void Ej7EventoSeRealizaUnicoComienzo()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 11, 1), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaUnicoFinal()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 11, 7), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaUnicoIntermedio()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 11, 4), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaFueAntes()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 10, 31), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaEmpiezaDespues()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 11, 12), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaSemanal()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2016, 10, 12), new TimeSpan(4, 30, 0), FrecuenciaEvento.semana);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaSemanalFueraDelIntervalo()
        {
            Evento evento = new Evento(1, "8K Colon", new DateTime(2016, 10, 7), new TimeSpan(10, 30, 0), FrecuenciaEvento.semana);

            DateTime fechaInicial = new DateTime(2016, 11, 7);
            DateTime fechaFinal = new DateTime(2016, 11, 10);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsFalse(resultado);
        }




        [TestMethod]
        public void Ej7EventoSeRealizaMensual()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2015, 08, 5), new TimeSpan(4, 30, 0), FrecuenciaEvento.mes);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Ej7EventoSeRealizaMensualFueraDelIntervalo()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(2015, 06, 21), new TimeSpan(4, 30, 0), FrecuenciaEvento.mes);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 20);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsFalse(resultado);
        }



        [TestMethod]
        public void Ej7EventoSeRealizaAnual()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(1998, 11,5), new TimeSpan(4, 30, 0), FrecuenciaEvento.anio);

            DateTime fechaInicial = new DateTime(2016, 11, 1);
            DateTime fechaFinal = new DateTime(2016, 11, 7);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsTrue(resultado);
        }

        public void Ej7EventoSeRealizaAnualFueraDelIntervalo()
        {
            Evento evento = new Evento(1, "Carrera1", new DateTime(1998, 11,1), new TimeSpan(4, 30, 0), FrecuenciaEvento.anio);

            DateTime fechaInicial = new DateTime(2016, 01, 1);
            DateTime fechaFinal = new DateTime(2016, 10, 31);

            bool resultado = evento.SeRealiza(fechaInicial, fechaFinal);

            Assert.IsFalse(resultado);
        }
    }
}
