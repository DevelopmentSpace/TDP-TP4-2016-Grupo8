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
        public void Agregar()
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
        public void Actualizar()
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
        public void ObtenerPorCodigo()
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
        public void ObtenerTodos()
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

            IList<Usuario> alumnos = new List<Usuario> { };

            alumnos.Add(us1);
            alumnos.Add(us2);

            CollectionAssert.Equals(repo.ObtenerTodos(), alumnos);


        }

        [TestMethod]
        public void Eliminar()
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
            repo1.Eliminar("124");

            repo2.Agregar(us1);

            //Repo 1 obtenido, Repo 2 esperado.

            CollectionAssert.Equals(repo1.ObtenerTodos(),repo2.ObtenerTodos());


        }

        [TestMethod]
        public void OrdenarPor()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            Usuario us3 = new Usuario();
            IRepositorioUsuarios repo = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
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

            IList<Usuario> obtenido = repo.ObtenerOrdenadosPor(new OrdenarPorNombreDesc());

            IList<Usuario> esperado = new List<Usuario> {us3,us2,us1};

            Assert.IsTrue(obtenido[0].Codigo.Equals(esperado[0].Codigo));
            Assert.IsTrue(obtenido[1].Codigo.Equals(esperado[1].Codigo));
            Assert.IsTrue(obtenido[2].Codigo.Equals(esperado[2].Codigo));


        }




    }
}
