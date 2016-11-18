using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej7;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class AgendaTest
    {
        [TestMethod]
        public void Ej7AgendaAgregar()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Agregar(calendario1);

            Calendario obtenido = agenda.ObtenerPorCodigo(1);
            Calendario esperado = calendario1;

            Assert.AreEqual(obtenido, esperado);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7AgendaAgregarExistente()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Agregar(calendario1);
            agenda.Agregar(calendario1);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7AgendaEliminar()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Agregar(calendario1);
            agenda.Eliminar(calendario1);

            agenda.ObtenerPorCodigo(1);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7AgendaEliminarInexistente()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Eliminar(calendario1);

            Assert.Fail();
        }


        [TestMethod]
        public void Ej7AgendaActualizar()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));
            Calendario calendario2 = new Calendario(1, "Era Otro Calendario", new DateTime(2005, 4, 01));

            agenda.Agregar(calendario1);
            agenda.Actualizar(calendario2);

            Calendario obtenido = agenda.ObtenerPorCodigo(1);
            Calendario esperado = calendario2;

            Assert.AreEqual(obtenido, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7AgendaActualizarInexistente()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Actualizar(calendario1);

            Assert.Fail();
        }


        [TestMethod]
        public void Ej7AgendaObtenerPorCodigo()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Carreras verano", new DateTime(1998, 6, 20));

            agenda.Agregar(calendario1);

            Calendario obtenido = agenda.ObtenerPorCodigo(1);
            Calendario esperado = calendario1;

            Assert.AreEqual(obtenido, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Ej7AgendaObtenerPorCodigoInexistente()
        {
            Agenda agenda = new Agenda();

            agenda.ObtenerPorCodigo(1);

            Assert.Fail();
        }

        [TestMethod]
        public void Ej7AgendaObtenerCalendarios()
        {
            Agenda agenda = new Agenda();
            Calendario calendario1 = new Calendario(1, "Maratones", new DateTime(2005, 7, 20));
            Calendario calendario2 = new Calendario(2, "Cumpleaños de 15", new DateTime(2016, 8, 2));
            Calendario calendario3 = new Calendario(3, "Recepciones", new DateTime(2014, 6, 15));
            Calendario calendario4 = new Calendario(4, "Carreras", new DateTime(2017, 6, 6));

            agenda.Agregar(calendario1);
            agenda.Agregar(calendario2);
            agenda.Agregar(calendario3);
            agenda.Agregar(calendario4);

            IList<Calendario> obtenido = agenda.ObtenerCalendarios();
            IList<Calendario> esperado = new List<Calendario>() { calendario1, calendario2, calendario3, calendario4 };

            CollectionAssert.AreEquivalent(new List<Calendario>(obtenido), new List<Calendario>(esperado));
        }
    }
}
