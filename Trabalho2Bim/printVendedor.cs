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

    public partial class printVendedor : Form
    {
        List<Vendedor> listaVendedores = new List<Vendedor>();
        Vendedor vendedor = new Vendedor();
        arquivo Arquivo = new arquivo();

        public printVendedor()
        {
            InitializeComponent();
        }

        public void preencher(List<NF> qualquerbosta)
        {
            double totalAmericanas = 0, totalColombo = 0, totalCasas_Bahias = 0, totalCondor = 0, totalCarrefour = 0, totalHavan = 0, totalExtra = 0, totalAliExpress = 0, totalAmazon = 0;

            for (int i = 0; i < qualquerbosta.Count; i++)
            {
                if (qualquerbosta[i].vendedor == "Americanas")
                {
                    totalAmericanas = totalAmericanas + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Colombo")
                {
                    totalColombo = totalColombo + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Casas Bahias")
                {
                    totalCasas_Bahias = totalCasas_Bahias + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Condor")
                {
                    totalCondor = totalCondor + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Carrefour")
                {
                    totalCarrefour = totalCarrefour + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Havan")
                {
                    totalHavan = totalHavan + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Extra")
                {
                    totalExtra = totalExtra + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "AliExpress")
                {
                    totalAliExpress = totalAliExpress + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].vendedor == "Amazon")
                {
                    totalAmazon = totalAmazon + (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
            }

            povoarvend("Americanas", totalAmericanas);
            //listaVendedores.Add(vendedor);
            povoarvend("Colombo", totalColombo);
            //listaVendedores.Add(vendedor);
            povoarvend("Casas Bahias", totalCasas_Bahias);
            //listaVendedores.Add(vendedor);
            povoarvend("Condor", totalCondor);
            //listaVendedores.Add(vendedor);
            povoarvend("Carrefour", totalCarrefour);
            //listaVendedores.Add(vendedor);
            povoarvend("Havan", totalHavan);
            //listaVendedores.Add(vendedor);
            povoarvend("Extra", totalExtra);
            //listaVendedores.Add(vendedor);
            povoarvend("AliExpress", totalAliExpress);
            //listaVendedores.Add(vendedor);
            povoarvend("Amazon", totalAmazon);
            //listaVendedores.Add(vendedor);

            dgvVendedor.DataSource = null;
            dgvVendedor.DataSource = listaVendedores;
        }

        public void povoarvend(string vendedores, double totalvend)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.vendedor = vendedores;
            vendedor.Total_Vendas = totalvend;
            listaVendedores.Add(vendedor);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
            dgvVendedor.ReadOnly = true;
        }
    }
}
