using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ6;
using System.Collections.Generic;

namespace EJ6_Prueba
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Ej6RepositorioAgregar()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            IRepositorioUsuarios repo1 = new Repositorio();
            IRepositorioUsuarios repo2 = new Repositorio();

            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            us2.Codigo = "124";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            repo1.Agregar(us1);
            repo1.Agregar(us2);

            repo2.Agregar(us2);
            repo2.Agregar(us1);

            Assert.IsTrue(repo1.ObtenerPorCodigo("124").Equals(us2));

        }

        [TestMethod]
        public void Ej6RepositorioActualizar()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();

            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            us2.Codigo = "123";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            repo.Agregar(us1);

            us1.NombreCompleto = "Chamaco Chamaquin";

            repo.Actualizar(us1);

            Assert.AreEqual(repo.ObtenerPorCodigo("123").NombreCompleto, us2.NombreCompleto);

        }

        [TestMethod]
        public void Ej6RepositorioObtenerPorCodigo()
        {
            Usuario us1 = new Usuario();

            IRepositorioUsuarios repo = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            repo.Agregar(us1);

            Assert.IsTrue(us1.Equals(repo.ObtenerPorCodigo("123")));


        }

        [TestMethod]
        public void Ej6RepositorioObtenerTodos()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();

            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            us2.Codigo = "124";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            repo.Agregar(us1);
            repo.Agregar(us2);

            List<Usuario> esperado = new List<Usuario> {us1,us2};
            List<Usuario> obtenido = new List<Usuario>(repo.ObtenerTodos());

            CollectionAssert.AreEquivalent(esperado,obtenido);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception),AllowDerivedTypes =true)]
        public void Ej6RepositorioEliminar()
        {
            Usuario us1 = new Usuario();
            IRepositorioUsuarios repo1 = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            repo1.Agregar(us1);
            repo1.Eliminar("124");

            repo1.ObtenerPorCodigo("124");

            Assert.Fail();
        }

        [TestMethod]
        public void Ej6RepositorioOrdenarPor()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            Usuario us3 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Baca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            us2.Codigo = "124";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            us3.Codigo = "125";
            us3.CorreoElectronico = "Meih@Seymeid.com";
            us3.NombreCompleto = "Bicicleta Anacleta";

            repo.Agregar(us2);
            repo.Agregar(us1);
            repo.Agregar(us3);

            List<Usuario> obtenido = new List<Usuario>(repo.ObtenerOrdenadosPor(new OrdenarPorNombreDesc()));
            List<Usuario> esperado = new List<Usuario> { us3, us2, us1 };
            CollectionAssert.AreEqual(esperado, obtenido);

            obtenido = new List<Usuario>(repo.ObtenerOrdenadosPor(new OrdenarPorNombreAsc()));
            esperado = new List<Usuario> { us1, us2, us3 };
            CollectionAssert.AreEqual(esperado, obtenido);

            obtenido = new List<Usuario>(repo.ObtenerOrdenadosPor(new OrdenarPorCorreoElectronicoDesc()));
            esperado = new List<Usuario> { us1, us3, us2 };
            CollectionAssert.AreEqual(esperado, obtenido);


        }

        [TestMethod]
        public void Ej6RepositorioObtenerPorAprox()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            Usuario us3 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Baca@hotmail.com";
            us1.NombreCompleto = "Tiriyama Akatalamoto";

            us2.Codigo = "124";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            us3.Codigo = "125";
            us3.CorreoElectronico = "Meih@Seymeid.com";
            us3.NombreCompleto = "Ticicleta Anacleta";

            repo.Agregar(us2);
            repo.Agregar(us1);
            repo.Agregar(us3);

            List<Usuario> obtenido = new List<Usuario>(repo.ObtenerPorAproximacion("Ti"));

            List<Usuario> esperado = new List<Usuario>() { us1,us3 };

            CollectionAssert.AreEquivalent(esperado,obtenido);

        }

        [TestMethod]
        public void Ej6RepositorioObtenerPorAproxDefensiveCopy()
        {
            Usuario us1 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();

            us1.Codigo = "123";
            us1.CorreoElectronico = "Baca@hotmail.com";
            us1.NombreCompleto = "Tiriyama Akatalamoto";

            repo.Agregar(us1);

            IEnumerator<Usuario> enumerator= repo.ObtenerPorAproximacion("Ti").GetEnumerator();
            enumerator.MoveNext();
            Usuario obtenido = enumerator.Current;

            us1.Codigo = "123";
            us1.CorreoElectronico = "OTROMAIL@hotmail.com";
            us1.NombreCompleto = "OTRONOMBRE";

            Assert.AreNotSame(us1, obtenido);
        }
    }
}
