using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    /// <summary>
    /// Clase que representa a un usuario
    /// </summary>
    public class Usuario:IComparable<Usuario>
    {
        private string iCodigo, iNombreCompleto,iCorreoElectronico;

        /// <summary>
        /// Codigo identificador unico del usuario
        /// </summary>
        public string Codigo {  get { return iCodigo; }
                                set { iCodigo = value; }
        }

        /// <summary>
        /// NombreCompleto del usuario
        /// </summary>
        public string NombreCompleto { get { return iNombreCompleto; }
                                        set { iNombreCompleto = value; }
        }

        /// <summary>
        /// Correo Electronico del usuario
        /// </summary>
        public string CorreoElectronico
        {
            get { return iCorreoElectronico; }
            set { iCorreoElectronico = value; }
        }

        /// <summary>
        /// Compara al usuario con otro en base al codigo
        /// </summary>
        /// <param name="other">Usuario con el cual comparar</param>
        /// <returns></returns>
        public int CompareTo(Usuario other)
        {
            return String.Compare(this.iCodigo, other.Codigo);
        }
    }
}
