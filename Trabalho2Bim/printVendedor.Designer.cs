namespace Trabalho2Bim
{
    partial class printVendedor
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
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.ColumVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotalVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumVendedor,
            this.ColumTotalVendedor});
            this.dgvVendedor.Location = new System.Drawing.Point(12, 12);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(294, 426);
            this.dgvVendedor.TabIndex = 0;
            // 
            // ColumVendedor
            // 
            this.ColumVendedor.HeaderText = "Vendedor";
            this.ColumVendedor.Name = "ColumVendedor";
            // 
            // ColumTotalVendedor
            // 
            this.ColumTotalVendedor.HeaderText = "Total de vendas";
            this.ColumTotalVendedor.Name = "ColumTotalVendedor";
            // 
            // printVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.dgvVendedor);
            this.Name = "printVendedor";
            this.Text = "printVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotalVendedor;
    }
}