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
        DataTable dtUsuarios = new DataTable();

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
            //dtUsuarios = /*new DataTable();*/

            DataColumn dcId = new DataColumn("IdLojista", typeof(String));
            DataColumn dcNomeLojista = new DataColumn("Lojista", typeof(String));
            DataColumn dcUsuario = new DataColumn("Usuário", typeof(String));
            DataColumn dcEmail = new DataColumn("E-mail", typeof(String));

            dtUsuarios.Columns.AddRange(new DataColumn[] {dcId, dcNomeLojista, dcUsuario, dcEmail });

            this.gridUsuarios.DataSource = dtUsuarios;

            this.gridUsuarios.Columns[0].Width = 80;
            this.gridUsuarios.Columns[1].Width = 220;
            this.gridUsuarios.Columns[2].Width = 200;
            this.gridUsuarios.Columns[3].Width = 200;

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            this.PesquisarUsuario();

        }

        public void PesquisarUsuario()
        {
            this.dtUsuarios.Clear();

            usuarioExternoModelo = new UsuarioExternoModelo();

            if(rbEmail.Checked)
            {
                usuarioExternoModelo.email = this.txNomePesquisa.Text;
            }

            if(rbUsuario.Checked)
            {
                usuarioExternoModelo.usuario = this.txNomePesquisa.Text;
            }

            usuarioExternoBLL = new UsuarioExternoBLL();
            usuarioExternoModelo = usuarioExternoBLL.PesquisarUsuarioExterno(usuarioExternoModelo);

            if(usuarioExternoModelo != null)
            {
                DataRow drItem = dtUsuarios.NewRow();

                drItem[0] = usuarioExternoModelo.lojas[0].idLoja;
                drItem[1] = usuarioExternoModelo.lojas[0].nome;
                drItem[2] = usuarioExternoModelo.usuario;
                drItem[3] = usuarioExternoModelo.email;

                dtUsuarios.Rows.Add(drItem);

                if(usuarioExternoModelo.inativo == true)
                {
                    this.cbkSituacaoCadastral.Checked = true;
                }
                this.txNomeUsuario.Text = usuarioExternoModelo.nome;
                this.txUsuario.Text = usuarioExternoModelo.usuario;
                this.txEmail.Text = usuarioExternoModelo.email;
                this.txSenha.Text = usuarioExternoModelo.senha;
                this.txCNPJ.Text = usuarioExternoModelo.cpf;

                gridUsuarios.DataSource = dtUsuarios;
            }
            
        }
    }
}
