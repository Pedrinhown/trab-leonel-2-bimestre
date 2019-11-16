using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2Bim
{
    public class jSon
    {

        public bool SalvarArquivoJson(List<NF> listaClientes)
        {
            string json = JsonConvert.SerializeObject(listaClientes, Formatting.Indented);
            //Converte formato "string" para formato "Json"
            //string json(listaClientes) -> clientes.json
            File.WriteAllText(@"./nf.json", json);
            return true;
        }

        public List<NF> LerArquivoJson()
        {
            string jsonFilePath = @"./nf.json";
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                List<NF> lista = JsonConvert.DeserializeObject<List<NF>>(json);

                return lista;
            }
            return null;
        }

    }
}
