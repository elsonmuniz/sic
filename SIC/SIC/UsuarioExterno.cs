using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;
using SIC.BLL;
using MongoDB.Bson;

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

        //List
        List<UsuarioExternoModelo> listUsuarioExternoModelo = new List<UsuarioExternoModelo>();


        public UsuarioExterno(FrmApp frmApp)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;            
        }

        private void UsuarioExterno_Load(object sender, EventArgs e)
        {
            //this.Listagemusuario();
        }

        //public void Listagemusuario()
        //{
        //    //dtUsuarios = /*new DataTable();*/

        //    DataColumn dcId = new DataColumn("IdLojista", typeof(String));
        //    DataColumn dcNomeLojista = new DataColumn("Lojista", typeof(String));
        //    DataColumn dcUsuario = new DataColumn("Usuário", typeof(String));
        //    DataColumn dcEmail = new DataColumn("E-mail", typeof(String));

        //    dtUsuarios.Columns.AddRange(new DataColumn[] {dcId, dcNomeLojista, dcUsuario, dcEmail });

        //    this.gridUsuarios.DataSource = dtUsuarios;

        //    this.gridUsuarios.Columns[0].Width = 80;
        //    this.gridUsuarios.Columns[1].Width = 220;
        //    this.gridUsuarios.Columns[2].Width = 200;
        //    this.gridUsuarios.Columns[3].Width = 200;

        //}

        private void btConsultar_Click(object sender, EventArgs e)
        {
            this.PesquisarUsuario();

        }

        public override void Salvar()
        {
            base.Salvar();

            usuarioExternoModelo = new UsuarioExternoModelo();

            usuarioExternoModelo._id = ObjectId.Parse(this.tx_Id.Text.Trim());
            usuarioExternoModelo.nome = this.txNomeUsuario.Text;
            usuarioExternoModelo.usuario = this.txUsuario.Text;
            usuarioExternoModelo.email = this.txEmail.Text;
            usuarioExternoModelo.senha = this.txSenha.Text;
            usuarioExternoModelo.cpf = this.txCNPJ.Text;
            usuarioExternoModelo.modificadoPor = this.txModificadoPor.Text;
            usuarioExternoModelo.dataAtualizacao = DateTime.Now; // Convert.ToDateTime(this.txDataModificacao.Text);
            usuarioExternoModelo.dataCriacao = Convert.ToDateTime(this.txDataCriacao.Text);


            usuarioExternoBLL = new UsuarioExternoBLL();

            usuarioExternoBLL.IncluirUsuarioExternoTeste(usuarioExternoModelo);

            this.LimparDadosTela();

        }

        public void PesquisarUsuario()
        {
            this.dtUsuarios.Clear();

            usuarioExternoModelo = new UsuarioExternoModelo();

            if(rbEmail.Checked)
            {
                //usuarioExternoModelo.email = this.txNomePesquisa.Text;
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
                //DataRow drItem = dtUsuarios.NewRow();

                //drItem[0] = usuarioExternoModelo.lojas[0].idLoja;
                //drItem[1] = usuarioExternoModelo.lojas[0].nome;
                //drItem[2] = usuarioExternoModelo.usuario;
                //drItem[3] = usuarioExternoModelo.email;

                //dtUsuarios.Rows.Add(drItem);

                if(usuarioExternoModelo.inativo == true)
                {
                    this.cbkSituacaoCadastral.Checked = true;
                }
                this.tx_Id.Text = usuarioExternoModelo._id.ToString();
                this.txNomeUsuario.Text = usuarioExternoModelo.nome;
                this.txUsuario.Text = usuarioExternoModelo.usuario;
                this.txEmail.Text = usuarioExternoModelo.email;
                this.txSenha.Text = usuarioExternoModelo.senha;
                this.txCNPJ.Text = usuarioExternoModelo.cpf;

                this.txIdLojista.Text = usuarioExternoModelo.lojas[0].idLoja;
                this.txNomeLojista.Text = usuarioExternoModelo.lojas[0].nome;
                this.txModificadoPor.Text = usuarioExternoModelo.modificadoPor;
                this.txDataCriacao.Text = usuarioExternoModelo.dataCriacao.ToString();
                this.txDataModificacao.Text = usuarioExternoModelo.dataAtualizacao.ToString();

                //gridUsuarios.DataSource = dtUsuarios;
            }
            else
            {
                MessageBox.Show("Pesquisa não localizada.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.LimparDadosTela();
            }
            
        }

        public void LimparDadosTela()
        {
            this.txNomePesquisa.Text            = "";
            this.cbkSituacaoCadastral.Checked   = false;
            this.tx_Id.Text                     = "";
            this.txNomeUsuario.Text             = "";
            this.txUsuario.Text                 = "";
            this.txEmail.Text                   = "";
            this.txSenha.Text                   = "";
            this.txCNPJ.Text                    = "";
            this.txIdLojista.Text               = "";
            this.txNomeLojista.Text             = "";
            this.txModificadoPor.Text           = "";
            this.txDataCriacao.Text             = "";
            this.txDataModificacao.Text         = "";
        }
    }
}
