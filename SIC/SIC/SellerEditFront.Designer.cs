namespace SIC
{
    partial class SellerEditFront
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
            this.gridSellerFront = new System.Windows.Forms.DataGridView();
            this.contextMenuStripSellerFront = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativarLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellerFront)).BeginInit();
            this.contextMenuStripSellerFront.SuspendLayout();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSellerFront
            // 
            this.gridSellerFront.AllowUserToAddRows = false;
            this.gridSellerFront.AllowUserToDeleteRows = false;
            this.gridSellerFront.AllowUserToOrderColumns = true;
            this.gridSellerFront.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSellerFront.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSellerFront.ContextMenuStrip = this.contextMenuStripSellerFront;
            this.gridSellerFront.Location = new System.Drawing.Point(39, 236);
            this.gridSellerFront.Name = "gridSellerFront";
            this.gridSellerFront.ReadOnly = true;
            this.gridSellerFront.RowHeadersVisible = false;
            this.gridSellerFront.RowHeadersWidth = 51;
            this.gridSellerFront.RowTemplate.Height = 24;
            this.gridSellerFront.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSellerFront.Size = new System.Drawing.Size(880, 416);
            this.gridSellerFront.TabIndex = 4;
            // 
            // contextMenuStripSellerFront
            // 
            this.contextMenuStripSellerFront.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSellerFront.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ativarLojaToolStripMenuItem1,
            this.pesquisarToolStripMenuItem});
            this.contextMenuStripSellerFront.Name = "contextMenuStripSeller";
            this.contextMenuStripSellerFront.Size = new System.Drawing.Size(138, 126);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // ativarLojaToolStripMenuItem1
            // 
            this.ativarLojaToolStripMenuItem1.Name = "ativarLojaToolStripMenuItem1";
            this.ativarLojaToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.ativarLojaToolStripMenuItem1.Text = "Ativar Loja";
            this.ativarLojaToolStripMenuItem1.Click += new System.EventHandler(this.ativarLojaToolStripMenuItem1_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 101);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Pesquisar lojista do lado do FRONT";
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
            // SellerEditFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(958, 678);
            this.Controls.Add(this.gridSellerFront);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "SellerEditFront";
            this.Text = "Pesquisar Lojista Front";
            this.Load += new System.EventHandler(this.SellerEditFront_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSellerFront, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSellerFront)).EndInit();
            this.contextMenuStripSellerFront.ResumeLayout(false);
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSellerFront;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.Button btPesquisarLojista;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSellerFront;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ativarLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
    }
}
