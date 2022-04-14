using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Data.OleDb;
using SIC.Modelo;

namespace SIC.DAO
{
    public class ProdutosDAO
    {
        //DataTable        
        DataTable dtSKU;
        
        //CONEXÃO SQLSERVER
        SqlConnection conexaoFront;

        //DATAADAPTER
        OracleDataAdapter daSKU;
        
        //CMD        
        OracleCommand cmdSKU;
        OracleCommand cmdDesativarSku;

        //CONEXÃO ORACLE
        //Conexão - ADPRD
        OracleConnection conexaoADPRD;

        //Boolean
        //Boolean sellerAtivada = false;

        //CMD
        //SqlCommand cmdSellerFront;
        //OracleCommand cmdSKU;

        //TRANSACTION
        OracleTransaction transaction = null;
        //SqlTransaction transactionFront = null;

        public DataTable ListarSKUNaoExisteFront(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            conexaoFront = new SqlConnection();

            try
            {
                //conexaoADPRD.Open();

                if(conexaoADPRD.State == ConnectionState.Open)
                {
                    //**************************************** PEGAR WAREHOUSE ADPRD *********************************************
                    
                    loginModelo.Logado = true;

                    daSKU = new OracleDataAdapter();
                    daSKU.SelectCommand = new OracleCommand();
                    daSKU.SelectCommand.Connection = conexaoADPRD;

                    //40229
                    daSKU.SelectCommand.CommandText = "SELECT PRODUCT_ID " +
                                                        " ,SKU_ID " +
                                                        " ,SKU_ID_ORIGIN " +
                                                        " ,ACTIVE " +
                                                        " ,REFERENCEID " +
                                                        " ,FLG_LOCK " +
                                                      "FROM AC_ADMIN.ECMA_SKU_MP_RELATED_SKU_SELLER  s " +
                                                        "WHERE NOT EXISTS (SELECT i.* " +
                                                        "FROM fi.FRONT_INTEGRATION_SKU i " +
                                                    " where s.sku_id = i.sku_id " +
                                                            " and i.status = 3) " +
                                                    "and s.store_qualifier_id in("+idLogista+")";

                 

                    dtSKU = new DataTable();
                    daSKU.Fill(dtSKU);

                    //**************************************** CONSULTAR WAREHOUSE NO ADPRD *********************************************

                    //daSKU = new OracleDataAdapter();
                    //daSKU.SelectCommand = new OracleCommand();
                    //daSKU.SelectCommand.Connection = conexaoADPRD;

                    //daSKU.SelectCommand.CommandText = "SELECT * FROM ac_admin.ecsl_stock @DBL_SLPRD " +
                    //                                    " WHERE WAREHOUSE_ID in(" + dtWareHouse.Rows[0]["WAREHOUSE_ID"] + ")" +
                    //                                        " AND AVAILABLE_QUANTITY > 0";

                    //dtSKU = new DataTable();
                    //daSKU.Fill(dtSKU);


                    ////**************************************** CONSULTAR PRODUTO NO FRONT - EXTRA *********************************************

                    //conexaoFront = Conexao.ConectarSL();
                    //conexaoFront.Open();

                    //daSKUFrontExtra = new SqlDataAdapter();
                    //daSKUFrontExtra.SelectCommand = new SqlCommand();
                    //daSKUFrontExtra.SelectCommand.Connection = conexaoFront;
                    //daSKUFrontExtra.SelectCommand.CommandText = "SELECT * FROM db_prd_ExtracaoParceiro..SkuLojista_Extra " +
                    //                                            "WHERE IdLojista in (" + idLogista + " )" + " and FlagSkuSaldoDisponivel = 1 and FlagAtiva = 1";

                    //dtSKUFrontExtra = new DataTable();
                    //daSKUFrontExtra.Fill(dtSKUFrontExtra);

                    ////**************************************** PERCORRER PARA DESCOBRIR PRODUTO QUE NÃO CONSTA NO FRONT *********************************************

                    //foreach (DataRow drSKU in dtWareHouse.Rows)
                    //{

                    //    //DataRow[] drREsult;

                    //    //drREsult;

                    //    var TESTE = dtSKUFrontExtra.Select("IdSku = " + drSKU[10].ToString());

                    //    //string sku = dtSKUFrontExtra.Select("IdSku = " + drSKU[10].ToString()).ToString();

                    //    if (TESTE.Length == 0)
                    //    {
                    //        MessageBox.Show("Produto não encontrado" + drSKU[10].ToString(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }

                    //    //90185 

                    //    //foreach (DataRow drExtra in dtSKUFrontExtra.Rows)
                    //    //{
                    //    //    //DataRow[] drREsult;
                    //    //    //1524069103

                    //    //    drREsult = dtSKUFrontExtra.Select("IdSKU = " + drSKU["REFERENCEID"].ToString());

                    //    //    //string st = drREsult[0].ItemArray[0].ToString();

                    //    //    if (drREsult.Length == 0)
                    //    //    //{
                    //    //    MessageBox.Show("Produto não encontrado" + drSKU[10].ToString(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    //    //}
                    //    //}
                    //}
                }
                else
                {
                    loginModelo.Logado = false;
                }

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

                 return dtSKU;
        }

        public DataTable ConsultarSkuAtivoComVariante(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            DataTable dtSKUs = new DataTable();

            conexaoFront = new SqlConnection();

            try
            {
                //conexaoADPRD.Open();

                if (conexaoADPRD.State == ConnectionState.Open)
                {
                    loginModelo.Logado = true;

                    //**************************************** PEGAR WAREHOUSE ADPRD *********************************************

                    daSKU = new OracleDataAdapter();
                    daSKU.SelectCommand = new OracleCommand();
                    daSKU.SelectCommand.Connection = conexaoADPRD;

                    daSKU.SelectCommand.CommandText = "  SELECT distinct (es.PRODUCT_ID) " +
                                                            " FROM AC_ADMIN.ECMA_SKU_MP_RELATED_SKU_SELLER RS " +
                                                            " INNER JOIN AC_ADMIN.ECAD_WAREHOUSE EW  ON RS.STORE_QUALIFIER_ID = EW.STORE_QUALIFIER_ID " +
                                                            " INNER JOIN AC_ADMIN.ECAD_CURRENT_STOCK CS ON RS.SKU_ID = CS.SKU_ID and CS.WAREHOUSE_ID = ew.WAREHOUSE_ID " +
                                                            " INNER JOIN ac_admin.ECAD_SKU es on rs.SKU_ID = es.SKU_ID " +
                                                                " WHERE RS.STORE_QUALIFIER_ID IN(" + idLogista + ") " +
                                                                    " and ACTIVE = 'Y' " +
                                                                        " and QUANTITY > 0 " +
                                                            " group by es.PRODUCT_ID " +
                                                            " order by es.PRODUCT_ID ";

                    dtSKU = new DataTable();
                    daSKU.Fill(dtSKU);

                    

                    DataColumn dcNumero = new DataColumn("Número", typeof(string));
                    DataColumn dcProductId = new DataColumn("Product ID", typeof(string));
                    dtSKUs.Columns.AddRange(new DataColumn[] { dcNumero, dcProductId});

                    int count = 0;

                    foreach(DataRow drSKU in dtSKU.Rows)
                    {
                        count++;

                        dtSKUs.Rows.Add(count, drSKU);
                    }
                }
                else
                {
                    loginModelo.Logado = false;
                }
                    

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSKUs;
        }

        public DataTable ConsultarIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            conexaoFront = new SqlConnection();

            try
            {
                //conexaoADPRD.Open();

                if (conexaoADPRD.State == ConnectionState.Open)
                {
                    loginModelo.Logado = true;
                    //**************************************** Consultas de integração dos Skus *********************************************

                    daSKU = new OracleDataAdapter();
                    daSKU.SelectCommand = new OracleCommand();
                    daSKU.SelectCommand.Connection = conexaoADPRD;

                    daSKU.SelectCommand.CommandText = " SELECT * FROM fi.FRONT_INTEGRATION_SKU where SKU_ID IN(" + "\'" + idSKU + "\'" + ")  order by updated_At desc";

                    dtSKU = new DataTable();
                    daSKU.Fill(dtSKU);
                }
                else
                {
                    loginModelo.Logado = false;
                }
                   

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSKU;
        }

        public DataTable ConsultarErroIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            conexaoFront = new SqlConnection();

            try
            {
                //conexaoADPRD.Open();

                if (conexaoADPRD.State == ConnectionState.Open)
                {
                    loginModelo.Logado = true;

                    //**************************************** Consultas de integração dos Skus *********************************************

                    daSKU = new OracleDataAdapter();
                    daSKU.SelectCommand = new OracleCommand();
                    daSKU.SelectCommand.Connection = conexaoADPRD;

                    daSKU.SelectCommand.CommandText = " SELECT * FROM fi.FRONT_INTEGRATION_SKU_ERROR WHERE SKU_ID IN(" + "\'" + idSKU + "\'" + ")  order by updated_At desc";

                    dtSKU = new DataTable();
                    daSKU.Fill(dtSKU);
                }
                else
                {
                    loginModelo.Logado = false;
                }

                   

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSKU;
        }

        public DataTable LerPlanilhaPreco(string planilhaPreco)
        {
            var dt = new DataTable();
            var _conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + planilhaPreco + "';Extended Properties=Excel 12.0;");

            try
            {
                //ABRIR CONEXÃO
                _conexao.Open();

                //EXECUTAR SELECT NA PLANILHA
                var cmd =  new OleDbCommand("SELECT * FROM [ModeloSeller$]", _conexao);                
                
                //LER SELECT E PREENCHER A TABELA COM OS REGISTROS DA PLANILHA
                dt.Load(cmd.ExecuteReader());

                dtSKU = new DataTable();
                
                //Criando colunas
                DataColumn dcNro = new DataColumn("Número", typeof(int));
                DataColumn dcIdLoja = new DataColumn("ID Loja", typeof(string));
                DataColumn dcNomeLoja = new DataColumn("Nome Loja", typeof(string));
                DataColumn dcIdSKU = new DataColumn("ID SKU(SKU MP)", typeof(string));
                DataColumn dcSKULojista = new DataColumn("SKU Lojista", typeof(string));
                DataColumn dcPrecoPor = new DataColumn("Preço POR", typeof(decimal));
                //DataColumn dcDataInicio = new DataColumn("Data Início", typeof(string));
                //DataColumn dcDataFim = new DataColumn("Data Fim", typeof(string));
                //DataColumn dcHora = new DataColumn("Hora", typeof(string));
                //DataColumn dcNomeSolicitante = new DataColumn("Nome do Solicitante", typeof(string));
                /*, dcDataInicio, dcDataFim, dcHora, dcNomeSolicitante*/

                dtSKU.Columns.AddRange(new DataColumn[] { dcNro, dcIdLoja, dcNomeLoja, dcIdSKU, dcSKULojista, dcPrecoPor });
                

                int count = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    count++;

                    if(dr[0].ToString().Length !=0)
                    {
                        dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4]);

                        /*, dr[5], dr[6], dr[7].ToString().Remove(0,10), dr[8]*/
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }
            
            
            
            return dtSKU;
 
        }

