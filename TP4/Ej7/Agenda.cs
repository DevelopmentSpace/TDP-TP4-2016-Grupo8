using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class Agenda
    {
        private IList<Calendario> iCalendarios;

        public Agenda()
        {
            iCalendarios = new List<Calendario> { };
        }

        public void Agregar(Calendario pCalendario)
        {
            iCalendarios.Add(pCalendario);
        }

        public void Eliminar(Calendario pCalendario)
        {
            iCalendarios.Remove(pCalendario);
        }

        public void Actualizar(Calendario pCalendario)
        {
            iCalendarios.Remove(pCalendario);
            iCalendarios.Add(pCalendario);
        }

        public IList<Evento> ObtenerEventos(Calendario pCalendario)
        {
            return pCalendario.ObtenerEventos();
        }

        public IList<Calendario> ObtenerCalendarios()
        {
            return iCalendarios;
        }
    }
}
