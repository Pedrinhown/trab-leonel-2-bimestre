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
    public partial class Form1 : Form
    {
        arquivo arquivo = new arquivo();

        public Form1()
        {
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
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
            nff.totalItem = quantVendida * precoUnit;
            return nff;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            printCliente clientes = new printCliente();
            clientes.Show();
            this.Hide();
            clientes.preencher(arquivo.listachamar());
        }
        List<NF> listNf = new List<NF>();
        List<Fornecedores> listFornecedor = new List<Fornecedores>();

        public void FornecedorVenda(string fornecedor, double vendaTotal)
        {
            Fornecedores forn = new Fornecedores();
            forn.fornecedor = fornecedor;
            forn.totalVenda = vendaTotal;
            listFornecedor.Add(forn);
        }

        public void preencher(List<NF> qualquerbosta)
        {
            double totalPedrao = 0, totalPedrin = 0, totalVitau = 0;

            for (int i = 0; i < qualquerbosta.Count; i++)
            {
                if (qualquerbosta[i].fornecedor == "01 - Pedrão Transportes")
                {
                    totalPedrao += (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].fornecedor == "02 - Pedrinho Fretes")
                {
                    totalPedrin += (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
                else if (qualquerbosta[i].fornecedor == "03 - Vitau Fretes")
                {
                    totalVitau += (qualquerbosta[i].qntVendida * qualquerbosta[i].precoUnit);
                }
            }

            FornecedorVenda("TransportadoraPedrao", totalPedrao);
            FornecedorVenda("FretesPedrin", totalPedrin);
            FornecedorVenda("VitauFlertes", totalVitau);
            dgFornecedor.DataSource = null;
            dgFornecedor.DataSource = listFornecedor;

        }

        private void MostrarFornecedor_Click(object sender, EventArgs e)
        {
            preencher(arquivo.listachamar());
        }

        public void Regiao(List<NF> list)
        {
            double norte = list.FindAll(x => x.regiao.Contains("Norte")).Sum(x => x.totalItem);
            double sul = list.FindAll(x => x.regiao.Contains("Sul")).Sum(x => x.totalItem);
            double sudeste = list.FindAll(x => x.regiao.Contains("Sudeste")).Sum(x => x.totalItem);
            double nordeste = list.FindAll(x => x.regiao.Contains("Nordeste")).Sum(x => x.totalItem);
            double centrooeste = list.FindAll(x => x.regiao.Contains("Centro Oeste")).Sum(x => x.totalItem);

            if (norte > sul && norte > sudeste && norte > nordeste && norte > centrooeste)
            {
                MessageBox.Show($"A região com mais vendas é a Norte, com R$ {norte} vendidos");
            }
            if (sul > norte && sul > sudeste && sul > nordeste && sul > centrooeste)
            {
                MessageBox.Show($"A região com mais vendas é a Sul, com R$ {sul} vendidos");
            }
            if (sudeste > norte && sudeste > sul && sudeste > nordeste && sudeste > centrooeste)
            {
                MessageBox.Show($"A região com mais vendas é a Sudeste, com R$ {sudeste} vendidos");
            }
            if (nordeste > norte && nordeste > sul && nordeste > sudeste && nordeste > centrooeste)
            {
                MessageBox.Show($"A região com mais vendas é a Nordeste, com R$ {nordeste} vendidos");
            }
            if (centrooeste > norte && centrooeste > sul && centrooeste > sudeste && centrooeste > nordeste)
            {
                MessageBox.Show($"A região com mais vendas é a CentroOeste, com R$ {centrooeste} vendidos");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Regiao(arquivo.listachamar());
        }
    }
}
