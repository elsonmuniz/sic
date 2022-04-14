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
    public partial class ErroIntegracaoSKU : Forms.FormEdit
    {
        FrmApp frmApp;

        //BLL
        ProdutosBLL produtosBLL;

        //DataTable
        DataTable dtSKU;

        //MODELO
        LoginModelo loginModelo;

        public ErroIntegracaoSKU(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        private void ErroIntegracaoSKU_Load(object sender, EventArgs e)
        {

        }

        public void ConsultarErroIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            produtosBLL = new ProdutosBLL();
            dtSKU = new DataTable();

            try
            {
                dtSKU = produtosBLL.ConsultarErroIntegracaoSKU(idSKU, loginModelo);

                gridSKU.DataSource = dtSKU;


                gridSKU.Columns[0].Width = 70;
                //gridSKU.Columns[1].Width = 80;
                gridSKU.Columns[2].Width = 80;
                gridSKU.Columns[3].Width = 80;
                gridSKU.Columns[4].Width = 60;
                gridSKU.Columns[5].Width = 250;
                //gridSKU.Columns[6].Width = 80;
                //gridSKU.Columns[7].Width = 80;
                //gridSKU.Columns[8].Width = 80;
                //gridSKU.Columns[9].Width = 80;
                //gridSKU.Columns[10].Width = 80;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Informe o id do lojista ou verifique se estar conectado a vpn." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPesquisarSKU_Click(object sender, EventArgs e)
        {
            this.ConsultarErroIntegracaoSKU(Convert.ToInt32(this.txIdSKU.Text), loginModelo);
        }
    }
}
