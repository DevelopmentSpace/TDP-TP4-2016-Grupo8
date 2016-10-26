using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public class Usuario:IComparable<Usuario>
    {
        private string iCodigo, iNombreCompleto,iCorreoElectronico;

        public string Codigo {  get { return iCodigo; }
                                set { iCodigo = value; }
        }

        public string NombreCompleto { get { return iNombreCompleto; }
                                        set { iNombreCompleto = value; }
        }

        public string CorreoElectronico
        {
            get { return iCorreoElectronico; }
            set { iCorreoElectronico = value; }
        }

        public int CompareTo(Usuario other)
        {
            return String.Compare(this.iCodigo, other.Codigo);
        }
    }
}
