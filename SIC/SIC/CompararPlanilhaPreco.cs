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
    public partial class CompararPlanilhaPreco : Forms.FormEdit
    {
        FrmApp frmApp;

        //BLL
        ProdutosBLL produtosBLL;

        //DataTable
        DataTable dtSKU;

        //MODELO
        LoginModelo loginModelo;

        public CompararPlanilhaPreco(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        public void CompararPreco(string nomePlanilha, LoginModelo loginModelo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txEnderecoPlanilha.Text = openFileDialog.FileName;

                    produtosBLL = new ProdutosBLL();

                    dtSKU = new DataTable();

                    dtSKU = produtosBLL.CompararPlanilhaPreco(@txEnderecoPlanilha.Text, loginModelo);
                    this.gridSKUsAlterar.DataSource = dtSKU;

                    //this.gridSKUsAlterar.DataSource = produtosBLL.LerPlanilhaPreco(txEnderecoPlanilha.Text);

                    //this.gridSKUsAlterar.Columns[0].Width = 60;
                    //this.gridSKUsAlterar.Columns[1].Width = 60;
                    //this.gridSKUsAlterar.Columns[2].Width = 220;
                    //this.gridSKUsAlterar.Columns[3].Width = 80;
                    //this.gridSKUsAlterar.Columns[4].Width = 80;
                    //this.gridSKUsAlterar.Columns[5].Width = 80;
                    //this.gridSKUsAlterar.Columns[5].DefaultCellStyle.Format = "N2";
                    //this.gridSKUsAlterar.Columns[6].Width = 120;
                    //this.gridSKUsAlterar.Columns[7].Width = 120;
                    //this.gridSKUsAlterar.Columns[8].Width = 120;
                    //this.gridSKUsAlterar.Columns[8].DefaultCellStyle.Format = "d";
                    //this.gridSKUsAlterar.Columns[9].Width = 120;

                    this.txQtdeLinhas.Text = this.gridSKUsAlterar.RowCount.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btPesquisarPlanilha_Click(object sender, EventArgs e)
        {
            this.CompararPreco(this.txChamado.Text, loginModelo);
        }

        private void CompararPlanilhaPreco_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importa~r planiha de preços");
        }
    }
}
