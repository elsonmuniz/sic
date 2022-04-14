namespace SIC
{
    partial class ConsultarSkuAtivoComVariante
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridSKU = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSKU)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSKU
            // 
            this.gridSKU.AllowUserToAddRows = false;
            this.gridSKU.AllowUserToDeleteRows = false;
            this.gridSKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSKU.Location = new System.Drawing.Point(39, 199);
            this.gridSKU.Name = "gridSKU";
            this.gridSKU.ReadOnly = true;
            this.gridSKU.RowHeadersVisible = false;
            this.gridSKU.RowHeadersWidth = 51;
            this.gridSKU.RowTemplate.Height = 24;
            this.gridSKU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSKU.Size = new System.Drawing.Size(880, 416);
            this.gridSKU.TabIndex = 4;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 64);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consultar estoque e SKU  ativo com variante";
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(146, 50);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.ReadOnly = true;
            this.txNomeLojista.Size = new System.Drawing.Size(547, 22);
            this.txNomeLojista.TabIndex = 1;
            // 
            // txIdLojista
            // 
            this.txIdLojista.Location = new System.Drawing.Point(38, 50);
            this.txIdLojista.MaxLength = 10;
            this.txIdLojista.Name = "txIdLojista";
            this.txIdLojista.Size = new System.Drawing.Size(102, 22);
            this.txIdLojista.TabIndex = 1;
            // 
            // btPesquisarLojista
            // 
            this.btPesquisarLojista.Location = new System.Drawing.Point(719, 42);
            this.btPesquisarLojista.Name = "btPesquisarLojista";
            this.btPesquisarLojista.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarLojista.TabIndex = 0;
            this.btPesquisarLojista.Text = "Pesquisar";
            this.btPesquisarLojista.UseVisualStyleBackColor = true;
            this.btPesquisarLojista.Click += new System.EventHandler(this.btPesquisarLojista_Click);
            // 
            // ConsultarSkuAtivoComVariante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(958, 678);
            this.Controls.Add(this.gridSKU);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "ConsultarSkuAtivoComVariante";
            this.Text = "Consultar SKU com variante";
            this.Load += new System.EventHandler(this.ConsultarSkuAtivoComVariante_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSKU, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSKU)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSKU;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.Button btPesquisarLojista;
    }
}
