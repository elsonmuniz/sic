namespace SIC
{
    partial class ImportarTransacaoLote
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btImportar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBarImportarPedido = new System.Windows.Forms.ProgressBar();
            this.lbImportandoPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 442);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(146, 563);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(98, 36);
            this.btImportar.TabIndex = 1;
            this.btImportar.Text = "Importar";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBarImportarPedido
            // 
            this.progressBarImportarPedido.Location = new System.Drawing.Point(144, 621);
            this.progressBarImportarPedido.Name = "progressBarImportarPedido";
            this.progressBarImportarPedido.Size = new System.Drawing.Size(309, 23);
            this.progressBarImportarPedido.TabIndex = 6;
            this.progressBarImportarPedido.Visible = false;
            // 
            // lbImportandoPedido
            // 
            this.lbImportandoPedido.AutoSize = true;
            this.lbImportandoPedido.Location = new System.Drawing.Point(240, 602);
            this.lbImportandoPedido.Name = "lbImportandoPedido";
            this.lbImportandoPedido.Size = new System.Drawing.Size(0, 16);
            this.lbImportandoPedido.TabIndex = 7;
            // 
            // ImportarTransacaoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(610, 656);
            this.Controls.Add(this.lbImportandoPedido);
            this.Controls.Add(this.progressBarImportarPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ImportarTransacaoLote";
            this.Text = "Importar pedido em lote";
            this.Load += new System.EventHandler(this.ImportarTransacaoLote_Load);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.btImportar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.progressBarImportarPedido, 0);
            this.Controls.SetChildIndex(this.lbImportandoPedido, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBarImportarPedido;
        private System.Windows.Forms.Label lbImportandoPedido;
    }
}
