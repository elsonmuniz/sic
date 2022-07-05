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

            //this.lbVersao.Text = this.GetVersion();
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
            loginModelo.VersaoSIC = this.GetVersion(); ;

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

        public string GetVersion()
        {
            //if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            //{
            //    Version ver;
            //    ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            //    return String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
            //}
            //else
            //    return "Not Published";

            string assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
            string productVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;

            return productVersion;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.VersaoSistema(GetVersion());
        }

        //public override void VersaoSistema(string sVersaoSistema)
        //{
        //    base.VersaoSistema(sVersaoSistema);
        //}
    }
}
