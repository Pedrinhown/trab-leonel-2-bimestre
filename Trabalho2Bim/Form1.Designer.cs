namespace Trabalho2Bim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumNota = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dgNf = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxRegiao = new System.Windows.Forms.ComboBox();
            this.btnVendasTot = new System.Windows.Forms.Button();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.mostrarFornecedor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNf)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumNota
            // 
            this.txtNumNota.Location = new System.Drawing.Point(81, 44);
            this.txtNumNota.Name = "txtNumNota";
            this.txtNumNota.Size = new System.Drawing.Size(100, 20);
            this.txtNumNota.TabIndex = 0;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(81, 84);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProd.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(81, 130);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(81, 177);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(272, 218);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 24);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dgNf
            // 
            this.dgNf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNf.Location = new System.Drawing.Point(81, 248);
            this.dgNf.Name = "dgNf";
            this.dgNf.ReadOnly = true;
            this.dgNf.RowHeadersWidth = 51;
            this.dgNf.Size = new System.Drawing.Size(690, 171);
            this.dgNf.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(81, 219);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero da nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vendedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fornecedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Regiao";
            // 
            // cbxRegiao
            // 
            this.cbxRegiao.FormattingEnabled = true;
            this.cbxRegiao.Items.AddRange(new object[] {
            "Sul",
            "Norte",
            "Sudeste",
            "Centro Oeste",
            "Nordeste"});
            this.cbxRegiao.Location = new System.Drawing.Point(272, 175);
            this.cbxRegiao.Name = "cbxRegiao";
            this.cbxRegiao.Size = new System.Drawing.Size(100, 21);
            this.cbxRegiao.TabIndex = 23;
            // 
            // btnVendasTot
            // 
            this.btnVendasTot.Location = new System.Drawing.Point(420, 35);
            this.btnVendasTot.Name = "btnVendasTot";
            this.btnVendasTot.Size = new System.Drawing.Size(89, 37);
            this.btnVendasTot.TabIndex = 25;
            this.btnVendasTot.Text = "Vendas Totais";
            this.btnVendasTot.UseVisualStyleBackColor = true;
            this.btnVendasTot.Click += new System.EventHandler(this.btnVendasTot_Click);
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Items.AddRange(new object[] {
            "Americanas",
            "Colombo",
            "Casas Bahias",
            "Condor",
            "Carrefour",
            "Havan",
            "Extra",
            "Alixpress",
            "Amazon"});
            this.cbxVendedor.Location = new System.Drawing.Point(272, 42);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(100, 21);
            this.cbxVendedor.TabIndex = 26;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Items.AddRange(new object[] {
            "MiniMercado Pedrão",
            "Mercadinho do Vitu",
            "Mercado do Pedrinho"});
            this.cbxCliente.Location = new System.Drawing.Point(272, 91);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(100, 21);
            this.cbxCliente.TabIndex = 27;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Items.AddRange(new object[] {
            "01 - Pedrão Transportes",
            "02 - Pedrinho Fretes",
            "03 - Vitau Fretes"});
            this.cbxFornecedor.Location = new System.Drawing.Point(272, 137);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(100, 21);
            this.cbxFornecedor.TabIndex = 28;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(420, 97);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(89, 37);
            this.btnCliente.TabIndex = 29;
            this.btnCliente.Text = "Compras por Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgFornecedor);
            this.panel1.Controls.Add(this.mostrarFornecedor);
            this.panel1.Location = new System.Drawing.Point(777, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 387);
            this.panel1.TabIndex = 30;
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.Location = new System.Drawing.Point(0, 29);
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.Size = new System.Drawing.Size(240, 357);
            this.dgFornecedor.TabIndex = 24;
            // 
            // mostrarFornecedor
            // 
            this.mostrarFornecedor.Location = new System.Drawing.Point(112, 0);
            this.mostrarFornecedor.Name = "mostrarFornecedor";
            this.mostrarFornecedor.Size = new System.Drawing.Size(128, 23);
            this.mostrarFornecedor.TabIndex = 23;
            this.mostrarFornecedor.Text = "Mostrar Fornecedor";
            this.mostrarFornecedor.UseVisualStyleBackColor = true;
            this.mostrarFornecedor.Click += new System.EventHandler(this.MostrarFornecedor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 32;
            this.button2.Text = "Região com mais Vendas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.btnVendasTot);
            this.Controls.Add(this.cbxRegiao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgNf);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtNumNota);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgNf)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumNota;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dgNf;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxRegiao;
        private System.Windows.Forms.Button btnVendasTot;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.Button mostrarFornecedor;
        private System.Windows.Forms.Button button2;
    }
}

