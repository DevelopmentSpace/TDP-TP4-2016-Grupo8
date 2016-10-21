using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Archivo
    {
        string iRuta;

        public Archivo(string pRuta)
        {
            if (pRuta == "")
                throw new ArgumentNullException();
            try
            { Path.GetFullPath(pRuta);
            } catch (ArgumentException)
            {
                throw new ArgumentException();
            };
            if (!File.Exists(pRuta))
                throw new FileNotFoundException();

            iRuta = pRuta;
        }

        public string LeerArchivo()
        {
            StreamReader iSR = new StreamReader(iRuta);
            try
            {
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
