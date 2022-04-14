using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using SIC.Modelo;

using MongoDB.Bson;
using MongoDB.Driver;
using System.IO;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;

namespace SIC.DAO
{
    public class SellerDAO
    {
        //DataTable
        DataTable dtSeller;
        DataTable dtSellerReprocessamento;

        //CONEXÃO SQLSERVER
        SqlConnection conexaoFront;

        OracleDataAdapter daSellerAD;
        SqlDataAdapter daSellerAtiva;

        //CONEXÃO ORACLE
        //Conexão - ADPRD
        OracleConnection conexaoADPRD;

        //Boolean
        Boolean sellerAtivada = false;

        //CMD
        //SqlCommand cmdSellerFront;
        OracleCommand cmdSellerAD;

        //Begin
        OracleTransaction transaction = null;
        //SqlTransaction transactionFront = null;

        public DataTable ListagemSellerFront(int IdSeller)
        {
            try
            {
                conexaoFront = Conexao.ConectarSL();
                conexaoFront.Open();

                daSellerAtiva = new SqlDataAdapter();
                daSellerAtiva.SelectCommand = new SqlCommand();
                daSellerAtiva.SelectCommand.Connection = conexaoFront;

                daSellerAtiva.SelectCommand.CommandText = "SELECT 	CB.idlojista " +
                                                                    ", CB.Nome" +
		                                                            ", CB.FlagAtiva as 'FlagAtiva_CasasBahia'   " +
		                                                            ", PF.FlagAtiva as 'FlagAtiva_PontoFrio'    " +
		                                                            ", E.FlagAtiva as 'FlagAtiva_Extra'        " +
                                                            "  FROM db_prd_ExtracaoParceiro..Lojista_Pontofrio PF, db_prd_ExtracaoParceiro..Lojista_CasasBahia CB, db_prd_ExtracaoParceiro..Lojista_Extra E " +
                                                                        " WHERE   CB.idlojista = PF.idlojista " +
                                                                                " AND CB.idlojista = E.idlojista " +                                                           
                                                                                " AND CB.idlojista in (" + IdSeller + ")";

                dtSeller = new DataTable();
                daSellerAtiva.Fill(dtSeller);

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não otivemos resposta para consulta da loja pelo banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta para consulta da loja pelo banco de dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoFront.Close();
            }

            return dtSeller;
        }

        public DataTable ListagemSellerADPRD(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;
            
            try
            {
                //conexaoADPRD.Open();

                daSellerAD = new OracleDataAdapter();
                daSellerAD.SelectCommand = new OracleCommand();
                daSellerAD.SelectCommand.Connection = conexaoADPRD;

                daSellerAD.SelectCommand.CommandText = "SELECT STORE_QUALIFIER_ID AS IdLojista" +
                                                                ", STORE_QUALIFIER_NAME as Lojista" +
                                                                ", ACTIVE as Ativo" +
                                                                ", ID_CATEGORY_SELLER AS Categoria " +
                                                        "FROM AC_ADMIN.ecad_store_qualifier where store_qualifier_id in(" + idLogista + ")"; //in(116303)";

                dtSeller = new DataTable();
                daSellerAD.Fill(dtSeller);                

            }
            catch(OracleException  e)
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

            return dtSeller;
        }

        public DataTable ListagemSellerReprocessamento(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            try
            {
                //conexaoADPRD.Open();

                daSellerAD = new OracleDataAdapter();
                daSellerAD.SelectCommand = new OracleCommand();
                daSellerAD.SelectCommand.Connection = conexaoADPRD;

                daSellerAD.SelectCommand.CommandText = "SELECT * FROM AC_ADMIN.ECMA_SKU_STORE_STATUS " +
                                                           " WHERE STORE_QUALIFIER_ID in(" + idLogista + ")";

                dtSellerReprocessamento = new DataTable();
                daSellerAD.Fill(dtSellerReprocessamento);

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

            return dtSellerReprocessamento;
        }

        //Ativar Loja passo 1
        public Boolean AtivarSellerAD(int idLojista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.Serializable);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandText = " UPDATE AC_ADMIN.ECAD_STORE_QUALIFIER " +
                                             " SET ACTIVE = 'Y', " +
                                             " COMERCIAL_STATUS = '1' WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")";
                string sCommand = cmdSellerAD.ExecuteReader().ToString();

                transaction.Commit();
                
                sellerAtivada = true;
            }
            catch (Exception)
            {

                throw;
            }

