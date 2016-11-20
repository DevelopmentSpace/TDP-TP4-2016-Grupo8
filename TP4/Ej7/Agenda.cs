using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    /// <summary>
    /// Clase que representa una agenda para almacenar calendarios
    /// </summary>
    public class Agenda
    {
        //Lista para almacenar los calendarios
        private IList<Calendario> iCalendarios;

        /// <summary>
        /// Constructor de la agenda
        /// </summary>
        public Agenda()
        {
            iCalendarios = new List<Calendario> { };
        }

        /// <summary>
        /// Agrega un calendario
        /// </summary>
        /// <param name="pCalendario">calendario</param>
        /// <exception cref="InvalidOperationException">Calendario ya existe</exception>
        public void Agregar(Calendario pCalendario)
        {
            if (iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario ya existe");

            iCalendarios.Add(pCalendario);
        }

        /// <summary>
        /// Eliminar un Calendario
        /// </summary>
        /// <param name="pCalendario">Calendario</param>
        /// <exception cref="InvalidOperationException">Calendario no existe</exception>
        public void Eliminar(Calendario pCalendario)
        {
            if (!iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario no existe");

            iCalendarios.Remove(pCalendario);
        }

        /// <summary>
        /// Actualiza un calendario
        /// </summary>
        /// <param name="pCalendario">Calendario actualizado</param>
        /// <exception cref="InvalidOperationException">Calendario no existe</exception>
        public void Actualizar(Calendario pCalendario)
        {
            if (!iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario no existe");

            iCalendarios.Remove(pCalendario);
            iCalendarios.Add(pCalendario);
        }

        /// <summary>
        /// Obtiene un calendario por su codigo
        /// </summary>
        /// <param name="pCodigo">codigo</param>
        /// <returns>Calendario con igual codigo al dado</returns>
        /// <exception cref="InvalidOperationException">No existe calendario con el codigo dado</exception>
        public Calendario ObtenerPorCodigo(int pCodigo)
        {
            Calendario aux = new Calendario(pCodigo, "a",new DateTime());

            if (iCalendarios.Contains(aux))
                return iCalendarios.ElementAt(iCalendarios.IndexOf(aux));
            else
                throw new InvalidOperationException("El calendario no existe");
        }

        /// <summary>
        /// Obtiene todos los calendarios
        /// </summary>
        /// <returns>Lista de calendarios</returns>
        public IList<Calendario> ObtenerCalendarios()
        {
            return iCalendarios;
        }
    }
}
