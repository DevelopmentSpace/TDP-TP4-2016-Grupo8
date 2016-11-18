using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej7;
using System.Collections.Generic;

namespace UnitTestProject1
{

    [TestClass]
    public class CalendarioTest
    {

        [TestMethod]
        public void Ej7CalendarioAgregar()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1,"Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Agregar(evento1);

            Evento obtenido = calendario.ObtenerPorCodigo(1);
            Evento esperado = evento1;

            Assert.AreEqual(obtenido, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7CalendarioAgregarExistente()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Agregar(evento1);
            calendario.Agregar(evento1);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7CalendarioEliminar()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1,"Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Agregar(evento1);
            calendario.Eliminar(evento1);

            calendario.ObtenerPorCodigo(1);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7CalendarioEliminarInexistente()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Eliminar(evento1);

            Assert.Fail();
        }


        [TestMethod]
        public void Ej7CalendarioActualizar()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1,"Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);
            Evento evento2 = new Evento(1,"Otra carrera", new DateTime(2015, 4, 1), new TimeSpan(1, 31, 2), FrecuenciaEvento.semana);

            calendario.Agregar(evento1);

            calendario.Actualizar(evento2);

            Evento obtenido = calendario.ObtenerPorCodigo(1);
            Evento esperado = evento2;

            Assert.AreEqual(obtenido,esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7CalendarioActualizarInexistente()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Actualizar(evento1);

            Assert.Fail();
        }


        [TestMethod]
        public void Ej7CalendarioObtenerPorCodigo()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "Carrera1", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            calendario.Agregar(evento1);

            Evento obtenido = calendario.ObtenerPorCodigo(1);
            Evento esperado = evento1;

            Assert.AreEqual(obtenido, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7CalendarioObtenerPorCodigoInexistente()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            calendario.ObtenerPorCodigo(1);

            Assert.Fail();
        }

        [TestMethod]
        public void Ej7CalendarioObtenerEventos()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "8K Aniversario Regatas Uruguay", new DateTime(2020, 11, 9), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);
            Evento evento2 = new Evento(2, "8K Aniversario CdelU", new DateTime(2012, 8, 1), new TimeSpan(10, 30, 0), FrecuenciaEvento.semana);
            Evento evento3 = new Evento(3, "9K Aniversario Villa Elisa", new DateTime(1997, 2, 28), new TimeSpan(1, 20, 0), FrecuenciaEvento.anio);

            calendario.Agregar(evento1);
            calendario.Agregar(evento2);
            calendario.Agregar(evento3);

            IList<Evento> obtenido = calendario.ObtenerEventos();
            IList<Evento> esperado = new List<Evento>() {evento1, evento2, evento3};

            CollectionAssert.AreEquivalent(new List<Evento>(obtenido), new List<Evento>(esperado));
        }

        [TestMethod]
        public void Ej7CalendarioObtenerEntreFechas()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Evento evento1 = new Evento(1, "8K Aniversario Regatas Uruguay", new DateTime(2016, 11, 7), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);
            Evento evento2 = new Evento(2, "8K Colegio Rep. Italia", new DateTime(2016, 11, 4), new TimeSpan(4, 30, 0), FrecuenciaEvento.unico);

            Evento evento3 = new Evento(3, "8K Aniversario CdelU", new DateTime(2016, 10, 18), new TimeSpan(10, 30, 0), FrecuenciaEvento.semana);
            Evento evento4 = new Evento(4, "8K Colon", new DateTime(2016, 10, 7), new TimeSpan(10, 30, 0), FrecuenciaEvento.semana);

            Evento evento5 = new Evento(5, "9K Aniversario Villa Elisa", new DateTime(2015, 6, 7), new TimeSpan(1, 20, 0), FrecuenciaEvento.mes);
            Evento evento6 = new Evento(6, "9K Esc Normal", new DateTime(2015, 6, 15), new TimeSpan(1, 20, 0), FrecuenciaEvento.mes);

            calendario.Agregar(evento1);
            calendario.Agregar(evento2);
            calendario.Agregar(evento3);
            calendario.Agregar(evento4);
            calendario.Agregar(evento5);
            calendario.Agregar(evento6);

            DateTime fechaInicial = new DateTime(2016, 11, 7);
            DateTime fechaFinal = new DateTime(2016, 11, 10);

            IList<Evento> obtenido = calendario.ObtenerEntreFechas(fechaInicial,fechaFinal);
            IList<Evento> esperado = new List<Evento>() {evento1, evento3, evento5};

            CollectionAssert.AreEquivalent(new List<Evento>(obtenido), new List<Evento>(esperado));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ej7CalendarioObtenerEntreFechasInvalidas()
        {
            Calendario calendario = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            DateTime fechaInicial = new DateTime(2016, 11, 7);
            DateTime fechaFinal = new DateTime(1999, 11, 10);

            calendario.ObtenerEntreFechas(fechaInicial, fechaFinal);

            Assert.Fail();
        }

    }
}
