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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txCNPJ = new System.Windows.Forms.TextBox();
            this.txNomeUsuario = new System.Windows.Forms.TextBox();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.lbPesquisa = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.cbkSituacaoCadastral = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
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
            this.txNomePesquisa.Location = new System.Drawing.Point(133, 37);
            this.txNomePesquisa.Name = "txNomePesquisa";
            this.txNomePesquisa.Size = new System.Drawing.Size(233, 22);
            this.txNomePesquisa.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbkSituacaoCadastral);
            this.groupBox2.Controls.Add(this.lbPesquisa);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.lbSenha);
            this.groupBox2.Controls.Add(this.lbCNPJ);
            this.groupBox2.Controls.Add(this.lbNomeUsuario);
            this.groupBox2.Controls.Add(this.btConsultar);
            this.groupBox2.Controls.Add(this.txEmail);
            this.groupBox2.Controls.Add(this.txUsuario);
            this.groupBox2.Controls.Add(this.txSenha);
            this.groupBox2.Controls.Add(this.txCNPJ);
            this.groupBox2.Controls.Add(this.txNomeUsuario);
            this.groupBox2.Controls.Add(this.txNomePesquisa);
            this.groupBox2.Location = new System.Drawing.Point(36, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 219);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(491, 138);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 16);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(68, 135);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(572, 178);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(45, 16);
            this.lbCNPJ.TabIndex = 6;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(28, 86);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(97, 16);
            this.lbNomeUsuario.TabIndex = 6;
            this.lbNomeUsuario.Text = "Nome Usuário:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(388, 36);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(556, 135);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(301, 22);
            this.txEmail.TabIndex = 4;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(133, 132);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(233, 22);
            this.txUsuario.TabIndex = 4;
            // 
            // txCNPJ
            // 
            this.txCNPJ.Location = new System.Drawing.Point(624, 175);
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(233, 22);
            this.txCNPJ.TabIndex = 4;
            // 
            // txNomeUsuario
            // 
            this.txNomeUsuario.Location = new System.Drawing.Point(133, 83);
            this.txNomeUsuario.Name = "txNomeUsuario";
            this.txNomeUsuario.Size = new System.Drawing.Size(724, 22);
            this.txNomeUsuario.TabIndex = 4;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(36, 393);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowHeadersWidth = 51;
            this.gridUsuarios.RowTemplate.Height = 24;
            this.gridUsuarios.Size = new System.Drawing.Size(1011, 308);
            this.gridUsuarios.TabIndex = 6;
            // 
            // lbPesquisa
            // 
            this.lbPesquisa.AutoSize = true;
            this.lbPesquisa.Location = new System.Drawing.Point(59, 43);
            this.lbPesquisa.Name = "lbPesquisa";
            this.lbPesquisa.Size = new System.Drawing.Size(67, 16);
            this.lbPesquisa.TabIndex = 7;
            this.lbPesquisa.Text = "Pesquisa:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(133, 178);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(394, 22);
            this.txSenha.TabIndex = 4;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(76, 181);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 16);
            this.lbSenha.TabIndex = 6;
            this.lbSenha.Text = "Senha:";
            // 
            // cbkSituacaoCadastral
            // 
            this.cbkSituacaoCadastral.AutoSize = true;
            this.cbkSituacaoCadastral.Location = new System.Drawing.Point(575, 36);
            this.cbkSituacaoCadastral.Name = "cbkSituacaoCadastral";
            this.cbkSituacaoCadastral.Size = new System.Drawing.Size(146, 20);
            this.cbkSituacaoCadastral.TabIndex = 8;
            this.cbkSituacaoCadastral.Text = "Situação Cadastral:";
            this.cbkSituacaoCadastral.UseVisualStyleBackColor = true;
            // 
            // UsuarioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1059, 727);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuarioExterno";
            this.Text = "Alteração de dados do usuário";
            this.Load += new System.EventHandler(this.UsuarioExterno_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.gridUsuarios, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
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
        private System.Windows.Forms.DataGridView gridUsuarios;
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
    }
}
