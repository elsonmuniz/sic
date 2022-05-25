namespace SIC
{
    partial class ConsultarPedidoFinanceiro
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
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.btImportarLote = new System.Windows.Forms.Button();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txOrderId = new System.Windows.Forms.TextBox();
            this.btPesquisarOrder = new System.Windows.Forms.Button();
            this.contextMenuStripConsultaPedidoGetnet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridOrderFinanceiro = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridOrderPagamento = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridOrderGatilho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txQtdConfPagto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarImportarTransacao = new System.Windows.Forms.ProgressBar();
            this.groupBoxSeller.SuspendLayout();
            this.contextMenuStripConsultaPedidoGetnet.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderFinanceiro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderPagamento)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderGatilho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.btImportarLote);
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txOrderId);
            this.groupBoxSeller.Controls.Add(this.btPesquisarOrder);
            this.groupBoxSeller.Location = new System.Drawing.Point(12, 39);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(1089, 103);
            this.groupBoxSeller.TabIndex = 6;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consulta no processo de pagamento do financeiro";
            // 
            // btImportarLote
            // 
            this.btImportarLote.Location = new System.Drawing.Point(884, 33);
            this.btImportarLote.Name = "btImportarLote";
            this.btImportarLote.Size = new System.Drawing.Size(102, 47);
            this.btImportarLote.TabIndex = 2;
            this.btImportarLote.Text = "Importar em Lote";
            this.btImportarLote.UseVisualStyleBackColor = true;
            this.btImportarLote.Click += new System.EventHandler(this.btImportarLote_Click_1);
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(146, 50);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.ReadOnly = true;
            this.txNomeLojista.Size = new System.Drawing.Size(547, 22);
            this.txNomeLojista.TabIndex = 1;
            // 
            // txOrderId
            // 
            this.txOrderId.Location = new System.Drawing.Point(38, 50);
            this.txOrderId.MaxLength = 15;
            this.txOrderId.Name = "txOrderId";
            this.txOrderId.Size = new System.Drawing.Size(102, 22);
            this.txOrderId.TabIndex = 1;
            this.txOrderId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txOrderId_KeyDown);
            // 
            // btPesquisarOrder
            // 
            this.btPesquisarOrder.Location = new System.Drawing.Point(719, 42);
            this.btPesquisarOrder.Name = "btPesquisarOrder";
            this.btPesquisarOrder.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarOrder.TabIndex = 0;
            this.btPesquisarOrder.Text = "Pesquisar";
            this.btPesquisarOrder.UseVisualStyleBackColor = true;
            this.btPesquisarOrder.Click += new System.EventHandler(this.btPesquisarOrder_Click);
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
            this.pesquisarToolStripMenuItem});
            this.contextMenuStripConsultaPedidoGetnet.Name = "contextMenuStripSeller";
            this.contextMenuStripConsultaPedidoGetnet.Size = new System.Drawing.Size(276, 126);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(272, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(275, 22);
            this.ativarLojaToolStripMenuItem1.Text = "&Incluir Tracking Comissionamento";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.pesquisarToolStripMenuItem.Text = "&Importar Transação";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1474, 518);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridOrderFinanceiro);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1466, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridOrderFinanceiro
            // 
            this.gridOrderFinanceiro.AllowUserToAddRows = false;
            this.gridOrderFinanceiro.AllowUserToDeleteRows = false;
            this.gridOrderFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderFinanceiro.ContextMenuStrip = this.contextMenuStripConsultaPedidoGetnet;
            this.gridOrderFinanceiro.Location = new System.Drawing.Point(-4, 9);
            this.gridOrderFinanceiro.Name = "gridOrderFinanceiro";
            this.gridOrderFinanceiro.ReadOnly = true;
            this.gridOrderFinanceiro.RowHeadersVisible = false;
            this.gridOrderFinanceiro.RowHeadersWidth = 51;
            this.gridOrderFinanceiro.RowTemplate.Height = 24;
            this.gridOrderFinanceiro.Size = new System.Drawing.Size(1474, 470);
            this.gridOrderFinanceiro.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridOrderPagamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1466, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridOrderPagamento
            // 
            this.gridOrderPagamento.AllowUserToAddRows = false;
            this.gridOrderPagamento.AllowUserToDeleteRows = false;
            this.gridOrderPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderPagamento.Location = new System.Drawing.Point(-4, 9);
            this.gridOrderPagamento.Name = "gridOrderPagamento";
            this.gridOrderPagamento.ReadOnly = true;
            this.gridOrderPagamento.RowHeadersVisible = false;
            this.gridOrderPagamento.RowHeadersWidth = 51;
            this.gridOrderPagamento.RowTemplate.Height = 24;
            this.gridOrderPagamento.Size = new System.Drawing.Size(1326, 470);
            this.gridOrderPagamento.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridOrderGatilho);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1466, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gatilhos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridOrderGatilho
            // 
            this.gridOrderGatilho.AllowUserToAddRows = false;
            this.gridOrderGatilho.AllowUserToDeleteRows = false;
            this.gridOrderGatilho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderGatilho.Location = new System.Drawing.Point(-4, 9);
            this.gridOrderGatilho.Name = "gridOrderGatilho";
            this.gridOrderGatilho.ReadOnly = true;
            this.gridOrderGatilho.RowHeadersVisible = false;
            this.gridOrderGatilho.RowHeadersWidth = 51;
            this.gridOrderGatilho.RowTemplate.Height = 24;
            this.gridOrderGatilho.Size = new System.Drawing.Size(1326, 470);
            this.gridOrderGatilho.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txQtdConfPagto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 686);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo das transações";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(781, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Qtde. Sem Transação:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qtde. Prev. Pagto:";
            // 
            // txQtdConfPagto
            // 
            this.txQtdConfPagto.Location = new System.Drawing.Point(242, 35);
            this.txQtdConfPagto.Name = "txQtdConfPagto";
            this.txQtdConfPagto.ReadOnly = true;
            this.txQtdConfPagto.Size = new System.Drawing.Size(100, 22);
            this.txQtdConfPagto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qtde. Conf. Pagto:";
            // 
            // progressBarImportarTransacao
            // 
            this.progressBarImportarTransacao.Location = new System.Drawing.Point(958, 718);
            this.progressBarImportarTransacao.Name = "progressBarImportarTransacao";
            this.progressBarImportarTransacao.Size = new System.Drawing.Size(380, 23);
            this.progressBarImportarTransacao.TabIndex = 10;
            // 
            // ConsultarPedidoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1498, 798);
            this.Controls.Add(this.progressBarImportarTransacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "ConsultarPedidoFinanceiro";
            this.Text = "Consultar pedido no financeiro";
            this.Load += new System.EventHandler(this.ConsultarPedidoFinanceiro_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.progressBarImportarTransacao, 0);
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.contextMenuStripConsultaPedidoGetnet.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderFinanceiro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderPagamento)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderGatilho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txOrderId;
        private System.Windows.Forms.Button btPesquisarOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConsultaPedidoGetnet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridOrderFinanceiro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridOrderPagamento;
        private System.Windows.Forms.DataGridView gridOrderGatilho;
        private System.Windows.Forms.Button btImportarLote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txQtdConfPagto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarImportarTransacao;
    }
}
