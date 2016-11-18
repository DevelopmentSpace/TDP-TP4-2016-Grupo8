using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class Evento
    {
        private int iCodigo;
        private string iTitulo;
        private DateTime iFechaComienzo;
        private TimeSpan iDuracion;
        private FrecuenciaEvento iFrecuencia;

        public Evento(int pCodigo,string pTitulo, DateTime pFechaComienzo, TimeSpan pDuracion, FrecuenciaEvento pFrecuencia)
        {
            if (pTitulo.Equals(""))
                throw new ArgumentException("Titulo no puede ser vacio");

            iCodigo = pCodigo;
            iTitulo = pTitulo;
            iFechaComienzo = pFechaComienzo;
            iDuracion = pDuracion;
            iFrecuencia = pFrecuencia;
        }

        public int Codigo
        {
            get { return iCodigo; }
        }

        public string Titulo
        {
            get { return iTitulo; }
        }

        public DateTime FechaComienzo
        {
            get { return iFechaComienzo; }
        }

        public TimeSpan Duracion
        {
            get { return iDuracion; }
        }

        public FrecuenciaEvento Frecuencia
        {
            get { return iFrecuencia; }
        }


        public bool SeRealiza(DateTime pFechaComienzo,DateTime pFechaFin)
        {
            if (pFechaFin.Date < this.iFechaComienzo)
            {
                return false;
            }
            else if (pFechaComienzo.Date <= this.iFechaComienzo.Date && this.iFechaComienzo.Date <= pFechaFin.Date)
            {
                return true;
            }

            switch (this.iFrecuencia)
            {           
                case FrecuenciaEvento.semana:
                    {

                        DateTime fechaAux = pFechaComienzo;

                        while (fechaAux < pFechaFin && !(fechaAux.DayOfWeek == iFechaComienzo.DayOfWeek))
                            fechaAux = fechaAux.AddDays(1);

                        return (fechaAux.DayOfWeek == iFechaComienzo.DayOfWeek);
                    }

                case FrecuenciaEvento.mes:
                    {

                        DateTime fechaAux = new DateTime(pFechaComienzo.Year, pFechaComienzo.Month, iFechaComienzo.Day);

                        while (fechaAux <= pFechaFin && !(fechaAux >= pFechaComienzo && fechaAux <= pFechaFin))
                            fechaAux = fechaAux.AddMonths(1);

                        return (fechaAux >= pFechaComienzo && fechaAux <= pFechaFin);
                        
                    }
                case FrecuenciaEvento.anio:
                    {

                        DateTime fechaAux = new DateTime(pFechaComienzo.Year, iFechaComienzo.Month, iFechaComienzo.Day);

                        while (fechaAux <= pFechaFin && !(fechaAux >= pFechaComienzo && fechaAux <= pFechaFin))
                            fechaAux = fechaAux.AddYears(1);

                        return (fechaAux >= pFechaComienzo && fechaAux <= pFechaFin);

                    }
                default:
                    return false;
            }

        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Evento)) return false;

            if (ReferenceEquals(null, obj)) return false;

            if (((Evento)obj).iCodigo == this.iCodigo) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return this.iCodigo;
        }
    }
}
