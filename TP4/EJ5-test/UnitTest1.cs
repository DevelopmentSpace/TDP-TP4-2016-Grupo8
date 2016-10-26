using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ5;

namespace EJ5_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Agregar()
        {
            Usuario us1 = new Usuario();
            Usuario us2 = new Usuario();
            Repositorio repo = new Repositorio();


            us1.Codigo = "123";
            us1.CorreoElectronico = "Taca@hotmail.com";
            us1.NombreCompleto = "Toriyama Akatalamoto";

            us2.Codigo = "124";
            us2.CorreoElectronico = "TacaTaca@hotmail.com";
            us2.NombreCompleto = "Chamaco Chamaquin";

            repo.Agregar(us1);
            repo.Agregar(us2);

            Assert.IsTrue(us1.Equals(repo.ObtenerPorCodigo("123")));


        }
    }
}
