using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ5;

namespace EJ5_test
{
    [TestClass]
    public class EJ5Test
    {

        [TestMethod]
        public void Ej5RepositorioAgregar()
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
        public void Ej5RepositorioActualizar()
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

            Assert.AreEqual(repo.ObtenerPorCodigo("123").NombreCompleto,us2.NombreCompleto);

        }

        [TestMethod]
        public void Ej5RepositorioObtenerPorCodigo()
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
        public void Ej5RepositorioObtenerTodos()
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

            List<Usuario> esperado = new List<Usuario> { us1, us2 };
            List<Usuario> obtenido = new List<Usuario>(repo.ObtenerTodos());

            CollectionAssert.AreEquivalent(esperado, obtenido);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
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
        public void Ej5RepositorioOrdenarPor()
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

            IList<Usuario> obtenidoDesc = repo.ObtenerOrdenadosPor(new OrdenarPorNombreDesc());

            IList<Usuario> esperadoDesc = new List<Usuario> {us3,us2,us1};

            Assert.IsTrue(obtenidoDesc[0].Equals(esperadoDesc[0]));
            Assert.IsTrue(obtenidoDesc[1].Equals(esperadoDesc[1]));
            Assert.IsTrue(obtenidoDesc[2].Equals(esperadoDesc[2]));

            IList<Usuario> obtenidoAsc = repo.ObtenerOrdenadosPor(new OrdenarPorNombreAsc());

            IList<Usuario> esperadoAsc = new List<Usuario> { us1, us2, us3 };

            Assert.IsTrue(obtenidoAsc[0].Equals(esperadoAsc[0]));
            Assert.IsTrue(obtenidoAsc[1].Equals(esperadoAsc[1]));
            Assert.IsTrue(obtenidoAsc[2].Equals(esperadoAsc[2]));

            IList<Usuario> obtenidoCorreoDesc = repo.ObtenerOrdenadosPor(new OrdenarPorCorreoElectronicoDesc());

            IList<Usuario> esperadoCorreoDesc = new List<Usuario> { us1, us3, us2 };

            Assert.IsTrue(obtenidoCorreoDesc[0].Equals(esperadoCorreoDesc[0]));
            Assert.IsTrue(obtenidoCorreoDesc[1].Equals(esperadoCorreoDesc[1]));
            Assert.IsTrue(obtenidoCorreoDesc[2].Equals(esperadoCorreoDesc[2]));

        }


    }
}
