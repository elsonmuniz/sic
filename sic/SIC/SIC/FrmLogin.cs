using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;

namespace SIC
{
    public partial class FrmLogin : Forms.AppLogin
    {
        LoginModelo loginModelo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            loginModelo = new LoginModelo();
            loginModelo.Usuario = this.txUsuario.Text;
            loginModelo.Senha = this.txSenha.Text;

            this.Visible = false;

            FrmApp frmApp = new FrmApp(loginModelo);
            frmApp.Show();

            //this.Dispose();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
       
    }
}
