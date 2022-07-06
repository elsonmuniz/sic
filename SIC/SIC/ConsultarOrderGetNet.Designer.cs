namespace SIC
{
    partial class ConsultarOrderGetNet
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
            this.btConsultarEmLote = new System.Windows.Forms.Button();
            this.cbBandeira = new System.Windows.Forms.ComboBox();
            this.lbBandeira = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txIdCompra = new System.Windows.Forms.TextBox();
            this.btPesquisarSKU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSeller
            // 
            this.gridSeller.AllowUserToAddRows = false;
            this.gridSeller.AllowUserToDeleteRows = false;
            this.gridSeller.AllowUserToOrderColumns = true;
            this.gridSeller.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeller.Location = new System.Drawing.Point(15, 213);
            this.gridSeller.Name = "gridSeller";
            this.gridSeller.ReadOnly = true;
            this.gridSeller.RowHeadersVisible = false;
            this.gridSeller.RowHeadersWidth = 51;
            this.gridSeller.RowTemplate.Height = 24;
            this.gridSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridSeller.Size = new System.Drawing.Size(1200, 477);
            this.gridSeller.TabIndex = 8;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.btConsultarEmLote);
            this.groupBoxSeller.Controls.Add(this.cbBandeira);
            this.groupBoxSeller.Controls.Add(this.lbBandeira);
            this.groupBoxSeller.Controls.Add(this.label3);
            this.groupBoxSeller.Controls.Add(this.txIdCompra);
            this.groupBoxSeller.Controls.Add(this.btPesquisarSKU);
            this.groupBoxSeller.Location = new System.Drawing.Point(18, 78);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(1049, 119);
            this.groupBoxSeller.TabIndex = 7;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consulta status de pedido na getnet";
            // 
            // btConsultarEmLote
            // 
            this.btConsultarEmLote.Location = new System.Drawing.Point(752, 49);
            this.btConsultarEmLote.Name = "btConsultarEmLote";
            this.btConsultarEmLote.Size = new System.Drawing.Size(164, 38);
            this.btConsultarEmLote.TabIndex = 14;
            this.btConsultarEmLote.Text = "Consultar em lote";
            this.btConsultarEmLote.UseVisualStyleBackColor = true;
            this.btConsultarEmLote.Click += new System.EventHandler(this.btConsultarEmLote_Click);
            // 
            // cbBandeira
            // 
            this.cbBandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBandeira.FormattingEnabled = true;
            this.cbBandeira.Items.AddRange(new object[] {
            "2- Extra",
            "3 - Casas Bahia",
            "4 - Ponto Frio"});
            this.cbBandeira.Location = new System.Drawing.Point(101, 33);
            this.cbBandeira.Name = "cbBandeira";
            this.cbBandeira.Size = new System.Drawing.Size(345, 24);
            this.cbBandeira.TabIndex = 0;
            this.cbBandeira.Visible = false;
            // 
            // lbBandeira
            // 
            this.lbBandeira.AutoSize = true;
            this.lbBandeira.Location = new System.Drawing.Point(21, 36);
            this.lbBandeira.Name = "lbBandeira";
            this.lbBandeira.Size = new System.Drawing.Size(65, 16);
            this.lbBandeira.TabIndex = 13;
            this.lbBandeira.Text = "Bandeira:";
            this.lbBandeira.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pedido:";
            // 
            // txIdCompra
            // 
            this.txIdCompra.Location = new System.Drawing.Point(101, 80);
            this.txIdCompra.Name = "txIdCompra";
            this.txIdCompra.Size = new System.Drawing.Size(345, 22);
            this.txIdCompra.TabIndex = 1;
            // 
            // btPesquisarSKU
            // 
            this.btPesquisarSKU.Location = new System.Drawing.Point(583, 49);
            this.btPesquisarSKU.Name = "btPesquisarSKU";
            this.btPesquisarSKU.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarSKU.TabIndex = 0;
            this.btPesquisarSKU.Text = "Pesquisar";
            this.btPesquisarSKU.UseVisualStyleBackColor = true;
            this.btPesquisarSKU.Click += new System.EventHandler(this.btPesquisarSKU_Click);
            // 
            // ConsultarOrderGetNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1233, 718);
            this.Controls.Add(this.gridSeller);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "ConsultarOrderGetNet";
            this.Text = "Consulta pedido na GetNet";
            this.Load += new System.EventHandler(this.ConsultarOrderGetNet_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSeller, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeller)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSeller;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.TextBox txIdCompra;
        private System.Windows.Forms.Button btPesquisarSKU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBandeira;
        private System.Windows.Forms.Label lbBandeira;
        private System.Windows.Forms.Button btConsultarEmLote;
    }
}
