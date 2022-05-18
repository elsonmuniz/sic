using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using SIC.Modelo;
using System.Windows.Forms;

namespace SIC.DAO
{
    public class TempDAO
    {
        //DataTable        
        DataTable dtSKU;

        //CONEXÃO SQLSERVER
        //SqlConnection conexaoFront;

        //DATAADAPTER
        //OracleDataAdapter daSKU;

        //CMD        
        //OracleCommand cmdSKU;
        //OracleCommand cmdDesativarSku;

        //CONEXÃO ORACLE
        //Conexão - ADPRD
        OracleConnection conexaoADPRD;

        //Boolean
        //Boolean sellerAtivada = false;

        //CMD
        //SqlCommand cmdSellerFront;
        //OracleCommand cmdSKU;

        //TRANSACTION
        //OracleTransaction transaction = null;
        //SqlTransaction transactionFront = null;

        public DataTable ConsultarPrecoAlterado(string sChamado, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            DataTable dt = new DataTable();

            try
            {
                //ABRIR CONEXÃO
                //_conexao.Open();

                if (conexaoADPRD.State == ConnectionState.Open)
                {
                    conexaoADPRD = new OracleConnection();
                    conexaoADPRD = Conexao.ConectarAD(loginModelo);

                    //conexaoADPRD.Open();

                    //EXECUTAR SELECT NA PLANILHA
                    var cmd = new OracleCommand("SELECT t.COD1 AS Documento "+
                                                    ", r.REFERENCEID " +
                                                    ", t.COD5 AS SKUID_PLANILHA " +
                                                    ", t.COD3 AS SELLER_PLANILHA " +
                                                    ", t.COD7 AS VALOR_PLANILHA " +
                                                    " , p.VALUE AS VALOR_PRICE " +
                                                    " from AC_ADMIN.TEMP t " +
                                                    " INNER JOIN AC_ADMIN.ECAD_PRICE p ON t.COD5 = p.SKU_ID AND t.COD3 = p.STORE_QUALIFIER_ID " +
                                                    " INNER JOIN AC_ADMIN.ECMA_SKU_MP_RELATED_SKU_SELLER r ON p.SKU_ID = r.SKU_ID AND p.STORE_QUALIFIER_ID = r.STORE_QUALIFIER_ID " +
                                                    " WHERE t.COD1 like " + "\'"+sChamado+ ".xlsx\'" + " AND p.PRICE_TP_ID = 1", conexaoADPRD);

                    //var cmd = new OleDbCommand("SELECT * FROM [Planilha1$]", _conexao);

                    //LER SELECT E PREENCHER A TABELA COM OS REGISTROS DA PLANILHA
                    dt.Load(cmd.ExecuteReader());

                    this.dtSKU = new DataTable();

                    //Criando colunas
                    DataColumn dcNro = new DataColumn("Número", typeof(int));
                    DataColumn dcNroChamdo = new DataColumn("Nr.Chamado", typeof(string));
                    DataColumn dcIdLoja = new DataColumn("ReferenceID", typeof(string));
                    DataColumn dcNomeLoja = new DataColumn("SKUID_PLANILHA", typeof(string));
                    DataColumn dcIdSKU = new DataColumn("SELLER_PLANILHA", typeof(string));
                    DataColumn dcSKULojista = new DataColumn("SKU VALOR_PLANILHA", typeof(string));
                    DataColumn dcPrecoPor = new DataColumn("VALOR_PRICE", typeof(decimal));
                    DataColumn dcPercDesconto = new DataColumn("% Desconto", typeof(string));
                    //DataColumn dcDataFim = new DataColumn("Data Fim", typeof(string));
                    //DataColumn dcHora = new DataColumn("Hora", typeof(string));
                    //DataColumn dcNomeSolicitante = new DataColumn("Nome do Solicitante", typeof(string));
                    //DataColumn dcProdutoReference = new DataColumn("Reference", typeof(int));

                    dtSKU.Columns.AddRange(new DataColumn[] { dcNro, dcNroChamdo, dcIdLoja, dcNomeLoja, dcIdSKU, dcSKULojista, dcPrecoPor, dcPercDesconto });


                    //PERCORRO OS REGISTROS DA PLANILHA PARA IDENTIFICAR SE HÁ PRODUTOS POR REFERENCEID
                    int count = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        count++;

                        //if (dr[2].ToString() == "916721243")
                        //{
                        //    decimal percentual = 0;
                        //    percentual = Convert.ToDecimal(dr.ItemArray[4]) / Convert.ToDecimal(dr.ItemArray[5]); //- 1) * (100) * (-1);

                        //    dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], (((Convert.ToDecimal(dr[4]) / Convert.ToDecimal(dr[5])) - 1) * 100) * -1);
                        //}

                        dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], (((Convert.ToDecimal(dr[4]) / Convert.ToDecimal(dr[5])) - 1) * 100) * -1);


                    }
                }
                else
                {
                    loginModelo.Logado = false;
                }
            }

            catch (OracleException ex)
            {

                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSKU;

        }
    }
}
