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

        /// <summary>
        /// Crea una instancia de CapaAplicacion
        /// </summary>
        /// <param name="pCapaDominio">CapaDominio</param>
        public CapaAplicacion(CapaDominio pCapaDominio)
        {
            iCapaDominio = pCapaDominio;
        }

        /// <summary>
        /// invoca el mensaje Ejecutar() de la CapaDominio
        /// </summary>
        public void Ejecutar()
        {
            try
            {
                iCapaDominio.Ejecutar();
            }
            catch (ErrorPuntualException e)
            {
                //Lanza una nueva exepcion de tipo CapaAplicaiconExcepcion
                CapaAplicacionException exp = new CapaAplicacionException("ErrorPersistencia",e);
                
                exp.Data.Add("fecha", e.Data["fecha"]); 
                throw exp;
            }

        }
    }
}
