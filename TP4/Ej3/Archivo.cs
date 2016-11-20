using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// Representa un archivo y permite leer su contenido
    /// </summary>
    class Archivo
    {
        string iRuta;

        /// <summary>
        /// Crea una instancia de archivo
        /// </summary>
        /// <param name="pRuta">Ruta al archivo</param>
        public Archivo(string pRuta)
        {
            if (pRuta == "")
                throw new ArgumentNullException();

            //Comprobar la validez de la ruta. Lanza una exepcion de tipo ArgumentException si la ruta no es valida
            Path.GetFullPath(pRuta);

            //Comprueba la existencia del archivo y lanza una exepcion si no existe
            if (!File.Exists(pRuta))
                throw new FileNotFoundException();

            iRuta = pRuta;
        }


        public string LeerArchivo()
        {
            StreamReader iSR = new StreamReader(iRuta);
            try
            {
                //Lanza una exepcion si no se pudo leer el archivo
                return iSR.ReadToEnd();
            }
            finally
            {
                iSR.Close();
            }

        }

        /*
         * Alternativa a cerrar siempre el archivo
         * 
        public string LeerArchivo()
        {
            StreamReader iSR = new StreamReader(iRuta);
            try
            {
                return iSR.ReadToEnd();
            }
            catch(Exception e)
            {
                iSR.Close();
                throw e;
            }

            iSR.Close();
        }
        */
    }
}
