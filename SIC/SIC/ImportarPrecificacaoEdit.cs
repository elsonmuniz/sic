using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SIC.BLL;
using System.Data.OleDb;
using SIC.Modelo;

namespace SIC
{
    public partial class ImportarPrecificacaoEdit : Forms.FormEdit
    {
        FrmApp frmApp;

        //BLL
        ProdutosBLL produtosBLL;
        TempBLL tempBLL;
        

        //DataTable
        DataTable dtSKU;

        //MODELO
        LoginModelo loginModelo;
        public ImportarPrecificacaoEdit(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        private void btPesquisarPlanilha_Click(object sender, EventArgs e)
        {
            this.ImportarPlanilha(this.txEnderecoPlanilha.Text);
        }

        public void ImportarPlanilha(string nomePlanilha)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txEnderecoPlanilha.Text = openFileDialog.FileName;
                    
                    produtosBLL = new ProdutosBLL();

                    dtSKU = new DataTable();
                    DataTable dtSkuFiltrado = new DataTable();

                    dtSKU = produtosBLL.LerPlanilhaPreco(txEnderecoPlanilha.Text);

                    foreach(DataRow dr in dtSKU.Rows)
                    {

                    }

                    this.gridSKUsAlterar.DataSource = dtSKU;

                    //this.gridSKUsAlterar.DataSource = produtosBLL.LerPlanilhaPreco(txEnderecoPlanilha.Text);

                    this.gridSKUsAlterar.Columns[0].Width = 150;
                    this.gridSKUsAlterar.Columns[1].Width = 150;
                    this.gridSKUsAlterar.Columns[2].Width = 310;                    
                    this.gridSKUsAlterar.Columns[3].Width = 150;
                    this.gridSKUsAlterar.Columns[4].Width = 150;
                    this.gridSKUsAlterar.Columns[5].Width = 150;
                    this.gridSKUsAlterar.Columns[5].DefaultCellStyle.Format = "N2";

                    this.txQtdeLinhas.Text = this.gridSKUsAlterar.RowCount.ToString();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btConsultarPrecoAlterado_Click(object sender, EventArgs e)
        {
            try
            {
                tempBLL = new TempBLL();

                this.gridSKUsAlterar.DataSource = tempBLL.ConsultarPrecoAlterado(this.txChamado.Text, loginModelo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
