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
            if (iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario ya existe");

            iCalendarios.Add(pCalendario);
        }

        public void Eliminar(Calendario pCalendario)
        {
            if (!iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario no existe");

            iCalendarios.Remove(pCalendario);
        }

        public void Actualizar(Calendario pCalendario)
        {
            if (!iCalendarios.Contains(pCalendario))
                throw new InvalidOperationException("El calendario no existe");

            iCalendarios.Remove(pCalendario);
            iCalendarios.Add(pCalendario);
        }

        public Calendario ObtenerPorCodigo(int pCodigo)
        {
            Calendario aux = new Calendario(pCodigo, "a",new DateTime());

            if (iCalendarios.Contains(aux))
                return iCalendarios.ElementAt(iCalendarios.IndexOf(aux));
            else
                throw new InvalidOperationException("El calendario no existe");
        }

        public IList<Calendario> ObtenerCalendarios()
        {
            return iCalendarios;
        }
    }
}
