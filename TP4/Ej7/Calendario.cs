using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class Calendario
    {
        private string iTitulo;
        private DateTime iFechaCreacion;
        private IList<Evento> iEventos;

        public Calendario(string pTitulo, DateTime pFechaCreacion)
        {
            iTitulo = pTitulo;
            iFechaCreacion = pFechaCreacion;
            iEventos = new List<Evento> { };
        }

        public string Titulo { get { return iTitulo; } }

        public DateTime FechaCreacion { get { return iFechaCreacion; } }



        public void Agregar(Evento pEvento)
        {
            iEventos.Add(pEvento);
        }

        public void Eliminar(Evento pEvento)
        {
            iEventos.Remove(pEvento);
        }

        public void Actualizar(Evento pEvento)
        {
            iEventos.Remove(pEvento);
            iEventos.Add(pEvento);
        }

        public IList<Evento> ObtenerEventos()
        {
            return iEventos;
        }

        public Evento ObtenerPorCodigo(int pCodigo)
        {
            Evento aux = new Evento(pCodigo, "", new DateTime(), new TimeSpan(), FrecuenciaEvento.unico);

            if (iEventos.Contains(aux))
                return iEventos.ElementAt(iEventos.IndexOf(aux));
            else
                throw new KeyNotFoundException();
        }

        public IList<Evento> ObtenerEntreFechas(DateTime pFechaComienzo, DateTime pFechaFin)
        {
            if (pFechaComienzo > pFechaFin)
            {
                throw new ArgumentOutOfRangeException("ErrorFechaComienzoMayorQueFechaFin");
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

            if (string.Equals(((Calendario)obj).iTitulo, this.iTitulo)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            int code;
            int.TryParse(this.iTitulo, out code);
            return code;
        }

    }
}
