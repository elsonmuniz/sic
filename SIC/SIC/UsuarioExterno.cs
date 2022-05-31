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
    public partial class UsuarioExterno : Forms.FormEdit
    {
        FrmApp frmApp;

        //Datable
        DataTable dtUsuarios;

        //Modelo
        UsuarioExternoModelo usuarioExternoModelo;

        //BLL
        UsuarioExternoBLL usuarioExternoBLL;


        public UsuarioExterno(FrmApp frmApp)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;            
        }

        private void UsuarioExterno_Load(object sender, EventArgs e)
        {
            this.Listagemusuario();
        }

        public void Listagemusuario()
        {
            dtUsuarios = new DataTable();

            DataColumn dcId = new DataColumn("Id", typeof(String));
            DataColumn dcUsuario = new DataColumn("Usuário", typeof(String));
            DataColumn dcEmail = new DataColumn("E-mail", typeof(String));

            dtUsuarios.Columns.AddRange(new DataColumn[] {dcId, dcUsuario, dcEmail });

            this.gridUsuarios.DataSource = dtUsuarios;

            this.gridUsuarios.Columns[0].Width = 80;
            this.gridUsuarios.Columns[1].Width = 150;
            this.gridUsuarios.Columns[2].Width = 300;

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            usuarioExternoModelo = new UsuarioExternoModelo();

            usuarioExternoModelo.email = this.txNome.Text;

            usuarioExternoBLL = new UsuarioExternoBLL();
            usuarioExternoModelo = usuarioExternoBLL.PesquisarUsuarioExterno(usuarioExternoModelo);

            this.txCNPJ.Text = usuarioExternoModelo.cpf;
            this.txNome.Text = usuarioExternoModelo.nome;
            this.txUsuario.Text = usuarioExternoModelo.usuario;
            this.txEmail.Text = usuarioExternoModelo.email;


        }
    }
}
