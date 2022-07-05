namespace SIC
{
    partial class AjustesLote
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
            this.btImportar = new System.Windows.Forms.Button();
            this.rtbImportarLoteAjuste = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(342, 580);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(98, 36);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(114, 580);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(98, 36);
            this.btImportar.TabIndex = 4;
            this.btImportar.Text = "Importar";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // rtbImportarLoteAjuste
            // 
            this.rtbImportarLoteAjuste.Location = new System.Drawing.Point(21, 79);
            this.rtbImportarLoteAjuste.Name = "rtbImportarLoteAjuste";
            this.rtbImportarLoteAjuste.Size = new System.Drawing.Size(553, 491);
            this.rtbImportarLoteAjuste.TabIndex = 3;
            this.rtbImportarLoteAjuste.Text = "";
            // 
            // AjustesLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(593, 630);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.rtbImportarLoteAjuste);
            this.Name = "AjustesLote";
            this.Text = "Consulta ajustes em lote";
            this.Load += new System.EventHandler(this.AjustesLote_Load);
            this.Controls.SetChildIndex(this.rtbImportarLoteAjuste, 0);
            this.Controls.SetChildIndex(this.btImportar, 0);
            this.Controls.SetChildIndex(this.btFechar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.RichTextBox rtbImportarLoteAjuste;
    }
}
