using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.BLL;
using SIC.Modelo;

namespace SIC
{
    public partial class SKUNaoExiteFront : Forms.FormEdit
    {
        DataTable dtSKU;

        //BLL
        ProdutosBLL produtosBLL;

        FrmApp frmApp;

        //MODELO
        LoginModelo loginModelo;
        public SKUNaoExiteFront(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            produtosBLL = new ProdutosBLL();
            this.ExibirProdutoQueNaoConstaNoFront(Convert.ToInt32(this.txIdLojista.Text.Trim()), loginModelo);
        }

        public void ExibirProdutoQueNaoConstaNoFront(int idLogista, LoginModelo loginModelo)
        {
            produtosBLL = new ProdutosBLL();
            dtSKU = new DataTable();
            try
            {
                dtSKU = produtosBLL.ListarSKUNaoExisteFront(idLogista, loginModelo);

                gridSellerFront.DataSource = dtSKU;

                if (dtSKU.Rows.Count > 0)
                {
                    this.txNomeLojista.Text = dtSKU.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Não existe registro retornado da tabela", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gridSellerFront.Columns[0].Width = 80;
                gridSellerFront.Columns[1].Width = 160;
                gridSellerFront.Columns[2].Width = 100;
                gridSellerFront.Columns[3].Width = 100;
                gridSellerFront.Columns[4].Width = 100;

            }

            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SKUNaoExiteFront_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Contula SKU front");
        }
    }
}
