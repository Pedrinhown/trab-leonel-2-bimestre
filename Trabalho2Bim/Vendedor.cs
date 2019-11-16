using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim {
    class Vendedor {
        private string vendedor { get; set; }
        private double Total_Vendas { get; set; }

        public string vendedorS { get { return vendedor; } set { vendedor = value; } }
        public double total_vendas {get { return Total_Vendas; } set { Total_Vendas = value; } }
    }
}
