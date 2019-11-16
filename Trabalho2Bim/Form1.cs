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
    public partial class Form1 : Form {
        arquivo arquivo = new arquivo();

        public Form1() {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgNf.DataSource = null;
            dgNf.DataSource = arquivo.listachamar().OrderBy(x => x.numNf).ToList();
            dgNf.ReadOnly = true;
        }

        private void btnVendasTot_Click(object sender, EventArgs e)
        {
            printVendedor pVend = new printVendedor();
            this.Hide();
            pVend.Show();
            pVend.preencher(arquivo.listachamar());
        }

        private void btnGravar_Click(object sender, EventArgs e) {
            NF nf = new NF();

            //preencher(txtNomeProd.Text, txtCliente.Text, cbxVendedor.Text, cbxRegiao.Text, txtFornecedor.Text, Convert.ToInt32(txtNumNota.Text), Convert.ToInt32(txtQuantidade.Text), Convert.ToDouble(txtPreco.Text));

            arquivo.salvarlista(preencher(txtNomeProd.Text, cbxCliente.Text, cbxVendedor.Text, cbxRegiao.Text, cbxFornecedor.Text, Convert.ToInt32(txtNumNota.Text), Convert.ToInt32(txtQuantidade.Text), Convert.ToDouble(txtPreco.Text)));
        }

        private NF preencher(string nomeprod, string cliente, string vendedor, string regiao, string fornecedor, int numNF, int quantVendida, double precoUnit)
        {
            NF nff = new NF();

            nff.nomeProd = nomeprod;
            nff.numNf = numNF;
            nff.precoUnit = precoUnit;
            nff.qntVendida = quantVendida;
            nff.cliente = cliente;
            nff.vendedor = vendedor;
            nff.regiao = regiao;
            nff.fornecedor = fornecedor;
            return nff;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            printCliente clientes = new printCliente();
            clientes.Show();
            this.Hide();
            clientes.preencher(arquivo.listachamar());
        }
    }
}
