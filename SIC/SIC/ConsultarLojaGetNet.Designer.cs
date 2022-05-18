namespace SIC
{
    partial class ConsultarLojaGetNet
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
            this.gridLojistaAdquirente = new System.Windows.Forms.DataGridView();
            this.contextMenuStripConsultaLojistaGetnet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.rbIdLojista = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridLojistaAdquirente)).BeginInit();
            this.contextMenuStripConsultaLojistaGetnet.SuspendLayout();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLojistaAdquirente
            // 
            this.gridLojistaAdquirente.AllowUserToAddRows = false;
            this.gridLojistaAdquirente.AllowUserToDeleteRows = false;
            this.gridLojistaAdquirente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLojistaAdquirente.ContextMenuStrip = this.contextMenuStripConsultaLojistaGetnet;
            this.gridLojistaAdquirente.Location = new System.Drawing.Point(39, 199);
            this.gridLojistaAdquirente.Name = "gridLojistaAdquirente";
            this.gridLojistaAdquirente.ReadOnly = true;
            this.gridLojistaAdquirente.RowHeadersVisible = false;
            this.gridLojistaAdquirente.RowHeadersWidth = 51;
            this.gridLojistaAdquirente.RowTemplate.Height = 24;
            this.gridLojistaAdquirente.Size = new System.Drawing.Size(1234, 416);
            this.gridLojistaAdquirente.TabIndex = 4;
            // 
            // contextMenuStripConsultaLojistaGetnet
            // 
            this.contextMenuStripConsultaLojistaGetnet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripConsultaLojistaGetnet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ativarLojaToolStripMenuItem1,
            this.pesquisarToolStripMenuItem,
            this.enviarEmailToolStripMenuItem});
            this.contextMenuStripConsultaLojistaGetnet.Name = "contextMenuStripSeller";
            this.contextMenuStripConsultaLojistaGetnet.Size = new System.Drawing.Size(279, 176);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(278, 22);
            this.ativarLojaToolStripMenuItem1.Text = "&Sincronizar cadastro com a Getnet";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.rbIdLojista);
            this.groupBoxSeller.Controls.Add(this.rbCNPJ);
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 64);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Pesquisar carteira do lojista na Getnet";
            // 
            // rbIdLojista
            // 
            this.rbIdLojista.AutoSize = true;
            this.rbIdLojista.Location = new System.Drawing.Point(376, 35);
            this.rbIdLojista.Name = "rbIdLojista";
            this.rbIdLojista.Size = new System.Drawing.Size(83, 20);
            this.rbIdLojista.TabIndex = 3;
            this.rbIdLojista.TabStop = true;
            this.rbIdLojista.Text = "ID Lojista";
            this.rbIdLojista.UseVisualStyleBackColor = true;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(281, 35);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(63, 20);
            this.rbCNPJ.TabIndex = 0;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(137, 74);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.ReadOnly = true;
            this.txNomeLojista.Size = new System.Drawing.Size(547, 22);
            this.txNomeLojista.TabIndex = 1;
            // 
            // txIdLojista
            // 
            this.txIdLojista.Location = new System.Drawing.Point(29, 74);
            this.txIdLojista.MaxLength = 15;
            this.txIdLojista.Name = "txIdLojista";
            this.txIdLojista.Size = new System.Drawing.Size(102, 22);
            this.txIdLojista.TabIndex = 1;
            this.txIdLojista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txIdLojista_KeyDown);
            // 
            // btPesquisarLojista
            // 
            this.btPesquisarLojista.Location = new System.Drawing.Point(710, 66);
            this.btPesquisarLojista.Name = "btPesquisarLojista";
            this.btPesquisarLojista.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarLojista.TabIndex = 0;
            this.btPesquisarLojista.Text = "Pesquisar";
            this.btPesquisarLojista.UseVisualStyleBackColor = true;
            this.btPesquisarLojista.Click += new System.EventHandler(this.btPesquisarLojista_Click);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.enviarEmailToolStripMenuItem.Text = "&Enviar e-mail";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // ConsultarLojaGetNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1285, 678);
            this.Controls.Add(this.gridLojistaAdquirente);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "ConsultarLojaGetNet";
            this.Text = "Consultar carteira Getnet";
            this.Load += new System.EventHandler(this.ConsultarLojaGetNet_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridLojistaAdquirente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridLojistaAdquirente)).EndInit();
            this.contextMenuStripConsultaLojistaGetnet.ResumeLayout(false);
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLojistaAdquirente;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.Button btPesquisarLojista;
        private System.Windows.Forms.RadioButton rbIdLojista;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConsultaLojistaGetnet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
    }
}
