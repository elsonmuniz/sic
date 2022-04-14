namespace SIC
{
    partial class MpCompras
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
            this.gridSeller = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.btPesquisarLojista = new System.Windows.Forms.Button();
            this.lstbDados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSeller
            // 
            this.gridSeller.AllowUserToAddRows = false;
            this.gridSeller.AllowUserToDeleteRows = false;
            this.gridSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeller.Location = new System.Drawing.Point(39, 199);
            this.gridSeller.Name = "gridSeller";
            this.gridSeller.ReadOnly = true;
            this.gridSeller.RowHeadersVisible = false;
            this.gridSeller.RowHeadersWidth = 51;
            this.gridSeller.RowTemplate.Height = 24;
            this.gridSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSeller.Size = new System.Drawing.Size(880, 103);
            this.gridSeller.TabIndex = 4;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.txNomeLojista);
            this.groupBoxSeller.Controls.Add(this.txIdLojista);
            this.groupBoxSeller.Controls.Add(this.btPesquisarLojista);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 42);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(880, 103);
            this.groupBoxSeller.TabIndex = 3;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consulta pedido no MP-Compras";
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
            this.txIdLojista.MaxLength = 15;
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
            // lstbDados
            // 
            this.lstbDados.FormattingEnabled = true;
            this.lstbDados.ItemHeight = 16;
            this.lstbDados.Location = new System.Drawing.Point(39, 329);
            this.lstbDados.Margin = new System.Windows.Forms.Padding(4);
            this.lstbDados.Name = "lstbDados";
            this.lstbDados.Size = new System.Drawing.Size(453, 148);
            this.lstbDados.TabIndex = 5;
            // 
            // MpCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(958, 678);
            this.Controls.Add(this.lstbDados);
            this.Controls.Add(this.gridSeller);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "MpCompras";
            this.Text = "Consultar Pedido - MPCompras";
            this.Load += new System.EventHandler(this.MpCompras_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSeller, 0);
            this.Controls.SetChildIndex(this.lstbDados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSeller;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.Button btPesquisarLojista;
        private System.Windows.Forms.ListBox lstbDados;
    }
}
