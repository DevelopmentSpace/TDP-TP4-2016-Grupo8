using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
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

        public Usuario Copy()
        {
           Usuario us = new Usuario();

           us.Codigo = this.Codigo;
           us.CorreoElectronico = this.CorreoElectronico;
           us.NombreCompleto = this.NombreCompleto;

            return us;
        }


        public int CompareTo(Usuario other)
        {
            return String.Compare(this.iCodigo, other.Codigo);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Usuario)) return false;

            if (ReferenceEquals(null, obj)) return false;

            if (string.Equals(((Usuario)obj).Codigo,this.Codigo)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            int code;
            int.TryParse(this.Codigo, out code);
            return code;
        }

    }
}
