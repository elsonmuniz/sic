namespace SIC
{
    partial class Ajustes
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
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStripConsultaPedidoGetnet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.btImportarOrderLote = new System.Windows.Forms.Button();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txOrderId = new System.Windows.Forms.TextBox();
            this.btPesquisarOrderId = new System.Windows.Forms.Button();
            this.incluirAjusteTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.contextMenuStripConsultaPedidoGetnet.SuspendLayout();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.ContextMenuStrip = this.contextMenuStripConsultaPedidoGetnet;
            this.gridOrder.Location = new System.Drawing.Point(12, 185);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.RowHeadersVisible = false;
            this.gridOrder.RowHeadersWidth = 51;
            this.gridOrder.RowTemplate.Height = 24;
            this.gridOrder.Size = new System.Drawing.Size(1437, 467);
            this.gridOrder.TabIndex = 6;
            // 
            // contextMenuStripConsultaPedidoGetnet
            // 
            this.contextMenuStripConsultaPedidoGetnet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripConsultaPedidoGetnet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ativarLojaToolStripMenuItem1,
            this.incluirAjusteTesteToolStripMenuItem});
            this.contextMenuStripConsultaPedidoGetnet.Name = "contextMenuStripSeller";
            this.contextMenuStripConsultaPedidoGetnet.Size = new System.Drawing.Size(211, 154);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.ativarLojaToolStripMenuItem1.Text = "&Reprocessar ajuste";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.btImportarOrderLote);
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txOrderId);
            this.groupBoxSeller.Controls.Add(this.btPesquisarOrderId);
            this.groupBoxSeller.Location = new System.Drawing.Point(12, 50);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 5;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Pesquisar carteira do lojista na Getnet";
            // 
            // btImportarOrderLote
            // 
            this.btImportarOrderLote.Location = new System.Drawing.Point(710, 66);
            this.btImportarOrderLote.Name = "btImportarOrderLote";
            this.btImportarOrderLote.Size = new System.Drawing.Size(149, 38);
            this.btImportarOrderLote.TabIndex = 4;
            this.btImportarOrderLote.Text = "Consultar em Lote";
            this.btImportarOrderLote.UseVisualStyleBackColor = true;
            this.btImportarOrderLote.Click += new System.EventHandler(this.btImportarOrderLote_Click);
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(137, 74);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.ReadOnly = true;
            this.txNomeLojista.Size = new System.Drawing.Size(388, 22);
            this.txNomeLojista.TabIndex = 2;
            // 
            // txOrderId
            // 
            this.txOrderId.Location = new System.Drawing.Point(29, 74);
            this.txOrderId.MaxLength = 15;
            this.txOrderId.Name = "txOrderId";
            this.txOrderId.Size = new System.Drawing.Size(102, 22);
            this.txOrderId.TabIndex = 1;
            // 
            // btPesquisarOrderId
            // 
            this.btPesquisarOrderId.Location = new System.Drawing.Point(560, 66);
            this.btPesquisarOrderId.Name = "btPesquisarOrderId";
            this.btPesquisarOrderId.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarOrderId.TabIndex = 3;
            this.btPesquisarOrderId.Text = "Pesquisar";
            this.btPesquisarOrderId.UseVisualStyleBackColor = true;
            this.btPesquisarOrderId.Click += new System.EventHandler(this.btPesquisarOrderId_Click);
            // 
            // incluirAjusteTesteToolStripMenuItem
            // 
            this.incluirAjusteTesteToolStripMenuItem.Name = "incluirAjusteTesteToolStripMenuItem";
            this.incluirAjusteTesteToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.incluirAjusteTesteToolStripMenuItem.Text = "&Incluir ajuste Teste";
            this.incluirAjusteTesteToolStripMenuItem.Click += new System.EventHandler(this.incluirAjusteTesteToolStripMenuItem_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1461, 678);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "Ajustes";
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.Ajustes_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.contextMenuStripConsultaPedidoGetnet.ResumeLayout(false);
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.Button btImportarOrderLote;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txOrderId;
        private System.Windows.Forms.Button btPesquisarOrderId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConsultaPedidoGetnet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incluirAjusteTesteToolStripMenuItem;
    }
}
