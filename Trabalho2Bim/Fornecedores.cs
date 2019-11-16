using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    public class Fornecedores
    {
        private string fornecedor{ get; set; }
        private double totalVenda { get; set; }

        public string fornecedorS { get { return fornecedor; } set { fornecedor = value; } }
        public double totalVendaS { get { return totalVenda; } set { totalVenda = value; } }
    }
}
