using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuenta
    {
        //iSaldo, es el saldo que hay en la cuenta. iAcuerdo es el acuerdo que tiene establecido la cuenta.
        private double iSaldo, iAcuerdo;

        /// <summary>
        /// Crea una cuenta con el acuerdo especificado.
        /// </summary>
        /// <param name="pAcuerdo">Acuerdo</param>
        public Cuenta(double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = 0;
        }

        /// <summary>
        /// Crea una cuenta con el acuerdo y el saldo inicial especificado.
        /// </summary>
        /// <param name="pSaldoInicial">Saldo inicial</param>
        /// <param name="pAcuerdo">Acuerdo</param>
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = pSaldoInicial;
        }

        /// <summary>
        /// Devuelve el saldo de la cuenta.
        /// </summary>
        public double Saldo
        {
            get { return this.iSaldo; }
        }

        /// <summary>
        /// Devuelve el acuerdo de la cuenta.
        /// </summary>
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        /// <summary>
        /// Acredita saldo en una cuenta.
        /// </summary>
        /// <param name="pSaldo">Saldo a acreditar</param>
        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo < 0)
                throw new ArgumentException("NoNegativo", "pSaldo");
            if (pSaldo == 0)
                throw new ArgumentNullException("pSaldo", "NoCero");

            this.iSaldo += pSaldo;
        }

        /// <summary>
        /// Debita saldo en una cuenta
        /// </summary>
        /// <param name="pSaldo">Saldo a debitar</param>
        /// <returns>(true) si se puede debitar dicho saldo, (false) si no se puede debitar el saldo</returns>
        public void DebitarSaldo(double pSaldo)
        {
            if (pSaldo < 0)
                throw new ArgumentException("NoNegativo", "pSaldo");
            if (pSaldo == 0)
                throw new ArgumentNullException("pSaldo", "NoCero");

            if (iSaldo + iAcuerdo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
            }
            else
                throw new SaldoException("SaldoInsuficiente");
        }

    }
}
