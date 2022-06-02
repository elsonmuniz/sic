using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;
using SIC.BLL;

namespace SIC
{    
    public partial class FrmLogin : Forms.AppLogin
    {
        //Modelo
        LoginModelo loginModelo;
        
        //BLL
        LogarBLL logarBLL;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            this.Logar();
        }

        public void Logar()
        {
            loginModelo = new LoginModelo();
            loginModelo.Usuario = this.txUsuario.Text;
            loginModelo.Senha = this.txSenha.Text;

            logarBLL = new LogarBLL();
            logarBLL.Logar(loginModelo);

            //Se o resultado da conexão for o campo Logado == true, chama o formulário principal do sistema.
            if (loginModelo.Logado == true)
            {
                this.Visible = false;

                FrmApp frmApp = new FrmApp(loginModelo);
                frmApp.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido. Em três tentativas inválidas, bloqueará seu usuário do banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void txSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Logar();
            }
        }
    }
}