            return sellerAtivada;
        }

        //Passo 2
        //A pesquisa é no FRONT porém a atualização é no ADPRD
        public Boolean AtivarSellerFRONT(int idLojista, LoginModelo loginModelo)
        {
            conexaoFront = new SqlConnection();
            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.ConnectionTimeout = 20;
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.Serializable);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandText = " UPDATE AC_ADMIN.ECMA_STORE_QUALIFIER_SITE " +
                                               " SET UPD_DATE = sysdate " +
                                               " WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")";
                string sCommand = cmdSellerAD.ExecuteReader().ToString();
                
                

                transaction.Commit();

                sellerAtivada = true;
            }
            catch (OracleException ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro na ativação da loja." + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sellerAtivada = false;
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro na ativação da loja." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sellerAtivada = false;
            }

            return sellerAtivada;
        }

        public Boolean ReprocessarLoja(int idLojista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            try
            {
                //string s = ;
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.ReadCommitted);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandTimeout = 6000;
                cmdSellerAD.CommandType = CommandType.Text;
                cmdSellerAD.CommandText = " INSERT INTO FI.EVENTS_STREAMS(ID, OPERATION, CONTENT, CREATED_AT) " +
                                            " SELECT FI.SEQ_FI_EVENTS.NEXTVAL, 'SKU_STATUS', " + "'{" + "\"shopId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") +  "|| store_qualifier_id ||" + "'" + String.Concat("\",") +
                                            "\"skuId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") + "|| sku_id ||" + "'" + String.Concat("\",") +
                                            "\"siteId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") + "|| site_id ||" + "'\"}" + String.Concat("\',") +
                                            " SYSDATE FROM AC_ADMIN.ECMA_SKU_STORE_STATUS " +
                                                " WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")" +
                                                    "AND STORE_ID = 'NCMP' " +
                                                    "AND STORE_QUALIFIER_ID not in (select store_qualifier_id from AC_ADMIN.ECMA_SHOP_SHOP_GROUP) " +
                                                    "AND status = 'Y' and SITE_ID in ('2', '3', '4')";
                
                string sReader = cmdSellerAD.ExecuteNonQuery().ToString();
                

                transaction.Commit();

                sellerAtivada = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro " + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerAtivada;
        }

        public LojistaAdquirenteModelo PesquisarAsync(Int64 idSeller)
        {

            //23860499801

            var dbClient = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
            IMongoDatabase db = dbClient.GetDatabase("mp-adquirente");

            var carros = db.GetCollection<BsonDocument>("lojistaAdquirente");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idSeller);
            var doc = carros.Find(filter).FirstOrDefault();

            

            LojistaAdquirenteModelo lojistaAdquirenteModelo = new LojistaAdquirenteModelo();
            
            List<LojistaAdquirenteModelo.Carteira> listModelo = new List<LojistaAdquirenteModelo.Carteira>();
            

            //orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

            //mPComprasModelo = JsonConvert.DeserializeObject<MPComprasModelo>(doc.Values);

            //Passando valroe Json para Objeto MPModelo
            lojistaAdquirenteModelo._id = doc.GetValue("_id").ToInt64();
            lojistaAdquirenteModelo.nomeFantasia = doc.GetValue("nomeFantasia").ToString();
            lojistaAdquirenteModelo.razaoSocial = doc.GetValue("razaoSocial").ToString();
            lojistaAdquirenteModelo.nomeLoja = doc.GetValue("nomeLoja").ToString();
            lojistaAdquirenteModelo.numeroDocumento = doc.GetValue("numeroDocumento").ToString();
            lojistaAdquirenteModelo.nomeExibicao = doc.GetValue("nomeExibicao").ToString();

            LojistaAdquirenteModelo.Carteira[] carteira = new LojistaAdquirenteModelo.Carteira[3];

            //Percorre a TAg Element
            foreach(var cart in doc.ToBsonDocument().Elements) //doc["carteiras"].AsBsonDocument["tipoCarteiraAdquirente"].ToString())
            {
                //Identificar se é a TAG carteira
               if(cart.Name == "carteiras")
                {
                    //Passa os valores da TAG carteira
                    var teste = cart.Value;

                    int cont = 0;

                    //Percorre os valores da TAG carteira
                    foreach (var bb in teste.AsBsonArray)
                    {
                        //Preenche o objeto com os valores dos Elements
                        if (bb[0] != "STONE")
                        {
                            LojistaAdquirenteModelo.Carteira Ccarteira = new LojistaAdquirenteModelo.Carteira();

                            Ccarteira._id = bb[0].ToString();
                            Ccarteira.tipoCarteiraAdquirente = bb[1].ToString();
                            Ccarteira.site = Convert.ToInt32(bb[2]);
                            Ccarteira.repasseBloqueado = Convert.ToBoolean(bb[3]);
                            Ccarteira.ativo = Convert.ToBoolean(bb[4]);
                            Ccarteira.status = bb[5].ToString();
                            Ccarteira.statusGetnet = bb[6].ToString();
                            Ccarteira.dataIntegracao = Convert.ToDateTime(bb[7]);
                            Ccarteira.idPlanoPagamento = bb[8].ToString();
                            Ccarteira.capturaHabilitada = Convert.ToBoolean(bb[9]);

                            carteira[cont] = Ccarteira;
                            lojistaAdquirenteModelo.setCarteiras(carteira);

                            cont++;
                        }
                    }
                }
            }

            lojistaAdquirenteModelo.dataModificacao = ((DateTime)doc.GetValue("dataModificacao"));
            //lojistaAdquirenteModelo.transacaoVinculada = doc.GetValue("splitPagamento").ToString();
            lojistaAdquirenteModelo._class = doc.GetValue("_class").ToString();

            return lojistaAdquirenteModelo;
        }
    }
}
