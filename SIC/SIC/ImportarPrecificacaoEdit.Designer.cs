namespace SIC
{
    partial class ImportarPrecificacaoEdit
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
            this.gridSKUsAlterar = new System.Windows.Forms.DataGridView();
            this.groupBoxSeller = new System.Windows.Forms.GroupBox();
            this.btConsultarPrecoAlterado = new System.Windows.Forms.Button();
            this.lbChamado = new System.Windows.Forms.Label();
            this.lbLocalPlanilha = new System.Windows.Forms.Label();
            this.txChamado = new System.Windows.Forms.TextBox();
            this.txEnderecoPlanilha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btPesquisarPlanilha = new System.Windows.Forms.Button();
            this.txQtdeLinhas = new System.Windows.Forms.TextBox();
            this.lbQtdeLinhas = new System.Windows.Forms.Label();
            this.txQtdeSemSQKUID = new System.Windows.Forms.TextBox();
            this.lbQtdeSemSKUID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSKUsAlterar)).BeginInit();
            this.groupBoxSeller.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSKUsAlterar
            // 
            this.gridSKUsAlterar.AllowUserToAddRows = false;
            this.gridSKUsAlterar.AllowUserToDeleteRows = false;
            this.gridSKUsAlterar.AllowUserToOrderColumns = true;
            this.gridSKUsAlterar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSKUsAlterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSKUsAlterar.Location = new System.Drawing.Point(39, 225);
            this.gridSKUsAlterar.Name = "gridSKUsAlterar";
            this.gridSKUsAlterar.ReadOnly = true;
            this.gridSKUsAlterar.RowHeadersVisible = false;
            this.gridSKUsAlterar.RowHeadersWidth = 51;
            this.gridSKUsAlterar.RowTemplate.Height = 24;
            this.gridSKUsAlterar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSKUsAlterar.Size = new System.Drawing.Size(1442, 416);
            this.gridSKUsAlterar.TabIndex = 8;
            // 
            // groupBoxSeller
            // 
            this.groupBoxSeller.Controls.Add(this.btConsultarPrecoAlterado);
            this.groupBoxSeller.Controls.Add(this.lbChamado);
            this.groupBoxSeller.Controls.Add(this.lbLocalPlanilha);
            this.groupBoxSeller.Controls.Add(this.txChamado);
            this.groupBoxSeller.Controls.Add(this.txEnderecoPlanilha);
            this.groupBoxSeller.Controls.Add(this.button1);
            this.groupBoxSeller.Controls.Add(this.btPesquisarPlanilha);
            this.groupBoxSeller.Location = new System.Drawing.Point(39, 90);
            this.groupBoxSeller.Name = "groupBoxSeller";
            this.groupBoxSeller.Size = new System.Drawing.Size(1168, 119);
            this.groupBoxSeller.TabIndex = 7;
            this.groupBoxSeller.TabStop = false;
            this.groupBoxSeller.Text = "Importação de planilha para alteração de preços";
            // 
            // btConsultarPrecoAlterado
            // 
            this.btConsultarPrecoAlterado.Location = new System.Drawing.Point(229, 87);
            this.btConsultarPrecoAlterado.Name = "btConsultarPrecoAlterado";
            this.btConsultarPrecoAlterado.Size = new System.Drawing.Size(136, 29);
            this.btConsultarPrecoAlterado.TabIndex = 3;
            this.btConsultarPrecoAlterado.Text = "Consultar Chamado";
            this.btConsultarPrecoAlterado.UseVisualStyleBackColor = true;
            this.btConsultarPrecoAlterado.Click += new System.EventHandler(this.btConsultarPrecoAlterado_Click);
            // 
            // lbChamado
            // 
            this.lbChamado.AutoSize = true;
            this.lbChamado.Location = new System.Drawing.Point(34, 97);
            this.lbChamado.Name = "lbChamado";
            this.lbChamado.Size = new System.Drawing.Size(69, 16);
            this.lbChamado.TabIndex = 2;
            this.lbChamado.Text = "Chamado:";
            // 
            // lbLocalPlanilha
            // 
            this.lbLocalPlanilha.AutoSize = true;
            this.lbLocalPlanilha.Location = new System.Drawing.Point(17, 42);
            this.lbLocalPlanilha.Name = "lbLocalPlanilha";
            this.lbLocalPlanilha.Size = new System.Drawing.Size(86, 32);
            this.lbLocalPlanilha.TabIndex = 2;
            this.lbLocalPlanilha.Text = "Informe local \r\nda planilha:";
            // 
            // txChamado
            // 
            this.txChamado.Location = new System.Drawing.Point(113, 91);
            this.txChamado.MaxLength = 12;
            this.txChamado.Name = "txChamado";
            this.txChamado.Size = new System.Drawing.Size(100, 22);
            this.txChamado.TabIndex = 1;
            // 
            // txEnderecoPlanilha
            // 
            this.txEnderecoPlanilha.Location = new System.Drawing.Point(113, 50);
            this.txEnderecoPlanilha.Name = "txEnderecoPlanilha";
            this.txEnderecoPlanilha.Size = new System.Drawing.Size(580, 22);
            this.txEnderecoPlanilha.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alterar Preço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btPesquisarPlanilha_Click);
            // 
            // btPesquisarPlanilha
            // 
            this.btPesquisarPlanilha.Location = new System.Drawing.Point(719, 42);
            this.btPesquisarPlanilha.Name = "btPesquisarPlanilha";
            this.btPesquisarPlanilha.Size = new System.Drawing.Size(135, 38);
            this.btPesquisarPlanilha.TabIndex = 0;
            this.btPesquisarPlanilha.Text = "Importar Planilha";
            this.btPesquisarPlanilha.UseVisualStyleBackColor = true;
            this.btPesquisarPlanilha.Click += new System.EventHandler(this.btPesquisarPlanilha_Click);
            // 
            // txQtdeLinhas
            // 
            this.txQtdeLinhas.Location = new System.Drawing.Point(135, 661);
            this.txQtdeLinhas.MaxLength = 12;
            this.txQtdeLinhas.Name = "txQtdeLinhas";
            this.txQtdeLinhas.ReadOnly = true;
            this.txQtdeLinhas.Size = new System.Drawing.Size(100, 22);
            this.txQtdeLinhas.TabIndex = 1;
            // 
            // lbQtdeLinhas
            // 
            this.lbQtdeLinhas.AutoSize = true;
            this.lbQtdeLinhas.Location = new System.Drawing.Point(41, 664);
            this.lbQtdeLinhas.Name = "lbQtdeLinhas";
            this.lbQtdeLinhas.Size = new System.Drawing.Size(77, 16);
            this.lbQtdeLinhas.TabIndex = 2;
            this.lbQtdeLinhas.Text = "Qtde linhas:";
            // 
            // txQtdeSemSQKUID
            // 
            this.txQtdeSemSQKUID.Location = new System.Drawing.Point(396, 661);
            this.txQtdeSemSQKUID.MaxLength = 12;
            this.txQtdeSemSQKUID.Name = "txQtdeSemSQKUID";
            this.txQtdeSemSQKUID.ReadOnly = true;
            this.txQtdeSemSQKUID.Size = new System.Drawing.Size(100, 22);
            this.txQtdeSemSQKUID.TabIndex = 1;
            // 
            // lbQtdeSemSKUID
            // 
            this.lbQtdeSemSKUID.AutoSize = true;
            this.lbQtdeSemSKUID.Location = new System.Drawing.Point(276, 664);
            this.lbQtdeSemSKUID.Name = "lbQtdeSemSKUID";
            this.lbQtdeSemSKUID.Size = new System.Drawing.Size(114, 16);
            this.lbQtdeSemSKUID.TabIndex = 2;
            this.lbQtdeSemSKUID.Text = "Qtde sem SKU ID:";
            // 
            // ImportarPrecificacaoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1493, 713);
            this.Controls.Add(this.lbQtdeSemSKUID);
            this.Controls.Add(this.lbQtdeLinhas);
            this.Controls.Add(this.gridSKUsAlterar);
            this.Controls.Add(this.groupBoxSeller);
            this.Controls.Add(this.txQtdeSemSQKUID);
            this.Controls.Add(this.txQtdeLinhas);
            this.Name = "ImportarPrecificacaoEdit";
            this.Text = "Importar planilha de preços do seller";
            this.Load += new System.EventHandler(this.ImportarPrecificacaoEdit_Load);
            this.Controls.SetChildIndex(this.txQtdeLinhas, 0);
            this.Controls.SetChildIndex(this.txQtdeSemSQKUID, 0);
            this.Controls.SetChildIndex(this.groupBoxSeller, 0);
            this.Controls.SetChildIndex(this.gridSKUsAlterar, 0);
            this.Controls.SetChildIndex(this.lbQtdeLinhas, 0);
            this.Controls.SetChildIndex(this.lbQtdeSemSKUID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridSKUsAlterar)).EndInit();
            this.groupBoxSeller.ResumeLayout(false);
            this.groupBoxSeller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSKUsAlterar;
        private System.Windows.Forms.GroupBox groupBoxSeller;
        private System.Windows.Forms.Label lbLocalPlanilha;
        private System.Windows.Forms.TextBox txEnderecoPlanilha;
        private System.Windows.Forms.Button btPesquisarPlanilha;
        private System.Windows.Forms.Label lbChamado;
        private System.Windows.Forms.TextBox txChamado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txQtdeLinhas;
        private System.Windows.Forms.Label lbQtdeLinhas;
        private System.Windows.Forms.TextBox txQtdeSemSQKUID;
        private System.Windows.Forms.Label lbQtdeSemSKUID;
        private System.Windows.Forms.Button btConsultarPrecoAlterado;
    }
}
