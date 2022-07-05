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
            this.NomeDaJanela("Consulta usuário externo");
        }

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
            usuarioExternoModelo.dataAtualizacao = DateTime.Now;
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
