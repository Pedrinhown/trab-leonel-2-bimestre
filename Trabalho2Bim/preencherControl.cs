using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    public class preencherControl : preencherModel
    {
        public NF preencherControle(string nomeprod, string cliente, string vendedor, string regiao, string fornecedor, int numNF, int quantVendida, double precoUnit)
        {
            NF nf = new NF();
            nf = preencherModell(nomeprod, cliente, vendedor, regiao, fornecedor, numNF, quantVendida, precoUnit);
            return nf;
        }
    }
}
