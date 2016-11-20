using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    public class Evento
    {
        //Codigo identificador del evento
        private int iCodigo;
        private string iTitulo;
        private DateTime iFechaComienzo;
        private TimeSpan iDuracion;
        private FrecuenciaEvento iFrecuencia;

        /// <summary>
        /// Constructor del evento
        /// </summary>
        /// <param name="pCodigo">Codigo</param>
        /// <param name="pTitulo">Titulo</param>
        /// <param name="pFechaComienzo">Fecha de comienzo</param>
        /// <param name="pDuracion">Duracion</param>
        /// <param name="pFrecuencia">Frecuencia de repeticion</param>
        /// <exception cref="ArgumentException">Titulo Vacio</exception>
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

        /// <summary>
        /// Codigo del evento
        /// </summary>
        public int Codigo
        {
            get { return iCodigo; }
        }

        /// <summary>
        /// Titulo del evento
        /// </summary>
        public string Titulo
        {
            get { return iTitulo; }
        }

        /// <summary>
        /// Fecha de comienzo del evento
        /// </summary>
        public DateTime FechaComienzo
        {
            get { return iFechaComienzo; }
        }

        /// <summary>
        /// Duracion del evento
        /// </summary>
        public TimeSpan Duracion
        {
            get { return iDuracion; }
        }

        /// <summary>
        /// Freucencia de repeticion del evento
        /// </summary>
        public FrecuenciaEvento Frecuencia
        {
            get { return iFrecuencia; }
        }

        /// <summary>
        /// Verifica si un evento comienza en un intervalo de fechas dado
        /// </summary>
        /// <param name="pFechaComienzo">Fecha de comienzo del intervalo</param>
        /// <param name="pFechaFin">Fecha de fin del intervalo</param>
        /// <returns>Verdadero si comienza al menos una vez dentro del intervalo, falso en caso contrario</returns>
        public bool SeRealiza(DateTime pFechaComienzo,DateTime pFechaFin)
        {
            //Si el evento comienza despues del intervalo, no se realiza en el intervalo
            if (pFechaFin.Date < this.iFechaComienzo)
            {
                return false;
            }
            //Si la fecha de comienzo del evento es dentro del intervalo, entonces se realiza dentro del mismo
            else if (pFechaComienzo.Date <= this.iFechaComienzo.Date && this.iFechaComienzo.Date <= pFechaFin.Date)
            {
                return true;
            }

            //Si el evento comenzo antes del intervalo, entonces verificaremos segun su frecuencia
            switch (this.iFrecuencia)
            {           
                case FrecuenciaEvento.semana:
                    {
                        //Comenzamos desde el primer dia del intervalo dado
                        DateTime fechaAux = pFechaComienzo;

                        //Recorremos el intervalo (sumando de a 1 dia) hasta su fin o hasta que el dia de la semana sea igual al dia de la semana en que comenzo el evento
                        while (fechaAux < pFechaFin && !(fechaAux.DayOfWeek == iFechaComienzo.DayOfWeek))
                            fechaAux = fechaAux.AddDays(1);

                        //Retornamos si se encontro un dia igual al de comienzo del evento.
                        return (fechaAux.DayOfWeek == iFechaComienzo.DayOfWeek);
                    }

                case FrecuenciaEvento.mes:
                    {
                        //Partimos del mes y año de comienzo del intervalo y el dia del evento
                        DateTime fechaAux = new DateTime(pFechaComienzo.Year, pFechaComienzo.Month, iFechaComienzo.Day);

                        //Recorremos el intervalo (sumando de a 1 mes) hasta su fin o hasta que la fechaAux este incluida en el intervalo dado
                        while (fechaAux <= pFechaFin && !(fechaAux >= pFechaComienzo && fechaAux <= pFechaFin))
                            fechaAux = fechaAux.AddMonths(1);

                        //Devolvemos si la fechaAux esta incluida en el intervalo dado
                        return (fechaAux >= pFechaComienzo && fechaAux <= pFechaFin);
                        
                    }
                case FrecuenciaEvento.anio:
                    {
                        //Partimos del año de la fecha de comienzo del intervalo y , dia y mes de comienzo del evento
                        DateTime fechaAux = new DateTime(pFechaComienzo.Year, iFechaComienzo.Month, iFechaComienzo.Day);

                        //Recorremos el intervalo (sumando de a 1 año) hasta su fin o hasta que la fechaAux este incluida en el intervalo
                        while (fechaAux <= pFechaFin && !(fechaAux >= pFechaComienzo && fechaAux <= pFechaFin))
                            fechaAux = fechaAux.AddYears(1);

                        //Devolvemos si la fechaAux esta incluida en el intervalo dado
                        return (fechaAux >= pFechaComienzo && fechaAux <= pFechaFin);

                    }
                default: //En otro caso (frecuencia unica).
                    return false;
            }

        }

        /// <summary>
        /// Verifica la igualdad del evento con otro dado en base a sus codigos
        /// </summary>
        /// <param name="obj">Evento con el cual comparar</param>
        /// <returns>Verdadero si los codigos coinciden, falso en caso contrario</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Evento)) return false;

            if (ReferenceEquals(null, obj)) return false;

            if (((Evento)obj).iCodigo == this.iCodigo) return true;

            return false;
        }

        /// <summary>
        /// Obitene el hash del evento en base a su codigo
        /// </summary>
        /// <returns>Codigo hash</returns>
        public override int GetHashCode()
        {
            return this.iCodigo;
        }
    }
}
