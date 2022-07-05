namespace SIC
{
    partial class FrmLogin
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
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.kbUsuario = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLogar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(229, 170);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(198, 22);
            this.txSenha.TabIndex = 2;
            this.txSenha.UseSystemPasswordChar = true;
            this.txSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txSenha_KeyDown);
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(229, 119);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(198, 22);
            this.txUsuario.TabIndex = 1;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(166, 176);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(57, 16);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "SENHA:";
            // 
            // kbUsuario
            // 
            this.kbUsuario.AutoSize = true;
            this.kbUsuario.Location = new System.Drawing.Point(153, 122);
            this.kbUsuario.Name = "kbUsuario";
            this.kbUsuario.Size = new System.Drawing.Size(71, 16);
            this.kbUsuario.TabIndex = 1;
            this.kbUsuario.Text = "USUÁRIO:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(329, 248);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(98, 36);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLogar
            // 
            this.btLogar.Location = new System.Drawing.Point(173, 248);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(98, 36);
            this.btLogar.TabIndex = 3;
            this.btLogar.Text = "LOGAR";
            this.btLogar.UseVisualStyleBackColor = true;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIC.Properties.Resources.Sic;
            this.pictureBox2.Location = new System.Drawing.Point(24, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(569, 351);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.kbUsuario);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Controls.SetChildIndex(this.kbUsuario, 0);
            this.Controls.SetChildIndex(this.txUsuario, 0);
            this.Controls.SetChildIndex(this.lbSenha, 0);
            this.Controls.SetChildIndex(this.btLogar, 0);
            this.Controls.SetChildIndex(this.txSenha, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label kbUsuario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
