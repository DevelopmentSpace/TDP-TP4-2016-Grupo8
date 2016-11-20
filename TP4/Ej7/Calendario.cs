using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    /// <summary>
    /// Clase que representa un calendario de eventos
    /// </summary>
    public class Calendario
    {
        //Codigo identificador del calendario
        private int iCodigo;
        private string iTitulo;
        private DateTime iFechaCreacion;
        private IList<Evento> iEventos;

        /// <summary>
        /// Constructor del calendario
        /// </summary>
        /// <param name="pCodigo">Codigo identificador</param>
        /// <param name="pTitulo">Titulo</param>
        /// <param name="pFechaCreacion">Fecha de creacion</param>
        /// <exception cref="ArgumentException">Titulo vacio</exception>
        public Calendario(int pCodigo, string pTitulo, DateTime pFechaCreacion)
        {
            if (pTitulo.Equals(""))
                throw new ArgumentException("no puede ser vacio","pTitulo");

            iCodigo = pCodigo;
            iTitulo = pTitulo;
            iFechaCreacion = pFechaCreacion;
            iEventos = new List<Evento> { };
        }

        /// <summary>
        /// Codigo identificador
        /// </summary>
        public int Codigo
        {
            get { return iCodigo; }
        }

        /// <summary>
        /// Titulo del calendario
        /// </summary>
        public string Titulo
        {
            get { return iTitulo; }
        }

        /// <summary>
        /// Fecha de creacion del calendario
        /// </summary>
        public DateTime FechaCreacion
        {
            get { return iFechaCreacion; }
        }

        /// <summary>
        /// Agrega un evento
        /// </summary>
        /// <param name="pEvento">evento</param>
        /// <exception cref="InvalidOperationException">evento ya existente</exception>
        public void Agregar(Evento pEvento)
        {
            if (iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento ya existe");
            iEventos.Add(pEvento);
        }

        /// <summary>
        /// Elimina un evento
        /// </summary>
        /// <param name="pEvento">evento</param>
        /// <exception cref="InvalidOperationException">evento no existe</exception>
        public void Eliminar(Evento pEvento)
        {
            if (!iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento no existe");
            iEventos.Remove(pEvento);
        }

        /// <summary>
        /// Actualiza un evento
        /// </summary>
        /// <param name="pEvento">evento</param>
        /// <exception cref="InvalidOperationException">evento no existe</exception>
        public void Actualizar(Evento pEvento)
        {
            if (!iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento no existe");
            iEventos.Remove(pEvento);
            iEventos.Add(pEvento);
        }

        /// <summary>
        /// Obtiene todos los eventos
        /// </summary>
        /// <returns>Lista de eventos</returns>
        public IList<Evento> ObtenerEventos()
        {
            return iEventos;
        }

        /// <summary>
        /// Obtiene un evento por su codigo
        /// </summary>
        /// <param name="pCodigo">codigo</param>
        /// <returns>Evento con codigo igual al dado</returns>
        /// <exception cref="InvalidOperationException">evento no existe</exception>
        public Evento ObtenerPorCodigo(int pCodigo)
        {
            Evento aux = new Evento(pCodigo, "a", new DateTime(), new TimeSpan(), FrecuenciaEvento.unico);

            if (iEventos.Contains(aux))
                return iEventos.ElementAt(iEventos.IndexOf(aux));
            else
                throw new InvalidOperationException("El evento no existe");
        }

        /// <summary>
        /// Obtiene los eventos cuyo inicio se encuentra entre las fechas dadas
        /// </summary>
        /// <param name="pFechaComienzo">Fecha comienzo del intervalo</param>
        /// <param name="pFechaFin">Fecha de fin del intervalo</param>
        /// <returns>Lista de eventos</returns>
        /// <exception cref="ArgumentException">FechaFin menor FechaComienzo</exception>
        public IList<Evento> ObtenerEntreFechas(DateTime pFechaComienzo, DateTime pFechaFin)
        {
            if (pFechaComienzo > pFechaFin)
            {
                throw new ArgumentException("FechaComienzo debe ser menor que FechaFin");
            }

            List<Evento> listaCriterio = new List<Evento> { };

            IEnumerator<Evento> enumerador = iEventos.GetEnumerator();

            while (enumerador.MoveNext())
            {

                if (enumerador.Current.SeRealiza(pFechaComienzo,pFechaFin))
                {
                    listaCriterio.Add(enumerador.Current);
                }
            }

            return listaCriterio;
        }

        /// <summary>
        /// Verifica la igualdad del calendario con uno dado en base a sus codigos
        /// </summary>
        /// <param name="obj">Calendario con el cual comparar</param>
        /// <returns>Verdadero si coinciden los codigos, falso en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Calendario)) return false;

            if (ReferenceEquals(null, obj)) return false;

            if (((Calendario)obj).iCodigo == this.iCodigo) return true;

            return false;
        }

        /// <summary>
        /// Obtiene el hash del calendario en base a su codigo
        /// </summary>
        /// <returns>Codigo hash</returns>
        public override int GetHashCode()
        {
            return this.iCodigo;
        }

    }
}
