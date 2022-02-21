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

        //Cria a tabela com o nome dos campos que serão exibidos quando abrir a tela
        public void ListagemPrecificacao()
        {
            dtSKU = new DataTable();

            //Criando colunas
            DataColumn dcNro = new DataColumn("Número", typeof(int));
            DataColumn dcIdLoja = new DataColumn("ID Loja", typeof(string));
            DataColumn dcNomeLoja = new DataColumn("Nome Loja", typeof(string));
            DataColumn dcIdSKU = new DataColumn("ID SKU(SKU MP)", typeof(string));
            DataColumn dcSKULojista = new DataColumn("SKU Lojista", typeof(string));
            DataColumn dcPrecoPor = new DataColumn("Preço POR", typeof(decimal));

            //Adicionando as colunas na tabela
            dtSKU.Columns.AddRange(new DataColumn[] { dcNro, dcIdLoja, dcNomeLoja, dcIdSKU, dcSKULojista, dcPrecoPor });

            //Passando a tabela preenchida com as colunas acima para o grid de exibição de tela
            this.gridSKUsAlterar.DataSource = dtSKU;

            this.gridSKUsAlterar.Columns[0].Width = 150;
            this.gridSKUsAlterar.Columns[1].Width = 150;
            this.gridSKUsAlterar.Columns[2].Width = 310;
            this.gridSKUsAlterar.Columns[3].Width = 150;
            this.gridSKUsAlterar.Columns[4].Width = 150;
            this.gridSKUsAlterar.Columns[5].Width = 175;
            this.gridSKUsAlterar.Columns[5].DefaultCellStyle.Format = "N2";
            
        }

        //Método de abertura da planilha
        public void ImportarPlanilha(string nomePlanilha)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txEnderecoPlanilha.Text = openFileDialog.FileName;
                    
                    produtosBLL = new ProdutosBLL();

                    //Limpando a tabela que exibe os skus na tela
                    this.dtSKU.Clear();

                    DataTable dtSkuPlanilha = new DataTable();

                    //Recebendo retorno da camada DAO
                    //Passando a planilha para leitura
                    dtSkuPlanilha = produtosBLL.LerPlanilhaPreco(txEnderecoPlanilha.Text);

                    //Variáveis de contagem
                    int count = 0;
                    int countSemOrigin = 0;

                    foreach (DataRow dr in dtSkuPlanilha.Rows)
                    {
                        count++;

                        if (dr[0].ToString().Length != 0)
                        {
                            if (dr[2].ToString().Length != 0)
                            {
                                dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4]);
                            }
                            else
                            {
                                dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4]);
                                countSemOrigin ++;
                            }
                        }
                    }

                    //Exibindo a qtde de registros que não tem valor do SKU MP
                    this.txQtdeSemSQKUID.Text = countSemOrigin.ToString();

                    //Exibindo a tabela preenchida
                    this.gridSKUsAlterar.DataSource = dtSKU;

                    //Exibindo o total de linhas percorridas na planilha
                    this.txQtdeLinhas.Text = this.gridSKUsAlterar.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportarPrecificacaoEdit_Load(object sender, EventArgs e)
        {
            this.ListagemPrecificacao();
        }
    }
}
