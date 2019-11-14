using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2Bim
{
    public partial class printVendedor : Form {
        arquivo Arquivo = new arquivo();
        public printVendedor() {
            InitializeComponent();
        }

        public void preencher() {
            List<Vendedor> listaVendedores = new List<Vendedor>();
            double totalAmericanas = 0, totalColombo = 0, totalCasas_Bahias = 0, totalCondor = 0, totalCarrefour = 0, totalHavan = 0, totalExtra = 0, totalAliExpress = 0, totalAmazon = 0;

            for (int i = 0; i < Arquivo.listageral.Count; i++) {
                if (Arquivo.listageral[i].vendedor == "Americanas") {
                    totalAmericanas = totalAmericanas + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Colombo") {
                    totalColombo = totalColombo + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Casas Bahias") {
                    totalCasas_Bahias = totalCasas_Bahias + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Condor") {
                    totalCondor = totalCondor + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Carrefour") {
                    totalCarrefour = totalCarrefour + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Havan") {
                    totalHavan = totalHavan + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Extra") {
                    totalExtra = totalExtra + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "AliExpress") {
                    totalAliExpress = totalAliExpress + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                } else if (Arquivo.listageral[i].vendedor == "Amazon") {
                    totalAmazon = totalAmazon + (Arquivo.listageral[i].qntVendida * Arquivo.listageral[i].precoUnit);
                }
            }
        }
    }
}
