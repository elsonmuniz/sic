namespace SIC
{
    partial class ConsultarLojaGetNetLote
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
            this.btFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(553, 491);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(119, 550);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(98, 36);
            this.btImportar.TabIndex = 1;
            this.btImportar.Text = "Importar";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(347, 550);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(98, 36);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            // 
            // ConsultarLojaGetNetLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(629, 612);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ConsultarLojaGetNetLote";
            this.Text = "Importar CNPJ em lote";
            this.Load += new System.EventHandler(this.ConsultarLojaGetNetLote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.Button btFechar;
    }
}
