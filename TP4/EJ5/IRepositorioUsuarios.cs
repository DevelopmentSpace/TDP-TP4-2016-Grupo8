using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    public interface IRepositorioUsuarios
    {
        /// <summary>
        /// Agrega un usuario al repositorio
        /// </summary>
        /// <param name="pUsuario">usuario</param>
        void Agregar(Usuario pUsuario);

        /// <summary>
        /// Actualiza un usuario del repositorio segun su codigo
        /// </summary>
        /// <param name="pUsuario">usuario actualizado</param>
        void Actualizar(Usuario pUsuario);

        /// <summary>
        /// Elimina un usuario del repositorio
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario</param>
        void Eliminar(string pCodigo);

        /// <summary>
        /// Obtiene todos los usuarios del repositorio
        /// </summary>
        /// <returns>Listado de usuarios</returns>
        IList<Usuario> ObtenerTodos();

        /// <summary>
        /// Obtiene un usuario usando el codigo
        /// </summary>
        /// <param name="pCodigo">codigo</param>
        /// <returns>usuario con codigo igual al parametro dado</returns>
        Usuario ObtenerPorCodigo(string pCodigo);

        /// <summary>
        /// Obtiene todos los usuarios del repositorio ordenados segun un comparador
        /// </summary>
        /// <param name="pComparador">comparador de usuarios a usar</param>
        /// <returns>Listado de usuarios ordenado</returns>
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
    }
}
