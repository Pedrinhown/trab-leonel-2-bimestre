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
        arquivo Arquivo = new arquivo();
        public printVendedor()
        {
            InitializeComponent();
            preencher();
        }

        public void preencher()
        {
            List<Vendedor> listaVendedores = new List<Vendedor>();
            double totalAmericanas = 0, totalColombo = 0, totalCasas_Bahias = 0, totalCondor = 0, totalCarrefour = 0, totalHavan = 0, totalExtra = 0, totalAliExpress = 0, totalAmazon = 0;

            for (int i = 0; i < Arquivo.listachamar().Count; i++)
            {
                if (Arquivo.listachamar()[i].vendedor == "Americanas")
                {
                    totalAmericanas = totalAmericanas + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Colombo")
                {
                    totalColombo = totalColombo + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Casas Bahias")
                {
                    totalCasas_Bahias = totalCasas_Bahias + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Condor")
                {
                    totalCondor = totalCondor + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Carrefour")
                {
                    totalCarrefour = totalCarrefour + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Havan")
                {
                    totalHavan = totalHavan + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Extra")
                {
                    totalExtra = totalExtra + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "AliExpress")
                {
                    totalAliExpress = totalAliExpress + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
                else if (Arquivo.listachamar()[i].vendedor == "Amazon")
                {
                    totalAmazon = totalAmazon + (Arquivo.listachamar()[i].qntVendida * Arquivo.listachamar()[i].precoUnit);
                }
            }

            dgvVendedor.Rows[0].Cells[0].Value = "Americanas";
            dgvVendedor.Rows[0].Cells[1].Value = totalAmericanas;
            dgvVendedor.Rows[1].Cells[0].Value = "Colombo";
            dgvVendedor.Rows[1].Cells[1].Value = totalColombo;
        }
    }
}
