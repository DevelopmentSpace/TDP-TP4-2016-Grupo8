using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class Calendario
    {
        private int iCodigo;
        private string iTitulo;
        private DateTime iFechaCreacion;
        private IList<Evento> iEventos;

        public Calendario(int pCodigo, string pTitulo, DateTime pFechaCreacion)
        {
            if (pTitulo.Equals(""))
                throw new ArgumentException("Titulo no puede ser vacio");

            iCodigo = pCodigo;
            iTitulo = pTitulo;
            iFechaCreacion = pFechaCreacion;
            iEventos = new List<Evento> { };
        }

        public int Codigo
        {
            get { return iCodigo; }
        }

        public string Titulo
        {
            get { return iTitulo; }
        }

        public DateTime FechaCreacion
        {
            get { return iFechaCreacion; }
        }


        public void Agregar(Evento pEvento)
        {
            if (iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento ya existe");
            iEventos.Add(pEvento);
        }

        public void Eliminar(Evento pEvento)
        {
            if (!iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento no existe");
            iEventos.Remove(pEvento);
        }

        public void Actualizar(Evento pEvento)
        {
            if (!iEventos.Contains(pEvento))
                throw new InvalidOperationException("El evento no existe");
            iEventos.Remove(pEvento);
            iEventos.Add(pEvento);
        }

        public IList<Evento> ObtenerEventos()
        {
            return iEventos;
        }

        public Evento ObtenerPorCodigo(int pCodigo)
        {
            Evento aux = new Evento(pCodigo, "a", new DateTime(), new TimeSpan(), FrecuenciaEvento.unico);

            if (iEventos.Contains(aux))
                return iEventos.ElementAt(iEventos.IndexOf(aux));
            else
                throw new InvalidOperationException("El evento no existe");
        }

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

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Calendario)) return false;

            if (ReferenceEquals(null, obj)) return false;

            if (((Calendario)obj).iCodigo == this.iCodigo) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return this.iCodigo;
        }

    }
}
