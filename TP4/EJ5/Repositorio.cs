using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    /// <summary>
    /// Implementacion de IRepositorioUsuarios usando SortedDictionary
    /// </summary>
    public class Repositorio : IRepositorioUsuarios
    {
        //Diccionario usado para almacenar usuarios cuya clave son los codigos
        IDictionary<string, Usuario> iUsuarios = new SortedDictionary<string, Usuario> { };

        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pUsuario">usuario</param>
        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario.Codigo, pUsuario);
        }

        /// <summary>
        /// Actualiza un usuario del repositorio segun su codigo
        /// </summary>
        /// <param name="pUsuario">usuario actualizado</param>
        public void Actualizar(Usuario pUsuario)
        {
            iUsuarios[pUsuario.Codigo] = pUsuario;
        }

        /// <summary>
        /// Elimina un usuario del repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        public void Eliminar(string pCodigo)
        {
            iUsuarios.Remove(pCodigo);
        }

        /// <summary>
        /// Obtiene todos los usuarios del repositorio
        /// </summary>
        /// <returns>Listado de usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iUsuarios.Values.ToList();
        }

        /// <summary>
        /// Obtiene un usuario usando el codigo
        /// </summary>
        /// <param name="pCodigo">codigo</param>
        /// <returns>usuario con codigo igual al parametro dado</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return iUsuarios[pCodigo];
        }

        /// <summary>
        /// Obtiene todos los usuarios del repositorio ordenados segun un comparador
        /// </summary>
        /// <param name="pComparador">comparador de usuarios a usar</param>
        /// <returns>Listado de usuarios ordenado</returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            //obtiene todos los usuarios
            List<Usuario> lista = iUsuarios.Values.ToList();
            lista.Sort(pComparador);
            return lista;
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
