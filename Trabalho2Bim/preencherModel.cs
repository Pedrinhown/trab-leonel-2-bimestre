using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    public class preencherModel
    {
        public NF preencherModell(string nomeprod, string cliente, string vendedor, string regiao, string fornecedor, int numNF, int quantVendida, double precoUnit)
        {
            NF nff = new NF();

            nff.nomeProdS = nomeprod;
            nff.numNfS = numNF;
            nff.precoUnitS = precoUnit;
            nff.qntVendidaS = quantVendida;
            nff.clienteS = cliente;
            nff.vendedorS = vendedor;
            nff.regiaoS = regiao;
            nff.fornecedorS = fornecedor;
            nff.totalItemS = quantVendida * precoUnit;

            return nff;
        }
    }
}
