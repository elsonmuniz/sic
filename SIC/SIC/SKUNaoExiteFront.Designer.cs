namespace SIC
{
    partial class SKUNaoExiteFront
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
            this.gridSellerFront = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellerFront)).BeginInit();
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
            this.gridSellerFront.Location = new System.Drawing.Point(39, 220);
            this.gridSellerFront.Name = "gridSellerFront";
            this.gridSellerFront.ReadOnly = true;
            this.gridSellerFront.RowHeadersVisible = false;
            this.gridSellerFront.RowHeadersWidth = 51;
            this.gridSellerFront.RowTemplate.Height = 24;
            this.gridSellerFront.Size = new System.Drawing.Size(880, 416);
            this.gridSellerFront.TabIndex = 6;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 85);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 119);
            this.groupBoxSeller.TabIndex = 5;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Informe o código do lojista";
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
            // SKUNaoExiteFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(958, 678);
            this.Controls.Add(this.gridSellerFront);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "SKUNaoExiteFront";
            this.Text = "Produtos com ficha não integradas";
            this.Load += new System.EventHandler(this.SKUNaoExiteFront_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSellerFront, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSellerFront)).EndInit();
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
    }
}
