using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim {
    class arquivo {
        
        List<NF> listageral = new List<NF>();

        
        public void salvarlista(NF nf)
        {
            listageral.Add(nf);
        }

        public List<NF> listachamar()
        {
            return listageral;
        }

        //public void SalvarFuncionario(List<Funcionario> listaFuncionario) {

        //    string json = JsonConvert.SerializeObject(listaFuncionario.ToArray());

        //    File.WriteAllText(@".\listaFuncionario.txt", json);

        //}
    }
}
