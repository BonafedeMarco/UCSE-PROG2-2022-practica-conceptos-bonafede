using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConceptosBonafede
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string cuit { get; set; }
        public double saldo { get; set; }

        // Punto 11
        public static Cliente operator -(Cliente clienteA, Cliente clienteB)
        {
            Cliente cl = new Cliente();

            if (clienteA.cuit == clienteB.cuit)
                cl.saldo = clienteA.saldo - clienteB.saldo;
            else
                cl.saldo = clienteA.saldo > clienteB.saldo ? clienteB.saldo : clienteA.saldo;

            return cl;
        }
    }
}
