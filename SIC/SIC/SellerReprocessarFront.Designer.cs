namespace SIC
{
    partial class SellerReprocessarFront
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
            this.contextMenuStripSeller = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridSeller = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.contextMenuStripSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripSeller
            // 
            this.contextMenuStripSeller.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSeller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ativarLojaToolStripMenuItem1,
            this.pesquisarToolStripMenuItem});
            this.contextMenuStripSeller.Name = "contextMenuStripSeller";
            this.contextMenuStripSeller.Size = new System.Drawing.Size(183, 126);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.ativarLojaToolStripMenuItem1.Text = "&Reprocessar Loja";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // gridSeller
            // 
            this.gridSeller.AllowUserToAddRows = false;
            this.gridSeller.AllowUserToDeleteRows = false;
            this.gridSeller.AllowUserToOrderColumns = true;
            this.gridSeller.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeller.ContextMenuStrip = this.contextMenuStripSeller;
            this.gridSeller.Location = new System.Drawing.Point(39, 220);
            this.gridSeller.Name = "gridSeller";
            this.gridSeller.ReadOnly = true;
            this.gridSeller.RowHeadersVisible = false;
            this.gridSeller.RowHeadersWidth = 51;
            this.gridSeller.RowTemplate.Height = 24;
            this.gridSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSeller.Size = new System.Drawing.Size(1304, 416);
            this.gridSeller.TabIndex = 4;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 85);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Reprocessamento de loja para o Front";
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
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbMessage.Location = new System.Drawing.Point(1000, 107);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(212, 50);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "Aguarde...\r\nReprocessamento Loja";
            // 
            // SellerReprocessarFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1367, 678);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.gridSeller);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "SellerReprocessarFront";
            this.Text = "Reprocessar loja para o Front";
            this.Load += new System.EventHandler(this.SellerReprocessarFront_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSeller, 0);
            this.Controls.SetChildIndex(this.lbMessage, 0);
            this.contextMenuStripSeller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripSeller;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridSeller;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.Button btPesquisarLojista;
        public System.Windows.Forms.Label lbMessage;
    }
}
