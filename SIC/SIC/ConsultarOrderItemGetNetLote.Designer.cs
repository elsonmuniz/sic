namespace SIC
{
    partial class ConsultarOrderItemGetNetLote
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
            this.btFechar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(283, 528);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(83, 528);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 467);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ConsultarOrderItemGetNetLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(656, 598);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ConsultarOrderItemGetNetLote";
            this.Text = "Importar pedido em lote";
            this.Load += new System.EventHandler(this.ConsultarOrderItemGetNetLote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
