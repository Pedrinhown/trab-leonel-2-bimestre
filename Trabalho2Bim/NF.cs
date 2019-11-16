using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    public class NF
    {
        private int numNf { get; set; }
        private string nomeProd { get; set; }
        private int qntVendida { get; set; }
        private double precoUnit { get; set; }
        private double totalItem { get; set; }
        private string vendedor { get; set; }
        private string cliente { get; set; }
        private string fornecedor { get; set; }
        private string regiao { get; set; }

        public int numNfS { get { return numNf; } set { numNf = value; } }
        public string nomeProdS { get { return nomeProd; } set { nomeProd = value; } }
        public int qntVendidaS { get { return qntVendida; } set { qntVendida = value; } }
        public double precoUnitS { get { return precoUnit; } set { precoUnit = value; } }
        public double  totalItemS { get { return totalItem; } set { totalItem = value; } }
        public string vendedorS { get { return vendedor; } set { vendedor = value; } }
        public string clienteS { get { return cliente; } set { cliente = value; } }
        public string fornecedorS { get { return fornecedor; } set { fornecedor = value; } }
        public string regiaoS { get { return regiao; } set { regiao = value; } }

    }
}
