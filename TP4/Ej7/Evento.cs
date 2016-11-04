using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Evento
    {
        private int iCodigo;
        private string iTitulo;
        private DateTime iFechaComienzo;
        private TimeSpan iDuracion;
        private FrecuenciaEvento iFrecuencia;

        public Evento(string pTitulo,DateTime pFechaComienzo, TimeSpan pDuracion, FrecuenciaEvento pFrecuencia)
        {
            iCodigo = 0;
            iTitulo = pTitulo;
            iFechaComienzo = pFechaComienzo;
            iDuracion = pDuracion;
            iFrecuencia = pFrecuencia;
        }

        public DateTime FechaComienzo { get { return iFechaComienzo; } }

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
