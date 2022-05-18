namespace SIC
{
    partial class SKURelated
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
            this.components = new System.ComponentModel.Container();
            this.gridSeller = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSku = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarProdutosDaLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destivarTodosProdutosDaLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.rbProductId = new System.Windows.Forms.RadioButton();
            this.rbReferenceId = new System.Windows.Forms.RadioButton();
            this.rbIdLojista = new System.Windows.Forms.RadioButton();
            this.rbSKUID = new System.Windows.Forms.RadioButton();
            this.txNomeSKU = new System.Windows.Forms.TextBox();
            this.txIdSKU = new System.Windows.Forms.TextBox();
            this.btPesquisarSKU = new System.Windows.Forms.Button();
            this.txQtdeLinhas = new System.Windows.Forms.TextBox();
            this.lbQuantidadeLiinhas = new System.Windows.Forms.Label();
            this.txInativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txAtivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).BeginInit();
            this.contextMenuStripSku.SuspendLayout();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSeller
            // 
            this.gridSeller.AllowUserToAddRows = false;
            this.gridSeller.AllowUserToDeleteRows = false;
            this.gridSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeller.ContextMenuStrip = this.contextMenuStripSku;
            this.gridSeller.Location = new System.Drawing.Point(39, 199);
            this.gridSeller.Name = "gridSeller";
            this.gridSeller.ReadOnly = true;
            this.gridSeller.RowHeadersVisible = false;
            this.gridSeller.RowHeadersWidth = 51;
            this.gridSeller.RowTemplate.Height = 24;
            this.gridSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridSeller.Size = new System.Drawing.Size(963, 416);
            this.gridSeller.TabIndex = 4;
            // 
            // contextMenuStripSku
            // 
            this.contextMenuStripSku.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSku.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ativarLojaToolStripMenuItem1,
            this.pesquisarToolStripMenuItem,
            this.toolStripSeparator3,
            this.ativarProdutosDaLojaToolStripMenuItem,
            this.destivarTodosProdutosDaLojaToolStripMenuItem});
            this.contextMenuStripSku.Name = "contextMenuStripSeller";
            this.contextMenuStripSku.Size = new System.Drawing.Size(273, 176);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
            this.ativarLojaToolStripMenuItem1.Text = "Ativar Flag Lock";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.pesquisarToolStripMenuItem.Text = "Desativar Flag Lock";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(269, 6);
            // 
            // ativarProdutosDaLojaToolStripMenuItem
            // 
            this.ativarProdutosDaLojaToolStripMenuItem.Name = "ativarProdutosDaLojaToolStripMenuItem";
            this.ativarProdutosDaLojaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.ativarProdutosDaLojaToolStripMenuItem.Text = "Ativar Todos Produtos da Loja";
            // 
            // destivarTodosProdutosDaLojaToolStripMenuItem
            // 
            this.destivarTodosProdutosDaLojaToolStripMenuItem.Name = "destivarTodosProdutosDaLojaToolStripMenuItem";
            this.destivarTodosProdutosDaLojaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.destivarTodosProdutosDaLojaToolStripMenuItem.Text = "Destivar Todos Produtos da Loja";
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.rbProductId);
            this.groupBoxSeller.Controls.Add(this.rbReferenceId);
            this.groupBoxSeller.Controls.Add(this.rbIdLojista);
            this.groupBoxSeller.Controls.Add(this.rbSKUID);
            this.groupBoxSeller.Controls.Add(this.txNomeSKU);
            this.groupBoxSeller.Controls.Add(this.txIdSKU);
            this.groupBoxSeller.Controls.Add(this.btPesquisarSKU);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 64);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consulta de SKU";
            // 
            // rbProductId
            // 
            this.rbProductId.AutoSize = true;
            this.rbProductId.Location = new System.Drawing.Point(500, 35);
            this.rbProductId.Name = "rbProductId";
            this.rbProductId.Size = new System.Drawing.Size(88, 20);
            this.rbProductId.TabIndex = 2;
            this.rbProductId.TabStop = true;
            this.rbProductId.Text = "Product Id";
            this.rbProductId.UseVisualStyleBackColor = true;
            // 
            // rbReferenceId
            // 
            this.rbReferenceId.AutoSize = true;
            this.rbReferenceId.Location = new System.Drawing.Point(389, 35);
            this.rbReferenceId.Name = "rbReferenceId";
            this.rbReferenceId.Size = new System.Drawing.Size(105, 20);
            this.rbReferenceId.TabIndex = 2;
            this.rbReferenceId.TabStop = true;
            this.rbReferenceId.Text = "Reference Id";
            this.rbReferenceId.UseVisualStyleBackColor = true;
            // 
            // rbIdLojista
            // 
            this.rbIdLojista.AutoSize = true;
            this.rbIdLojista.Location = new System.Drawing.Point(285, 35);
            this.rbIdLojista.Name = "rbIdLojista";
            this.rbIdLojista.Size = new System.Drawing.Size(83, 20);
            this.rbIdLojista.TabIndex = 2;
            this.rbIdLojista.TabStop = true;
            this.rbIdLojista.Text = "ID Lojista";
            this.rbIdLojista.UseVisualStyleBackColor = true;
            // 
            // rbSKUID
            // 
            this.rbSKUID.AutoSize = true;
            this.rbSKUID.Location = new System.Drawing.Point(190, 35);
            this.rbSKUID.Name = "rbSKUID";
            this.rbSKUID.Size = new System.Drawing.Size(71, 20);
            this.rbSKUID.TabIndex = 2;
            this.rbSKUID.TabStop = true;
            this.rbSKUID.Text = "SKU ID";
            this.rbSKUID.UseVisualStyleBackColor = true;
            // 
            // txNomeSKU
            // 
            this.txNomeSKU.Location = new System.Drawing.Point(137, 77);
            this.txNomeSKU.Name = "txNomeSKU";
            this.txNomeSKU.ReadOnly = true;
            this.txNomeSKU.Size = new System.Drawing.Size(547, 22);
            this.txNomeSKU.TabIndex = 1;
            // 
            // txIdSKU
            // 
            this.txIdSKU.Location = new System.Drawing.Point(29, 77);
            this.txIdSKU.MaxLength = 12;
            this.txIdSKU.Name = "txIdSKU";
            this.txIdSKU.Size = new System.Drawing.Size(102, 22);
            this.txIdSKU.TabIndex = 1;
            // 
            // btPesquisarSKU
            // 
            this.btPesquisarSKU.Location = new System.Drawing.Point(719, 42);
            this.btPesquisarSKU.Name = "btPesquisarSKU";
            this.btPesquisarSKU.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarSKU.TabIndex = 0;
            this.btPesquisarSKU.Text = "Pesquisar";
            this.btPesquisarSKU.UseVisualStyleBackColor = true;
            this.btPesquisarSKU.Click += new System.EventHandler(this.btPesquisarSKU_Click);
            // 
            // txQtdeLinhas
            // 
            this.txQtdeLinhas.Location = new System.Drawing.Point(129, 636);
            this.txQtdeLinhas.Name = "txQtdeLinhas";
            this.txQtdeLinhas.ReadOnly = true;
            this.txQtdeLinhas.Size = new System.Drawing.Size(100, 22);
            this.txQtdeLinhas.TabIndex = 5;
            // 
            // lbQuantidadeLiinhas
            // 
            this.lbQuantidadeLiinhas.AutoSize = true;
            this.lbQuantidadeLiinhas.Location = new System.Drawing.Point(36, 639);
            this.lbQuantidadeLiinhas.Name = "lbQuantidadeLiinhas";
            this.lbQuantidadeLiinhas.Size = new System.Drawing.Size(77, 16);
            this.lbQuantidadeLiinhas.TabIndex = 6;
            this.lbQuantidadeLiinhas.Text = "Qtde linhas:";
            // 
            // txInativo
            // 
            this.txInativo.Location = new System.Drawing.Point(357, 633);
            this.txInativo.Name = "txInativo";
            this.txInativo.ReadOnly = true;
            this.txInativo.Size = new System.Drawing.Size(100, 22);
            this.txInativo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inativos:";
            // 
            // txAtivo
            // 
            this.txAtivo.Location = new System.Drawing.Point(596, 633);
            this.txAtivo.Name = "txAtivo";
            this.txAtivo.ReadOnly = true;
            this.txAtivo.Size = new System.Drawing.Size(100, 22);
            this.txAtivo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ativos:";
            // 
            // SKURelated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1039, 678);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQuantidadeLiinhas);
            this.Controls.Add(this.txAtivo);
            this.Controls.Add(this.txInativo);
            this.Controls.Add(this.txQtdeLinhas);
            this.Controls.Add(this.gridSeller);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "SKURelated";
            this.Text = "Consultar SKU";
            this.Load += new System.EventHandler(this.SKURelated_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSeller, 0);
            this.Controls.SetChildIndex(this.txQtdeLinhas, 0);
            this.Controls.SetChildIndex(this.txInativo, 0);
            this.Controls.SetChildIndex(this.txAtivo, 0);
            this.Controls.SetChildIndex(this.lbQuantidadeLiinhas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).EndInit();
            this.contextMenuStripSku.ResumeLayout(false);
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSeller;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeSKU;
        private System.Windows.Forms.TextBox txIdSKU;
        private System.Windows.Forms.Button btPesquisarSKU;
        private System.Windows.Forms.RadioButton rbReferenceId;
        private System.Windows.Forms.RadioButton rbIdLojista;
        private System.Windows.Forms.RadioButton rbSKUID;
        private System.Windows.Forms.RadioButton rbProductId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSku;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.TextBox txQtdeLinhas;
        private System.Windows.Forms.Label lbQuantidadeLiinhas;
        private System.Windows.Forms.TextBox txInativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ativarProdutosDaLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destivarTodosProdutosDaLojaToolStripMenuItem;
    }
}
