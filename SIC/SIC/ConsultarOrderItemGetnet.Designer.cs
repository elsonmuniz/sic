namespace SIC
{
    partial class ConsultarOrderItemGetnet
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
            this.gridOrderItem = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.btConsultarEmLote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txIdCompra = new System.Windows.Forms.TextBox();
            this.btPesquisarOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderItem)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrderItem
            // 
            this.gridOrderItem.AllowUserToAddRows = false;
            this.gridOrderItem.AllowUserToDeleteRows = false;
            this.gridOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderItem.Location = new System.Drawing.Point(12, 216);
            this.gridOrderItem.Name = "gridOrderItem";
            this.gridOrderItem.ReadOnly = true;
            this.gridOrderItem.RowHeadersVisible = false;
            this.gridOrderItem.RowHeadersWidth = 51;
            this.gridOrderItem.RowTemplate.Height = 24;
            this.gridOrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridOrderItem.Size = new System.Drawing.Size(1200, 477);
            this.gridOrderItem.TabIndex = 10;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.btConsultarEmLote);
            this.groupBoxSeller.Controls.Add(this.label3);
            this.groupBoxSeller.Controls.Add(this.txIdCompra);
            this.groupBoxSeller.Controls.Add(this.btPesquisarOrder);
            this.groupBoxSeller.Location = new System.Drawing.Point(15, 81);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(1049, 119);
            this.groupBoxSeller.TabIndex = 9;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Consulta status de pedido na getnet";
            // 
            // btConsultarEmLote
            // 
            this.btConsultarEmLote.Location = new System.Drawing.Point(754, 49);
            this.btConsultarEmLote.Name = "btConsultarEmLote";
            this.btConsultarEmLote.Size = new System.Drawing.Size(154, 38);
            this.btConsultarEmLote.TabIndex = 14;
            this.btConsultarEmLote.Text = "Consultar em lote";
            this.btConsultarEmLote.UseVisualStyleBackColor = true;
            this.btConsultarEmLote.Click += new System.EventHandler(this.btConsultarEmLote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pedido:";
            // 
            // txIdCompra
            // 
            this.txIdCompra.Location = new System.Drawing.Point(103, 57);
            this.txIdCompra.Name = "txIdCompra";
            this.txIdCompra.Size = new System.Drawing.Size(345, 22);
            this.txIdCompra.TabIndex = 1;
            // 
            // btPesquisarOrder
            // 
            this.btPesquisarOrder.Location = new System.Drawing.Point(583, 49);
            this.btPesquisarOrder.Name = "btPesquisarOrder";
            this.btPesquisarOrder.Size = new System.Drawing.Size(119, 38);
            this.btPesquisarOrder.TabIndex = 0;
            this.btPesquisarOrder.Text = "Pesquisar";
            this.btPesquisarOrder.UseVisualStyleBackColor = true;
            // 
            // ConsultarOrderItemGetnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1225, 728);
            this.Controls.Add(this.gridOrderItem);
            this.Controls.Add(this.groupBoxSeller);
            this.Name = "ConsultarOrderItemGetnet";
            this.Text = "Consultar item liberado na Getnet";
            this.Load += new System.EventHandler(this.ConsultarOrderItemGetnet_Load);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridOrderItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderItem)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderItem;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.Button btConsultarEmLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txIdCompra;
        private System.Windows.Forms.Button btPesquisarOrder;
    }
}