        //Comparativo da planilha de preço 
        //Para saber se no lugar do sku id, estar indevidamente o REFERENCEID
        public DataTable CompararPlanilhaPreco(string planilhaPreco, LoginModelo loginModelo)
        {
            var dt = new DataTable();
            var _conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + planilhaPreco + "';Extended Properties=Excel 12.0;");

            try
            {
                //ABRIR CONEXÃO
                _conexao.Open();

                if (_conexao.State == ConnectionState.Open)
                {
                    conexaoADPRD = new OracleConnection();
                    conexaoADPRD = Conexao.ConectarAD(loginModelo);

                    //conexaoADPRD.Open();

                    //EXECUTAR SELECT NA PLANILHA
                    var cmd = new OleDbCommand("SELECT * FROM [ModeloSeller$]", _conexao);
                    //var cmd = new OleDbCommand("SELECT * FROM [Planilha1$]", _conexao);

                    //LER SELECT E PREENCHER A TABELA COM OS REGISTROS DA PLANILHA
                    dt.Load(cmd.ExecuteReader());

                    dtSKU = new DataTable();

                    //Criando colunas
                    DataColumn dcNro = new DataColumn("Número", typeof(int));
                    DataColumn dcIdLoja = new DataColumn("ID Loja", typeof(string));
                    DataColumn dcNomeLoja = new DataColumn("Nome Loja", typeof(string));
                    DataColumn dcIdSKU = new DataColumn("ID SKU(SKU MP)", typeof(string));
                    DataColumn dcSKULojista = new DataColumn("SKU Lojista", typeof(string));
                    DataColumn dcPrecoPor = new DataColumn("Preço POR", typeof(decimal));
                    //DataColumn dcDataInicio = new DataColumn("Data Início", typeof(string));
                    //DataColumn dcDataFim = new DataColumn("Data Fim", typeof(string));
                    //DataColumn dcHora = new DataColumn("Hora", typeof(string));
                    //DataColumn dcNomeSolicitante = new DataColumn("Nome do Solicitante", typeof(string));
                    DataColumn dcProdutoReference = new DataColumn("Reference", typeof(int));

                    dtSKU.Columns.AddRange(new DataColumn[] { dcNro, dcIdLoja, dcNomeLoja, dcIdSKU, dcSKULojista, dcPrecoPor, dcProdutoReference });


                    //PERCORRO OS REGISTROS DA PLANILHA PARA IDENTIFICAR SE HÁ PRODUTOS POR REFERENCEID
                    int count = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        count++;

                        if (dr[0].ToString().Length != 0)
                        {
                            DataTable dtComparaPreco = new DataTable();
                            daSKU = new OracleDataAdapter();
                            daSKU.SelectCommand = new OracleCommand();
                            daSKU.SelectCommand.Connection = conexaoADPRD;

                            daSKU.SelectCommand.CommandText = " SELECT * FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE REFERENCEID IN(" + "\'" + dr[2] + "\')" + " AND STORE_QUALIFIER_ID = '" + dr[0] + "'  order by 1 desc";

                            //dtComparaPreco = new DataTable();
                            daSKU.Fill(dtComparaPreco);

                            if (dtComparaPreco.Rows.Count > 0)
                            {
                                if (dtComparaPreco.Rows[0][2].ToString() == dr[2].ToString())
                                {
                                    dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4], 0);
                                }
                                else
                                {
                                    dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4], 1);
                                }
                            }
                            else
                            {
                                dtSKU.Rows.Add(count, dr[0], dr[1], dr[2], dr[3], dr[4], 0);
                            }

                        }


                        //CALCULAR O PERCENTUAL DO AUMENTO,PLANILHA x ADPRD

                        DataTable dtADPRDPrice = new DataTable();
                        daSKU = new OracleDataAdapter();
                        daSKU.SelectCommand = new OracleCommand();
                        daSKU.SelectCommand.Connection = conexaoADPRD;

                        daSKU.SelectCommand.CommandText = "";

                    }
                }
                else
                {
                    loginModelo.Logado = false;
                }
            }

            catch (OracleException ex)
            {

                MessageBox.Show("Error" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conexao.Close();
            }

            return dtSKU;

        }

        public DataTable ConsultarSKURelated(SKUModelo sKUModelo, LoginModelo loginModelo)
        {
            DataTable dtSKUs = new DataTable();

            conexaoADPRD = new OracleConnection();
            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            conexaoFront = new SqlConnection();

            try
            {
                //conexaoADPRD.Open();

                if (conexaoADPRD.State == ConnectionState.Open)
                {
                    //**************************************** Consultas dos Skus *********************************************

                    daSKU = new OracleDataAdapter();
                    daSKU.SelectCommand = new OracleCommand();
                    daSKU.SelectCommand.Connection = conexaoADPRD;

                    if (sKUModelo.product_id != 0)
                    {
                        //daSKU.SelectCommand.CommandText = " SELECT * FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE PRODUCT_ID IN(" + "\'" + sKUModelo.product_id + "\'" + ") ";

                        daSKU.SelectCommand.CommandText = " SELECT product_id" +
                                                                    " ,sku_id" +
                                                                    " ,sku_id_origin" +
                                                                    " ,active" +
                                                                    " ,store_qualifier_id" +
                                                                    " ,referenceid" +
                                                                    " ,flg_lock" +
                            " FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE PRODUCT_ID IN(" + "\'" + sKUModelo.product_id + "\'" + ") OR sku_id_origin IN(" + "\'" + sKUModelo.product_id + "\'" + ")";


                    }

                    if (sKUModelo.sku_id != null)
                    {
                        //daSKU.SelectCommand.CommandText = " SELECT * FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE SKU_ID IN(" + "\'" + sKUModelo.sku_id + "\'" + ") ";

                        daSKU.SelectCommand.CommandText = " SELECT product_id" +
                                                                    " ,sku_id" +
                                                                    " ,sku_id_origin" +
                                                                    " ,active" +
                                                                    " ,store_qualifier_id" +
                                                                    " ,referenceid" +
                                                                    " ,flg_lock" +
                            " FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE SKU_ID IN(" + "\'" + sKUModelo.sku_id + "\'" + ") ";
                    }

                    if (sKUModelo.reference_id != null)
                    {
                        //daSKU.SelectCommand.CommandText = " SELECT * FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE REFERENCEID IN(" + "\'" + sKUModelo.reference_id + "\'" + ") ";

                        daSKU.SelectCommand.CommandText = " SELECT product_id" +
                                                                    " ,sku_id" +
                                                                    " ,sku_id_origin" +
                                                                    " ,active" +
                                                                    " ,store_qualifier_id" +
                                                                    " ,referenceid" +
                                                                    " ,flg_lock" +
                            " FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE REFERENCEID IN(" + "\'" + sKUModelo.reference_id + "\'" + ") ";
                    }

                    if (sKUModelo.store_qualifier_id != null)
                    {
                        daSKU.SelectCommand.CommandText = " SELECT product_id" +
                                                                    " ,sku_id" +
                                                                    " ,sku_id_origin" +
                                                                    " ,active" +
                                                                    " ,store_qualifier_id" +
                                                                    " ,referenceid" +
                                                                    " ,flg_lock" +
                            " FROM ac_admin.ecma_sku_mp_related_sku_seller WHERE STORE_QUALIFIER_ID IN(" + "\'" + sKUModelo.store_qualifier_id.Trim() + "\'" + ") ";
                    }

                 
                    dtSKU = new DataTable();

                    daSKU.Fill(dtSKU);


                    /**/
                    DataColumn dcNumero = new DataColumn("Número", typeof(string));
                    DataColumn dcProductId = new DataColumn("Product Id", typeof(string));
                    DataColumn dcSkuId = new DataColumn("Sku Id", typeof(string));
                    DataColumn dcSkuOrigin = new DataColumn("Sku Id Origin", typeof(string));
                    DataColumn dcActive = new DataColumn("Active", typeof(string));
                    DataColumn dcLogista = new DataColumn("Logista", typeof(string));
                    DataColumn dcReferenceId = new DataColumn("Reference ID", typeof(string));
                    DataColumn dcGlagLock = new DataColumn("Flag Lock", typeof(string));
                    dtSKUs.Columns.AddRange(new DataColumn[] { dcNumero, dcProductId, dcSkuId, dcSkuOrigin, dcActive, dcLogista, dcReferenceId, dcGlagLock });

                    int count = 0;

                    foreach(DataRow drSku in dtSKU.Rows)
                    {
                        count ++;

                        dtSKUs.Rows.Add(count, drSku[0], drSku[1], drSku[2], drSku[3], drSku[4], drSku[5], drSku[6]);

                        //if (drSku.ToString().Length != 0)
                        //{
                            
                        //}

                    }
                }
                else
                {
                    loginModelo.Logado = false;
                }

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSKUs;
        }

        public Boolean AtivarFlagLock(LoginModelo loginModelo, SKUModelo sKUModelo)
        {
            conexaoADPRD = new OracleConnection();
            bool SKUAlterado = false;

            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.ReadCommitted);

                cmdSKU = new OracleCommand();
                cmdSKU.Connection = conexaoADPRD;
                cmdSKU.CommandText = " UPDATE AC_ADMIN.ECMA_SKU_MP_RELATED_SKU_SELLER " +
                                            " SET FLG_LOCK = 'Y', " +
                                            " ACTIVE = 'N' " +
                                        " WHERE referenceid IN (" + sKUModelo.reference_id + ") AND STORE_QUALIFIER_ID IN (" + sKUModelo.store_qualifier_id + ")";
                string sCommand = cmdSKU.ExecuteReader().ToString();

                transaction.Commit();

                SKUAlterado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return SKUAlterado;
        }

        //Ainda não concluído - Segundo o Diego, isso é feito pelo time de Negócio
        public Boolean DesativarTodosProdutosLoja(LoginModelo loginModelo, int idSeller)
        {
            conexaoADPRD = new OracleConnection();
            bool SKUAlterado = false;

            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.ReadCommitted);

                cmdSKU = new OracleCommand();
                cmdSKU.Connection = conexaoADPRD;
                cmdSKU.CommandText = " UPDATE AC_ADMIN.ECMA_SKU_STORE_STATUS " +
                                        " SET Status = 'N', LAST_UPDATE_DT = sysdate " +
                                        "WHERE sku_id in( " +
                                                        " SELECT sku_id from AC_ADMIN.ecma_sku_mp_related_sku_seller WHERE store_qualifier_id = " + idSeller + "  and active = 'Y' )";
                string sCommand = cmdSKU.ExecuteReader().ToString();

                cmdDesativarSku = new OracleCommand();
                cmdDesativarSku.Connection = conexaoADPRD;
                cmdDesativarSku.CommandText = "UPDATE AC_ADMIN.ecma_sku_mp_related_sku_seller " +
                                                " SET Active = 'N' " +
                                                " WHERE store_qualifier_id = " + idSeller + " and active = 'Y'; ";

                string sSkuDesativar = cmdDesativarSku.ExecuteReader().ToString();



                transaction.Commit();

                SKUAlterado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return SKUAlterado;
        }
    }
}
