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
    public partial class IntegracaoSKU : Forms.FormEdit
    {
        FrmApp frmApp;

        //BLL
        ProdutosBLL produtosBLL;

        //DataTable
        DataTable dtSKU;

        //MODELO
        LoginModelo loginModelo;

        public IntegracaoSKU(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        public void ConsultarIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            produtosBLL = new ProdutosBLL();
            dtSKU = new DataTable();

            try
            {
                dtSKU = produtosBLL.ConsultarIntegracaoSKU(idSKU, loginModelo);

                gridSKU.DataSource = dtSKU;

                //if (dtSKU != null)
                //{
                //    this.txNomeLojista.Text = dtSeller.Rows[0][1].ToString();
                //}

                gridSKU.Columns[0].Width = 80;
                gridSKU.Columns[1].Width = 80;
                gridSKU.Columns[2].Width = 80;
                gridSKU.Columns[3].Width = 80;
                gridSKU.Columns[4].Width = 80;
                gridSKU.Columns[5].Width = 80;
                gridSKU.Columns[6].Width = 80;
                gridSKU.Columns[7].Width = 80;
                gridSKU.Columns[8].Width = 80;
                gridSKU.Columns[9].Width = 80;
                gridSKU.Columns[10].Width = 80;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Informe o id do lojista ou verifique se estar conectado a vpn." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            this.ConsultarIntegracaoSKU(Convert.ToInt32(this.txIdSKU.Text), loginModelo);
        }

        private void IntegracaoSKU_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Consultar integração de SKU");
        }
    }
}
