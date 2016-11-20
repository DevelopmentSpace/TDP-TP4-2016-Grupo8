using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    /// <summary>
    /// Implementacion de IRepositorioUsuarios usando ListaDeUsuario
    /// </summary>
    public class Repositorio : IRepositorioUsuarios
    {
        //Lista para almacenar los usuarios
        IList<Usuario> iUsuarios = new List<Usuario> { };

        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pUsuario">usuario</param>
        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario);
        }

        /// <summary>
        /// Actualiza un usuario del repositorio segun su codigo
        /// </summary>
        /// <param name="pUsuario">usuario actualizado</param>
        public void Actualizar(Usuario pUsuario)
        {
            iUsuarios.Remove(pUsuario);
            iUsuarios.Add(pUsuario);
        }

        /// <summary>
        /// Elimina un usuario del repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        public void Eliminar(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            iUsuarios.Remove(unUsuario);
        }

        /// <summary>
        /// Obtiene todos los usuarios del repositorio
        /// </summary>
        /// <returns>Listado de usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iUsuarios;
        }

        /// <summary>
        /// Obtiene un usuario usando el codigo
        /// </summary>
        /// <param name="pCodigo">codigo</param>
        /// <returns>usuario con codigo igual al parametro dado</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario unUsuario = new Usuario();
            unUsuario.Codigo = pCodigo;
            return iUsuarios.ElementAt(iUsuarios.IndexOf(unUsuario));
        }

        /// <summary>
        /// Obtiene todos los usuarios del repositorio ordenados segun un comparador
        /// </summary>
        /// <param name="pComparador">comparador de usuarios a usar</param>
        /// <returns>Listado de usuarios ordenado</returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            return iUsuarios.OrderBy( unUsuario => unUsuario ,pComparador).ToList();
        }

        /// <summary>
        /// Obtiene una lista de Usuarios cuyo nombre contenga el parametro dado
        /// </summary>
        /// <param name="pNombreCompleto">parte del nombre</param>
        /// <returns>Listado de usuarios</returns>
        public IList<Usuario> ObtenerPorAproximacion(string pNombreCompleto)
        {
            List<Usuario> listaAprox = new List<Usuario> { };

            IEnumerator<Usuario> enumerador = iUsuarios.GetEnumerator();
            
            while (enumerador.MoveNext() )
            {
                if (enumerador.Current.NombreCompleto.StartsWith(pNombreCompleto))
                {
                    listaAprox.Add((Usuario)enumerador.Current.Clone()); //Agrega una copia del original
                }
            }

            return listaAprox;

        }

    }




    /// <summary>
    /// Comparador de usuarios por nombre descendente
    /// </summary>
    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    /// <summary>
    /// Comparador de usuarios por nombre ascendente
    /// </summary>
    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return -String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    /// <summary>
    /// Comparador de usuarios por correo electronico descendente
    /// </summary>
    public class OrdenarPorCorreoElectronicoDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }







}
