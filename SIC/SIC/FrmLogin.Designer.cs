﻿namespace SIC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.kbUsuario = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLogar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txSenha);
            this.groupBox1.Controls.Add(this.txUsuario);
            this.groupBox1.Controls.Add(this.lbSenha);
            this.groupBox1.Controls.Add(this.kbUsuario);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btLogar);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre com os dados do login";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(125, 112);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(198, 22);
            this.txSenha.TabIndex = 2;
            this.txSenha.Text = "ELSON_E99#1DR";
            this.txSenha.UseSystemPasswordChar = true;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(125, 62);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(198, 22);
            this.txUsuario.TabIndex = 2;
            this.txUsuario.Text = "ELSON_JUNIOR";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(62, 118);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(57, 16);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "SENHA:";
            // 
            // kbUsuario
            // 
            this.kbUsuario.AutoSize = true;
            this.kbUsuario.Location = new System.Drawing.Point(49, 65);
            this.kbUsuario.Name = "kbUsuario";
            this.kbUsuario.Size = new System.Drawing.Size(71, 16);
            this.kbUsuario.TabIndex = 1;
            this.kbUsuario.Text = "USUÁRIO:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(220, 188);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 32);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLogar
            // 
            this.btLogar.Location = new System.Drawing.Point(100, 188);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(92, 32);
            this.btLogar.TabIndex = 0;
            this.btLogar.Text = "LOGAR";
            this.btLogar.UseVisualStyleBackColor = true;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label kbUsuario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLogar;
    }
}