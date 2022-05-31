using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using SIC.Modelo;

namespace SIC
{
    public partial class FrmApp : Forms.AppForm
    {
        LoginModelo loginModelo;

        public FrmApp(LoginModelo loginModelo)
        {
            InitializeComponent();
            this.toolStripStatusData.Text += DateTime.Now.ToString().Substring(0,10);
            this.loginModelo = loginModelo;
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SellerViewer sellerViewer = new SellerViewer();
            //sellerViewer.Show();

            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente sair da aplicação?","Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
            else
            {

            }

            
        }

        private void FrmApp_Load(object sender, EventArgs e)
        {
            this.toolStripStatusUsuario.Text += Environment.UserName;

        }

        private void consultarLojaAtivaADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerEdit sellerEdit = new SellerEdit(this, loginModelo);
            sellerEdit.Show();
        }

        private void consultarLojaFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerEditFront sellerEditFront = new SellerEditFront(this, loginModelo);
            sellerEditFront.Show();
        }

        private void reprocessarLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellerReprocessarFront sellerReprocessarFront = new SellerReprocessarFront(this, loginModelo);
            sellerReprocessarFront.Show();
        }

        private void sKUNãoConstaNoFRONTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKUNaoExiteFront sKUNaoExiteFront = new SKUNaoExiteFront(this, loginModelo);
            sKUNaoExiteFront.Show();
        }

        private void mPCoprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MpCompras mpCompras = new MpCompras(this, loginModelo);
            mpCompras.Show();
        }

        private void sKUAtivoComVarianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSkuAtivoComVariante consultarSkuAtivoComVariante = new ConsultarSkuAtivoComVariante(this, loginModelo);
            consultarSkuAtivoComVariante.Show();
        }

        private void sKUConsultarIntegraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntegracaoSKU integracaoSKU = new IntegracaoSKU(this, loginModelo);
            integracaoSKU.Show();
        }

        private void sKUErroIntegraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErroIntegracaoSKU erroIntegracaoSKU = new ErroIntegracaoSKU(this, loginModelo);
            erroIntegracaoSKU.Show();
        }

        private void importarPlanilhaPrecificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarPrecificacaoEdit importarPrecificacaoEdit = new ImportarPrecificacaoEdit(this, loginModelo);
            importarPrecificacaoEdit.Show();
        }

        private void compararPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompararPlanilhaPreco comprarPlanilhaPreco = new CompararPlanilhaPreco(this, loginModelo);
            comprarPlanilhaPreco.Show();
        }

        private void sKURelatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SKURelated sKURelated = new SKURelated(this,loginModelo);
            sKURelated.Show();

        }

        private void consultarOrderGetNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarOrderGetNet consultarOrderGetNet = new ConsultarOrderGetNet(this, loginModelo);
            consultarOrderGetNet.Show();
        }

        private void consultarLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLojaGetNet consultarLojaGetNet = new ConsultarLojaGetNet(this);
            consultarLojaGetNet.Show();
        }

        private void consultarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedidoFinanceiro consultarPedidoFinanceiro = new ConsultarPedidoFinanceiro(this);
            consultarPedidoFinanceiro.Show();
        }

        private void consultarPedidoCanceladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarOrderItemGetnet consultarOrderItemGetnet = new ConsultarOrderItemGetnet(this);
            consultarOrderItemGetnet.Show();
        }

        private void onBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioExterno usuarioExterno = new UsuarioExterno(this);
            usuarioExterno.Show();
        }
    }
}
