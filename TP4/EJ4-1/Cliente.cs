using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{

    /// <summary>
    /// Modela un cliente en el sistema
    /// </summary>
    class Cliente
    {
        //iNroDocumento es el numero de documento. iNombre es el nombre del cliente. iTipoDocumento indica el tipo de documento que es (enumerado).
        private String iNroDocumento, iNombre;
        private TipoDocumento iTipoDocumento;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTipoDocumento">Tipo de documento que es</param>
        /// <param name="pNroDocumento">Numero de documento del cliente</param>
        /// <param name="pNombre">Nombre del cliente</param>
        public Cliente(TipoDocumento pTipoDocumento, String pNroDocumento, String pNombre)
        {
            iNroDocumento = pNroDocumento;
            iNombre = pNombre;
            iTipoDocumento = pTipoDocumento;
        }

        /// <summary>
        /// Devuelve el tipo de documento. 
        /// </summary>
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }

        /// <summary>
        /// Devuelve el numero de documento.
        /// </summary>
        public String NroDocumento
        {
            get { return this.iNroDocumento; }
        }
        
        /// <summary>
        /// Devuelve el nombre del cliente.
        /// </summary>
        public String Nombre
        {
            get { return this.iNombre; }
        }

    }
}
