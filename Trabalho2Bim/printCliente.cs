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
    public partial class printCliente : Form
    {
        public printCliente()
        {
            InitializeComponent();
        }


        List<Cliente> listaClientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        arquivo Arquivo = new arquivo();


        public void preencher(List<NF> qualquerbosta)
        {
            //double totalAmericanas = 0, totalColombo = 0, totalCasas_Bahias = 0, totalCondor = 0, totalCarrefour = 0, totalHavan = 0, totalExtra = 0, totalAliExpress = 0, totalAmazon = 0;
            double miniMercadoPedrao = 0, mercadinhoDoVitu = 0, mercadoDoPedrinho = 0;

            for (int i = 0; i < qualquerbosta.Count; i++)
            {
                if (qualquerbosta[i].clienteS == "MiniMercado Pedrão")
                {
                    miniMercadoPedrao = miniMercadoPedrao + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].clienteS == "Mercadinho do Vitu")
                {
                    mercadinhoDoVitu = mercadinhoDoVitu + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
                else if (qualquerbosta[i].clienteS == "Mercado do Pedrinho")
                {
                    mercadoDoPedrinho = mercadoDoPedrinho + (qualquerbosta[i].qntVendidaS * qualquerbosta[i].precoUnitS);
                }
            }

            povoarvend("MiniMercado Pedrão", miniMercadoPedrao);
            //listaVendedores.Add(vendedor);
            povoarvend("Mercadinho do Vitu", mercadinhoDoVitu);
            //listaVendedores.Add(vendedor);
            povoarvend("Mercado do Pedrinho", mercadoDoPedrinho);
            //listaVendedores.Add(vendedor);

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = listaClientes;
        }

        public void povoarvend(string clientes, double totalvend)
        {
            Cliente cliente = new Cliente();
            cliente.clienteS = clientes;
            cliente.comprasClienteS = totalvend;
            listaClientes.Add(cliente);
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
    }
}
