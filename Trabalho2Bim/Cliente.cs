using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    class Cliente
    {
        private string cliente { get; set; }

        private double comprasCliente { get; set; }

        public string clienteS { get { return cliente; } set { cliente = value; } }
        public double comprasClienteS { get { return comprasCliente; } set {comprasCliente = value; } }
    }
}
