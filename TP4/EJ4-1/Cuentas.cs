using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    /// <summary>
    /// Contiene las cuentas de un cliente
    /// </summary>
    class Cuentas
    {
        // iCliente representa un cliente.
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Cuentas()
        {

            iCuentaCorriente = new Cuenta(1000, 50);
            iCajaAhorro = new Cuenta(500);

        }

        /// <summary>
        /// Obtiene la cuenta corriente de un cliente.
        /// </summary>
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        /// <summary>
        /// Obtiene la caja de ahorro de un cliente.
        /// </summary>
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

    }
}
