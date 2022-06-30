namespace SIC
{
    partial class UsuarioExterno
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
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txNomePesquisa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbkSituacaoCadastral = new System.Windows.Forms.CheckBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbIdLojista = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbDataCriacao = new System.Windows.Forms.Label();
            this.lbDataModificacao = new System.Windows.Forms.Label();
            this.lbModificado = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txIdLojista = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txDataCriacao = new System.Windows.Forms.TextBox();
            this.txDataModificacao = new System.Windows.Forms.TextBox();
            this.txModificadoPor = new System.Windows.Forms.TextBox();
            this.txCNPJ = new System.Windows.Forms.TextBox();
            this.txNomeUsuario = new System.Windows.Forms.TextBox();
            this.tx_Id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Checked = true;
            this.rbEmail.Location = new System.Drawing.Point(320, 34);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(66, 20);
            this.rbEmail.TabIndex = 1;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "E-mail";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(420, 34);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(75, 20);
            this.rbUsuario.TabIndex = 2;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsuario);
            this.groupBox1.Controls.Add(this.rbEmail);
            this.groupBox1.Location = new System.Drawing.Point(36, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indique a pesquisa";
            // 
            // txNomePesquisa
            // 
            this.txNomePesquisa.Location = new System.Drawing.Point(133, 36);
            this.txNomePesquisa.Name = "txNomePesquisa";
            this.txNomePesquisa.Size = new System.Drawing.Size(233, 22);
            this.txNomePesquisa.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbkSituacaoCadastral);
            this.groupBox2.Controls.Add(this.lb_Id);
            this.groupBox2.Controls.Add(this.lbPesquisa);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.lbIdLojista);
            this.groupBox2.Controls.Add(this.lbSenha);
            this.groupBox2.Controls.Add(this.lbDataCriacao);
            this.groupBox2.Controls.Add(this.lbDataModificacao);
            this.groupBox2.Controls.Add(this.lbModificado);
            this.groupBox2.Controls.Add(this.lbCNPJ);
            this.groupBox2.Controls.Add(this.lbNomeUsuario);
            this.groupBox2.Controls.Add(this.btConsultar);
            this.groupBox2.Controls.Add(this.txEmail);
            this.groupBox2.Controls.Add(this.txUsuario);
            this.groupBox2.Controls.Add(this.txNomeLojista);
            this.groupBox2.Controls.Add(this.txIdLojista);
            this.groupBox2.Controls.Add(this.txSenha);
            this.groupBox2.Controls.Add(this.txDataCriacao);
            this.groupBox2.Controls.Add(this.txDataModificacao);
            this.groupBox2.Controls.Add(this.txModificadoPor);
            this.groupBox2.Controls.Add(this.txCNPJ);
            this.groupBox2.Controls.Add(this.txNomeUsuario);
            this.groupBox2.Controls.Add(this.tx_Id);
            this.groupBox2.Controls.Add(this.txNomePesquisa);
            this.groupBox2.Location = new System.Drawing.Point(36, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 355);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // cbkSituacaoCadastral
            // 
            this.cbkSituacaoCadastral.AutoSize = true;
            this.cbkSituacaoCadastral.Location = new System.Drawing.Point(575, 35);
            this.cbkSituacaoCadastral.Name = "cbkSituacaoCadastral";
            this.cbkSituacaoCadastral.Size = new System.Drawing.Size(146, 20);
            this.cbkSituacaoCadastral.TabIndex = 8;
            this.cbkSituacaoCadastral.Text = "Situação Cadastral:";
            this.cbkSituacaoCadastral.UseVisualStyleBackColor = true;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(104, 84);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(21, 16);
            this.lb_Id.TabIndex = 7;
            this.lb_Id.Text = "Id:";
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Location = new System.Drawing.Point(59, 42);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(67, 16);
            this.lbPesquisa.TabIndex = 7;
            this.lbPesquisa.Text = "Pesquisa:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(491, 167);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 16);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(68, 164);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbIdLojista
            // 
            this.lbIdLojista.AutoSize = true;
            this.lbIdLojista.Location = new System.Drawing.Point(59, 253);
            this.lbIdLojista.Name = "lbIdLojista";
            this.lbIdLojista.Size = new System.Drawing.Size(63, 16);
            this.lbIdLojista.TabIndex = 6;
            this.lbIdLojista.Text = "Id Lojista:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(76, 210);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 16);
            this.lbSenha.TabIndex = 6;
            this.lbSenha.Text = "Senha:";
            // 
            // lbDataCriacao
            // 
            this.lbDataCriacao.AutoSize = true;
            this.lbDataCriacao.Location = new System.Drawing.Point(322, 310);
            this.lbDataCriacao.Name = "lbDataCriacao";
            this.lbDataCriacao.Size = new System.Drawing.Size(89, 16);
            this.lbDataCriacao.TabIndex = 6;
            this.lbDataCriacao.Text = "Data Criação:";
            // 
            // lbDataModificacao
            // 
            this.lbDataModificacao.AutoSize = true;
            this.lbDataModificacao.Location = new System.Drawing.Point(6, 307);
            this.lbDataModificacao.Name = "lbDataModificacao";
            this.lbDataModificacao.Size = new System.Drawing.Size(116, 16);
            this.lbDataModificacao.TabIndex = 6;
            this.lbDataModificacao.Text = "Data Modificação:";
            // 
            // lbModificado
            // 
            this.lbModificado.AutoSize = true;
            this.lbModificado.Location = new System.Drawing.Point(550, 253);
            this.lbModificado.Name = "lbModificado";
            this.lbModificado.Size = new System.Drawing.Size(101, 16);
            this.lbModificado.TabIndex = 6;
            this.lbModificado.Text = "Modificado Por:";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(572, 207);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(45, 16);
            this.lbCNPJ.TabIndex = 6;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(28, 115);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(97, 16);
            this.lbNomeUsuario.TabIndex = 6;
            this.lbNomeUsuario.Text = "Nome Usuário:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(388, 26);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(92, 37);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(556, 164);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(301, 22);
            this.txEmail.TabIndex = 4;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(133, 161);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(233, 22);
            this.txUsuario.TabIndex = 4;
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(229, 250);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.ReadOnly = true;
            this.txNomeLojista.Size = new System.Drawing.Size(298, 22);
            this.txNomeLojista.TabIndex = 4;
            // 
            // txIdLojista
            // 
            this.txIdLojista.Location = new System.Drawing.Point(133, 250);
            this.txIdLojista.Name = "txIdLojista";
            this.txIdLojista.ReadOnly = true;
            this.txIdLojista.Size = new System.Drawing.Size(90, 22);
            this.txIdLojista.TabIndex = 4;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(133, 207);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(394, 22);
            this.txSenha.TabIndex = 4;
            // 
            // txDataCriacao
            // 
            this.txDataCriacao.Location = new System.Drawing.Point(420, 307);
            this.txDataCriacao.Name = "txDataCriacao";
            this.txDataCriacao.ReadOnly = true;
            this.txDataCriacao.Size = new System.Drawing.Size(150, 22);
            this.txDataCriacao.TabIndex = 4;
            // 
            // txDataModificacao
            // 
            this.txDataModificacao.Location = new System.Drawing.Point(133, 304);
            this.txDataModificacao.Name = "txDataModificacao";
            this.txDataModificacao.ReadOnly = true;
            this.txDataModificacao.Size = new System.Drawing.Size(150, 22);
            this.txDataModificacao.TabIndex = 4;
            // 
            // txModificadoPor
            // 
            this.txModificadoPor.Location = new System.Drawing.Point(660, 250);
            this.txModificadoPor.Name = "txModificadoPor";
            this.txModificadoPor.ReadOnly = true;
            this.txModificadoPor.Size = new System.Drawing.Size(197, 22);
            this.txModificadoPor.TabIndex = 4;
            // 
            // txCNPJ
            // 
            this.txCNPJ.Location = new System.Drawing.Point(624, 204);
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(233, 22);
            this.txCNPJ.TabIndex = 4;
            // 
            // txNomeUsuario
            // 
            this.txNomeUsuario.Location = new System.Drawing.Point(133, 112);
            this.txNomeUsuario.Name = "txNomeUsuario";
            this.txNomeUsuario.Size = new System.Drawing.Size(724, 22);
            this.txNomeUsuario.TabIndex = 4;
            // 
            // tx_Id
            // 
            this.tx_Id.Location = new System.Drawing.Point(133, 78);
            this.tx_Id.Name = "tx_Id";
            this.tx_Id.ReadOnly = true;
            this.tx_Id.Size = new System.Drawing.Size(330, 22);
            this.tx_Id.TabIndex = 4;
            // 
            // UsuarioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(961, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuarioExterno";
            this.Text = "Alteração de dados do usuário";
            this.Load += new System.EventHandler(this.UsuarioExterno_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txNomePesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txNomeUsuario;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txCNPJ;
        private System.Windows.Forms.Label lbPesquisa;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.CheckBox cbkSituacaoCadastral;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tx_Id;
        private System.Windows.Forms.Label lbIdLojista;
        private System.Windows.Forms.Label lbModificado;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.TextBox txIdLojista;
        private System.Windows.Forms.TextBox txModificadoPor;
        private System.Windows.Forms.Label lbDataCriacao;
        private System.Windows.Forms.Label lbDataModificacao;
        private System.Windows.Forms.TextBox txDataCriacao;
        private System.Windows.Forms.TextBox txDataModificacao;
    }
}
