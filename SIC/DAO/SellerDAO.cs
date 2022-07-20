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

        //Modelo
        LojistaAdquirenteModelo lojistaAdquirenteModelo;

        //List
        List<LojistaAdquirenteModelo> listLojistaAdquirenteModelo; // = new List<LojistaAdquirenteModelo>();

        //*********** Elements ******************
        List<BsonValue> listElements = new List<BsonValue>();
        public void setElement(BsonValue listElement)
        {
            this.listElements.Add(listElement);
        }
        
        
        public String getElement(String sElement)
        {
            foreach (var itemTransaction in listElements)
            {
                for (int i = 0; i < itemTransaction.AsBsonDocument.ElementCount; i++)
                {
                    var svalue = itemTransaction.AsBsonDocument.GetElement(i).Name;
                    if (svalue == sElement)
                    {
                        return sElement;
                    }
                }
            }

            return "";
        }

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

        public async Task<Boolean> ReprocessarLoja(int idLojista, LoginModelo loginModelo)
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
                
                int sReader = await cmdSellerAD.ExecuteNonQueryAsync();
                

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

        public List<LojistaAdquirenteModelo> PesquisarAsync(List<String> idSeller)
        {

            listLojistaAdquirenteModelo = new List<LojistaAdquirenteModelo>();
            //23860499801

            try
            {
                //Conexão
                var dbClient = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                var dbClientLojista = new MongoClient("mongodb://suporte:suporte@mp-lojista-mongo-prd001.dc.nova:27017,mp-lojista-mongo-prd002.dc.nova:27017,mp-lojista-mongo-prd003.dc.nova:27017/mp-lojista?replicaSet=rsMpLojista&readPreference=secondary&connectTimeoutMS=10000&authSource=mp-lojista&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-Lojista+-+imported+on+10+de+fev+de+2021&3t.databases=mp-lojista&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
                
                //Base de Dados
                IMongoDatabase db = dbClient.GetDatabase("mp-adquirente");
                IMongoDatabase dbLojista = dbClientLojista.GetDatabase("mp-lojista");

                for (int i = 0; i < idSeller.Count; i++)
                {
                    //Consulta do cadastro do lojista no MP-Dinheiro / MP-Adquirente
                    var carros = db.GetCollection<BsonDocument>("lojistaAdquirente");
                    var filter = Builders<BsonDocument>.Filter.Eq("numeroDocumento", idSeller[i]);
                    var resultSeller = carros.Find(filter).ToList();

                    //Consulta do cadastro do lojista no MP-Lojista / lojista
                    var collectionLojista = dbLojista.GetCollection<BsonDocument>("lojistas");
                    var filterLojista = Builders<BsonDocument>.Filter.Eq("numeroDocumento", idSeller[i]);
                    var resultLojista = collectionLojista.Find(filterLojista).ToList();


                    if (resultSeller != null)
                    {
                        foreach (var itemSeller in resultSeller.ToArray())
                        {
                            lojistaAdquirenteModelo = new LojistaAdquirenteModelo();

                            //List<LojistaAdquirenteModelo.Carteira> listModelo = new List<LojistaAdquirenteModelo.Carteira>();

                            this.listElements.Clear();
                            this.setElement(itemSeller);


                            //Passando valor e Json para Objeto MPModelo
                            //Criação de variáveis para verificar se as TAGs existem nos Elements do Payload    
                            String _sId = this.getElement("_id");
                            if (_sId.Length != 0)
                            {
                                lojistaAdquirenteModelo._id = itemSeller.GetValue("_id").ToInt64();
                            }

                            String sNomeFantasia = this.getElement("_id");
                            if (sNomeFantasia.Length != 0)
                            {
                                lojistaAdquirenteModelo.nomeFantasia = itemSeller.GetValue("nomeFantasia").ToString();
                            }

                            String sRazaoSocial = this.getElement("razaoSocial");
                            if (sRazaoSocial.Length != 0)
                            {
                                lojistaAdquirenteModelo.razaoSocial = itemSeller.GetValue("razaoSocial").ToString();
                            }

                            String sNomeLoja = this.getElement("nomeLoja");
                            if (sNomeLoja.Length != 0)
                            {
                                lojistaAdquirenteModelo.nomeLoja = itemSeller.GetValue("nomeLoja").ToString();
                            }

                            String sNumeroDocumento = this.getElement("numeroDocumento");
                            if (sNumeroDocumento.Length != 0)
                            {
                                lojistaAdquirenteModelo.numeroDocumento = itemSeller.GetValue("numeroDocumento").ToString();
                            }

                            //if(resultLojista.Count > 0)
                            //{
                            //    lojistaAdquirenteModelo.email = resultLojista[0].GetElement("email").Value.ToString();
                            //}
                            
                            

                            String sNomeExibicao = this.getElement("nomeExibicao");
                            if (sNomeExibicao.Length != 0)
                            {
                                lojistaAdquirenteModelo.nomeExibicao = itemSeller.GetValue("nomeExibicao").ToString();
                            }

                            String sSataModificacao = this.getElement("dataModificacao");
                            if (sSataModificacao.Length != 0)
                            {
                                lojistaAdquirenteModelo.dataModificacao = ((DateTime)itemSeller.GetValue("dataModificacao"));
                            }

                            String s_transacaoVinculada = this.getElement("transacaoVinculada");
                            if (s_transacaoVinculada.Length != 0)
                            {
                                lojistaAdquirenteModelo.transacaoVinculada = itemSeller.GetValue("transacaoVinculada").ToString();
                            }

                            String s_class = this.getElement("_class");
                            if (s_class.Length != 0)
                            {
                                lojistaAdquirenteModelo._class = itemSeller.GetValue("_class").ToString();
                            }

                            


                            //Pegando valores de Payload
                            //var carteiras = itemSeller.AsBsonDocument.GetValue("carteiras"); //.GetElement("carteiras");

                            this.listElements.Clear();
                            this.setElement(itemSeller.AsBsonDocument.GetValue("carteiras").AsBsonArray);

                            var contCarteira = itemSeller.GetValue("carteiras");// this.listElements.ToBsonDocument().Values;

                            int cont = contCarteira.AsBsonArray.Count();
                            int contadorIndiceCartei = 0;

                            //Percorrer para identificar se tem Stone para retirar a quantidade de indice
                            foreach (var itemCarteira in contCarteira.AsBsonArray)
                            {
                                if (itemCarteira["tipoCarteiraAdquirente"] == "STONE")
                                {
                                    cont = cont - 1;
                                    //itemCarteira.AsBsonArray.Remove(itemCarteira["tipoCarteiraAdquirente"]);
                                }
                            }

                            LojistaAdquirenteModelo.Carteira[] carteira = new LojistaAdquirenteModelo.Carteira[cont];

                            //Daqui pra baixo ele retira o indice do Stone acima e percorre somente as carteiras das bandeiras 2,3,4
                            foreach (var itemCarteira in contCarteira.AsBsonArray)
                                //foreach (var itemCarteira in listElements)
                                {

                                this.listElements.Clear();
                                this.setElement(itemCarteira);

                                

                                var sTTipoCarteiraAdquirente = this.getElement("tipoCarteiraAdquirente");
                                
                                if(itemCarteira["tipoCarteiraAdquirente"].ToString() != "STONE")
                                {
                                    LojistaAdquirenteModelo.Carteira Ccarteira = new LojistaAdquirenteModelo.Carteira();

                                    if (sTTipoCarteiraAdquirente.Length != 0)
                                    {
                                        Ccarteira.tipoCarteiraAdquirente = itemCarteira["tipoCarteiraAdquirente"].ToString();
                                    }

                                    var _sIdCarteira = this.getElement("_id");
                                    if (_sIdCarteira.Length != 0)
                                    {
                                        Ccarteira._id = itemCarteira["_id"].ToString();
                                    }



                                    var sSite = this.getElement("site");
                                    if (sSite.Length != 0)
                                    {
                                        Ccarteira.site = itemCarteira["site"].ToInt32();
                                    }

                                    var sRepasseBloqueado = this.getElement("repasseBloqueado");
                                    if (sRepasseBloqueado.Length != 0)
                                    {
                                        Ccarteira.repasseBloqueado = itemCarteira["repasseBloqueado"].ToBoolean();
                                    }

                                    var sAtivo = this.getElement("ativo");
                                    if (sAtivo.Length != 0)
                                    {
                                        Ccarteira.ativo = itemCarteira["ativo"].ToBoolean();
                                    }

                                    var sStatus = this.getElement("status");
                                    if (sStatus.Length != 0)
                                    {
                                        Ccarteira.status = itemCarteira["status"].ToString();
                                    }

                                    var sStatusGetnet = this.getElement("statusGetnet");
                                    if (sStatusGetnet.Length != 0)
                                    {
                                        Ccarteira.statusGetnet = itemCarteira["statusGetnet"].ToString();
                                    }

                                    var sDataIntegracao = this.getElement("dataIntegracao");
                                    if (sDataIntegracao.Length != 0)
                                    {
                                        Ccarteira.dataIntegracao = ((DateTime)itemCarteira["dataIntegracao"]);
                                    }

                                    var sIdPlanoPagamento = this.getElement("idPlanoPagamento");
                                    if (sIdPlanoPagamento.Length != 0)
                                    {
                                        Ccarteira.idPlanoPagamento = itemCarteira["idPlanoPagamento"].ToString();
                                    }

                                    var sCapturaHabilitada = this.getElement("capturaHabilitada");
                                    if (sCapturaHabilitada.Length != 0)
                                    {
                                        Ccarteira.capturaHabilitada = itemCarteira["capturaHabilitada"].ToBoolean();
                                    }

                                    carteira[contadorIndiceCartei] = Ccarteira;
                                    lojistaAdquirenteModelo.setCarteiras(carteira);

                                    contadorIndiceCartei++;

                                }

                            }

                            listLojistaAdquirenteModelo.Add(lojistaAdquirenteModelo);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lojista não cadastrado no LojistaAdquirente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                    
            }
            catch (Exception  ex)
            {
                MessageBox.Show("Erro nas TAGs do cadastro do lojista" + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //return lojistaAdquirenteModelo;
            return listLojistaAdquirenteModelo;
        }
    }
}
