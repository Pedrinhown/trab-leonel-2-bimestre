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
        NF nf = new NF();
        arquivo arquivo = new arquivo();

        public Form1() {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e) {

            nf.nomeProd = txtNomeProd.Text;
            nf.numNf = Convert.ToInt32(txtNumNota.Text);
            nf.precoUnit = Convert.ToDouble(txtPreco.Text);
            nf.qntVendida = Convert.ToInt32(txtQuantidade.Text);
            nf.cliente = txtCliente.Text;
            nf.vendedor = cbxVendedor.Text;
            nf.regiao = cbxRegiao.Text;
            nf.totalItem += nf.precoUnit;
            nf.fornecedor = txtFornecedor.Text;


            arquivo.listageral.Add(nf);
        }

        private void btnListar_Click(object sender, EventArgs e) {
            dgNf.DataSource = null;
            dgNf.DataSource = arquivo.listageral.OrderBy(x => x.numNf).ToList();
        }

        private void btnVendasTot_Click(object sender, EventArgs e) {
            printVendedor pVend = new printVendedor();
            this.Hide();
            pVend.Show();
        }
    }
}
