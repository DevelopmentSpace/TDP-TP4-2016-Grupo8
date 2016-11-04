using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    public class Repositorio : IRepositorioUsuarios
    {
        IList<Usuario> iUsuarios = new List<Usuario> { };

        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            iUsuarios.Remove(pUsuario);
            iUsuarios.Add(pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            iUsuarios.Remove(unUsuario);
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iUsuarios;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            return iUsuarios.ElementAt(iUsuarios.IndexOf(unUsuario));
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            return iUsuarios.OrderBy( unUsuario => unUsuario ,pComparador).ToList();
        }

        public IList<Usuario> ObtenerPorAproximacion(string pNombreCompleto)
        {
            List<Usuario> listaAprox = new List<Usuario> { };

            IEnumerator<Usuario> enumerador = iUsuarios.GetEnumerator();
            
            while (enumerador.MoveNext() )
            {
                if (enumerador.Current.NombreCompleto.StartsWith(pNombreCompleto))
                {
                    listaAprox.Add(enumerador.Current.Copy());
                }
            }

            return listaAprox;

        }

    }



    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return -String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    public class OrdenarPorCorreoElectronicoDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }







}
