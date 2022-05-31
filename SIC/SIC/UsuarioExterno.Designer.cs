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
            this.txNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.lbNomeLojista = new System.Windows.Forms.Label();
            this.txNomeLojista = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txCNPJ = new System.Windows.Forms.TextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(34, 31);
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
            this.rbUsuario.Location = new System.Drawing.Point(134, 31);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(75, 20);
            this.rbUsuario.TabIndex = 1;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUsuario);
            this.groupBox1.Controls.Add(this.rbEmail);
            this.groupBox1.Location = new System.Drawing.Point(46, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indique a pesquisa";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(44, 37);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(233, 22);
            this.txNome.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.lbCNPJ);
            this.groupBox2.Controls.Add(this.lbNomeLojista);
            this.groupBox2.Controls.Add(this.btConsultar);
            this.groupBox2.Controls.Add(this.txEmail);
            this.groupBox2.Controls.Add(this.txUsuario);
            this.groupBox2.Controls.Add(this.txCNPJ);
            this.groupBox2.Controls.Add(this.txNomeLojista);
            this.groupBox2.Controls.Add(this.txNome);
            this.groupBox2.Location = new System.Drawing.Point(36, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(303, 36);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(36, 322);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowHeadersWidth = 51;
            this.gridUsuarios.RowTemplate.Height = 24;
            this.gridUsuarios.Size = new System.Drawing.Size(780, 333);
            this.gridUsuarios.TabIndex = 6;
            // 
            // lbNomeLojista
            // 
            this.lbNomeLojista.AutoSize = true;
            this.lbNomeLojista.Location = new System.Drawing.Point(41, 92);
            this.lbNomeLojista.Name = "lbNomeLojista";
            this.lbNomeLojista.Size = new System.Drawing.Size(106, 20);
            this.lbNomeLojista.TabIndex = 6;
            this.lbNomeLojista.Text = "Nome lojista:";
            // 
            // txNomeLojista
            // 
            this.txNomeLojista.Location = new System.Drawing.Point(133, 89);
            this.txNomeLojista.Name = "txNomeLojista";
            this.txNomeLojista.Size = new System.Drawing.Size(233, 22);
            this.txNomeLojista.TabIndex = 4;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(526, 71);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(233, 22);
            this.txUsuario.TabIndex = 4;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(461, 74);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 16);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuário:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(526, 108);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(233, 22);
            this.txEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(461, 111);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 20);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            // 
            // txCNPJ
            // 
            this.txCNPJ.Location = new System.Drawing.Point(133, 121);
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(233, 22);
            this.txCNPJ.TabIndex = 4;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(41, 124);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(56, 20);
            this.lbCNPJ.TabIndex = 6;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // UsuarioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(832, 678);
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
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNomeLojista;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txNomeLojista;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txCNPJ;
    }
}
