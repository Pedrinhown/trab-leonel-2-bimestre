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
        Vendedor vendedorS = new Vendedor();
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
                if (qualquerbosta[i].vendedorS == "Americanas")
                {
                    totalAmericanas = totalAmericanas + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Colombo")
                {
                    totalColombo = totalColombo + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Casas Bahias")
                {
                    totalCasas_Bahias = totalCasas_Bahias + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Condor")
                {
                    totalCondor = totalCondor + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Carrefour")
                {
                    totalCarrefour = totalCarrefour + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Havan")
                {
                    totalHavan = totalHavan + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Extra")
                {
                    totalExtra = totalExtra + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "AliExpress")
                {
                    totalAliExpress = totalAliExpress + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].vendedorS == "Amazon")
                {
                    totalAmazon = totalAmazon + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
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
            vendedorS.vendedorS = vendedores;
            vendedorS.total_vendas = totalvend;
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
