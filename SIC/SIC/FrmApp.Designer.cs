namespace SIC
{
    partial class FrmApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLojaAtivaADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLojaFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprocessarLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.getNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKUNãoConstaNoFRONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKUAtivoComVarianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKUConsultarIntegraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKUErroIntegraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKURelatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarPlanilhaPrecificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compararPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPCoprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrderGetNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidoCanceladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellerToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.toolStripSeparator4,
            this.financeiroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.arquivosToolStripMenuItem.Text = "&Arquivos";
            // 
            // sellerToolStripMenuItem
            // 
            this.sellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLojaAtivaADToolStripMenuItem,
            this.consultarLojaFrontToolStripMenuItem,
            this.reprocessarLojaToolStripMenuItem,
            this.toolStripSeparator3,
            this.getNetToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
            this.sellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sellerToolStripMenuItem.Text = "&Seller";
            this.sellerToolStripMenuItem.Click += new System.EventHandler(this.sellerToolStripMenuItem_Click);
            // 
            // consultarLojaAtivaADToolStripMenuItem
            // 
            this.consultarLojaAtivaADToolStripMenuItem.Name = "consultarLojaAtivaADToolStripMenuItem";
            this.consultarLojaAtivaADToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.consultarLojaAtivaADToolStripMenuItem.Text = "&Consultar Loja - AD";
            this.consultarLojaAtivaADToolStripMenuItem.Click += new System.EventHandler(this.consultarLojaAtivaADToolStripMenuItem_Click);
            // 
            // consultarLojaFrontToolStripMenuItem
            // 
            this.consultarLojaFrontToolStripMenuItem.Name = "consultarLojaFrontToolStripMenuItem";
            this.consultarLojaFrontToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.consultarLojaFrontToolStripMenuItem.Text = "&Consultar Loja - Front";
            this.consultarLojaFrontToolStripMenuItem.Click += new System.EventHandler(this.consultarLojaFrontToolStripMenuItem_Click);
            // 
            // reprocessarLojaToolStripMenuItem
            // 
            this.reprocessarLojaToolStripMenuItem.Name = "reprocessarLojaToolStripMenuItem";
            this.reprocessarLojaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.reprocessarLojaToolStripMenuItem.Text = "&Reprocessar Loja";
            this.reprocessarLojaToolStripMenuItem.Click += new System.EventHandler(this.reprocessarLojaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // getNetToolStripMenuItem
            // 
            this.getNetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLojaToolStripMenuItem});
            this.getNetToolStripMenuItem.Name = "getNetToolStripMenuItem";
            this.getNetToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.getNetToolStripMenuItem.Text = "&GetNet";
            // 
            // consultarLojaToolStripMenuItem
            // 
            this.consultarLojaToolStripMenuItem.Name = "consultarLojaToolStripMenuItem";
            this.consultarLojaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.consultarLojaToolStripMenuItem.Text = "&Consultar carteira";
            this.consultarLojaToolStripMenuItem.Click += new System.EventHandler(this.consultarLojaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sKUNãoConstaNoFRONTToolStripMenuItem,
            this.sKUAtivoComVarianteToolStripMenuItem,
            this.sKUConsultarIntegraçãoToolStripMenuItem,
            this.sKUErroIntegraçãoToolStripMenuItem,
            this.sKURelatedToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarPlanilhaPrecificaçãoToolStripMenuItem,
            this.toolStripSeparator2,
            this.compararPreçoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // sKUNãoConstaNoFRONTToolStripMenuItem
            // 
            this.sKUNãoConstaNoFRONTToolStripMenuItem.Name = "sKUNãoConstaNoFRONTToolStripMenuItem";
            this.sKUNãoConstaNoFRONTToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sKUNãoConstaNoFRONTToolStripMenuItem.Text = "&Produtos com ficha não integrada";
            this.sKUNãoConstaNoFRONTToolStripMenuItem.Click += new System.EventHandler(this.sKUNãoConstaNoFRONTToolStripMenuItem_Click);
            // 
            // sKUAtivoComVarianteToolStripMenuItem
            // 
            this.sKUAtivoComVarianteToolStripMenuItem.Name = "sKUAtivoComVarianteToolStripMenuItem";
            this.sKUAtivoComVarianteToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sKUAtivoComVarianteToolStripMenuItem.Text = "SKU Ativo com variante";
            this.sKUAtivoComVarianteToolStripMenuItem.Click += new System.EventHandler(this.sKUAtivoComVarianteToolStripMenuItem_Click);
            // 
            // sKUConsultarIntegraçãoToolStripMenuItem
            // 
            this.sKUConsultarIntegraçãoToolStripMenuItem.Name = "sKUConsultarIntegraçãoToolStripMenuItem";
            this.sKUConsultarIntegraçãoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sKUConsultarIntegraçãoToolStripMenuItem.Text = "SKU Consultar integração ";
            this.sKUConsultarIntegraçãoToolStripMenuItem.Click += new System.EventHandler(this.sKUConsultarIntegraçãoToolStripMenuItem_Click);
            // 
            // sKUErroIntegraçãoToolStripMenuItem
            // 
            this.sKUErroIntegraçãoToolStripMenuItem.Name = "sKUErroIntegraçãoToolStripMenuItem";
            this.sKUErroIntegraçãoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sKUErroIntegraçãoToolStripMenuItem.Text = "SKU Erro integração";
            this.sKUErroIntegraçãoToolStripMenuItem.Click += new System.EventHandler(this.sKUErroIntegraçãoToolStripMenuItem_Click);
            // 
            // sKURelatedToolStripMenuItem
            // 
            this.sKURelatedToolStripMenuItem.Name = "sKURelatedToolStripMenuItem";
            this.sKURelatedToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.sKURelatedToolStripMenuItem.Text = "&SKU Related";
            this.sKURelatedToolStripMenuItem.Click += new System.EventHandler(this.sKURelatedToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // importarPlanilhaPrecificaçãoToolStripMenuItem
            // 
            this.importarPlanilhaPrecificaçãoToolStripMenuItem.Name = "importarPlanilhaPrecificaçãoToolStripMenuItem";
            this.importarPlanilhaPrecificaçãoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.importarPlanilhaPrecificaçãoToolStripMenuItem.Text = "Importar Planilha Precificação";
            this.importarPlanilhaPrecificaçãoToolStripMenuItem.Click += new System.EventHandler(this.importarPlanilhaPrecificaçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // compararPreçoToolStripMenuItem
            // 
            this.compararPreçoToolStripMenuItem.Name = "compararPreçoToolStripMenuItem";
            this.compararPreçoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.compararPreçoToolStripMenuItem.Text = "&Comparar Preço";
            this.compararPreçoToolStripMenuItem.Click += new System.EventHandler(this.compararPreçoToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPCoprasToolStripMenuItem,
            this.consultarOrderGetNetToolStripMenuItem,
            this.consultarPedidoCanceladosToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // mPCoprasToolStripMenuItem
            // 
            this.mPCoprasToolStripMenuItem.Name = "mPCoprasToolStripMenuItem";
            this.mPCoprasToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.mPCoprasToolStripMenuItem.Text = "&MP-Compras";
            this.mPCoprasToolStripMenuItem.Click += new System.EventHandler(this.mPCoprasToolStripMenuItem_Click);
            // 
            // consultarOrderGetNetToolStripMenuItem
            // 
            this.consultarOrderGetNetToolStripMenuItem.Name = "consultarOrderGetNetToolStripMenuItem";
            this.consultarOrderGetNetToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.consultarOrderGetNetToolStripMenuItem.Text = "&Consultar pagamento cancelado - Getnet";
            this.consultarOrderGetNetToolStripMenuItem.Click += new System.EventHandler(this.consultarOrderGetNetToolStripMenuItem_Click);
            // 
            // consultarPedidoCanceladosToolStripMenuItem
            // 
            this.consultarPedidoCanceladosToolStripMenuItem.Name = "consultarPedidoCanceladosToolStripMenuItem";
            this.consultarPedidoCanceladosToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.consultarPedidoCanceladosToolStripMenuItem.Text = "&Consultar item entregues - Getnet";
            this.consultarPedidoCanceladosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidoCanceladosToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPedidoToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.financeiroToolStripMenuItem.Text = "&Financeiro";
            // 
            // consultarPedidoToolStripMenuItem
            // 
            this.consultarPedidoToolStripMenuItem.Name = "consultarPedidoToolStripMenuItem";
            this.consultarPedidoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.consultarPedidoToolStripMenuItem.Text = "&Consultar pedido";
            this.consultarPedidoToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.exibirToolStripMenuItem.Text = "&Exibir";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusData,
            this.toolStripStatusUsuario,
            this.toolStripStatusVersao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 744);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 600, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(600, 16);
            // 
            // toolStripStatusData
            // 
            this.toolStripStatusData.Name = "toolStripStatusData";
            this.toolStripStatusData.Size = new System.Drawing.Size(39, 16);
            this.toolStripStatusData.Text = "Data:";
            // 
            // toolStripStatusUsuario
            // 
            this.toolStripStatusUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            this.toolStripStatusUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusUsuario.Size = new System.Drawing.Size(60, 16);
            this.toolStripStatusUsuario.Text = "Usuário: ";
            this.toolStripStatusUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusUsuario.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusVersao
            // 
            this.toolStripStatusVersao.Name = "toolStripStatusVersao";
            this.toolStripStatusVersao.Size = new System.Drawing.Size(51, 16);
            this.toolStripStatusVersao.Text = "Versão";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // FrmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1121, 766);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmApp";
            this.Load += new System.EventHandler(this.FrmApp_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLojaAtivaADToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusVersao;
        private System.Windows.Forms.ToolStripMenuItem consultarLojaFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprocessarLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKUNãoConstaNoFRONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mPCoprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKUAtivoComVarianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKUConsultarIntegraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKUErroIntegraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarPlanilhaPrecificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem compararPreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKURelatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrderGetNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem getNetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidoCanceladosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}
