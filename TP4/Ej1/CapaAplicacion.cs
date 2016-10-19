using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class CapaAplicacion
    {
        CapaDominio iCapaDominio;

        public CapaAplicacion(CapaDominio pCapaDominio)
        {
            iCapaDominio = pCapaDominio;
        }

        public void Ejecutar()
        {
            try
            {
                iCapaDominio.Ejecutar();
            }
            catch (ErrorPuntualException e)
            {
                CapaAplicacionException exp = new CapaAplicacionException("Error en capa de aplicacion");
                exp.Source = "ErrorPuntualException";
                exp.Data.Add("fecha", e.Data["fecha"]); 
                throw exp;
            }

        }
    }
}
