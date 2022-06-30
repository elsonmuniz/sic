using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;

namespace SIC.DAO
{
    public class UsuarioExternoDAO
    {
        //Datatable
        DataTable dtusuario;

        //Modelo
        UsuarioExternoModelo usuarioExternoModelo;

        List<UsuarioExternoModelo> listUsuarioModelo = new List<UsuarioExternoModelo>();

        public UsuarioExternoModelo PesquisarUsuarioExterno(UsuarioExternoModelo usuarioExternoModelo)
        {
            dtusuario = new DataTable();

            try
            {
                //HOMOLOGAÇÃO
                //var dbClient = new MongoClient("mongodb://localhost:27017/?serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&3t.uriVersion=3&3t.connection.name=TesteLocal&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");

                //HLG
                //var dbClient = new MongoClient("mongodb://svc_mktplace_alf:Z1qvUA34UPz@mdbh-mktp-2.dc.nova:27017/mp-alf?readPreference=nearest&serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&authSource=mp-alf&authMechanism=SCRAM-SHA-256&3t.uriVersion=3&3t.connection.name=MP-ALF+-+HLG&3t.databases=mp-alf&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");

                //var dbClient = new MongoClient("mongodb://svc_mktplace:*i4pW1X%23Vp87B@mdbp-mktplace-1.dc.nova:27017,mdbp-mktplace-2.dc.nova:27017,mdbp-mktplace-3.dc.nova:27017/mp-alf?readPreference=nearest&serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-256&3t.uriVersion=3&3t.connection.name=PLATAFORMAP&3t.defaultColor=208,60,60&3t.databases=mp-alf&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");

                //Produção
                var dbClient = new MongoClient("mongodb://svc_mktplace:*i4pW1X%23Vp87B@mdbp-mktplace-1.dc.nova:27017,mdbp-mktplace-2.dc.nova:27017,mdbp-mktplace-3.dc.nova:27017/mp-alf?readPreference=nearest&serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=PLATAFORMAP&3t.defaultColor=208,60,60&3t.databases=mp-alf&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
                IMongoDatabase db = dbClient.GetDatabase("mp-alf");

                //vendas3@modertech.com.br

                // *************************** MP- Plataforma ***************************
                var mpAlfCollection = db.GetCollection<BsonDocument>("usuariosExternos");


                List<BsonDocument> listResult = new List<BsonDocument>();

                if(usuarioExternoModelo.email != null)
                {
                    
                    var filterUsuarioExterno = Builders<BsonDocument>.Filter.Eq("email",  usuarioExternoModelo.email);
                    
                    listResult = mpAlfCollection.Find(filterUsuarioExterno).ToList();

                    var teste = mpAlfCollection.Find(filterUsuarioExterno);

                    
                }

                if(usuarioExternoModelo.usuario != null)
                {
                    var filterUsuarioExterno = Builders<BsonDocument>.Filter.Eq("usuario", usuarioExternoModelo.usuario);
                    
                    listResult = mpAlfCollection.Find(filterUsuarioExterno).ToList();
                }

                if(listResult.Count > 0)
                {
                    foreach(var itemUsuario in listResult.ToArray())
                    {
                        usuarioExternoModelo._id = ObjectId.Parse(itemUsuario["_id"].AsBsonValue.ToString());
                        usuarioExternoModelo.usuario = itemUsuario["usuario"].AsBsonValue.ToString();
                        usuarioExternoModelo.cpf = itemUsuario["cpf"].AsBsonValue.ToString();
                        usuarioExternoModelo.nome = itemUsuario["nome"].AsBsonValue.ToString();
                        usuarioExternoModelo.sobrenome = itemUsuario["sobrenome"].AsBsonValue.ToString();
                        usuarioExternoModelo.email = itemUsuario["email"].AsBsonValue.ToString();
                        usuarioExternoModelo.senha = itemUsuario["senha"].AsBsonValue.ToString();
                        usuarioExternoModelo.inativo = ((bool)itemUsuario["inativo"].AsBsonValue);
                        usuarioExternoModelo.modificadoPor = itemUsuario["modificadoPor"].AsBsonValue.ToString();
                        usuarioExternoModelo.dataAtualizacao = Convert.ToDateTime(itemUsuario["dataAtualizacao"].AsBsonValue);
                        usuarioExternoModelo.dataCriacao = Convert.ToDateTime(itemUsuario["dataCriacao"].AsBsonValue);

                        var teste = itemUsuario["lojas"].AsBsonArray;

                        UsuarioExternoModelo.Loja[] lojaArray = new UsuarioExternoModelo.Loja[1];

                        foreach(var lojaItem in teste.Values.ToArray())
                        {
                            UsuarioExternoModelo.Loja loja = new UsuarioExternoModelo.Loja();

                            loja.nome = lojaItem[0].ToString();
                            loja.idLoja = lojaItem[1].ToString();

                            lojaArray[0] = loja;

                            usuarioExternoModelo.setLoja(lojaArray);

                        }
                    }
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioExternoModelo;
        }

        public Boolean IncluirUsuarioExternoTeste(UsuarioExternoModelo listUsuarioExternoModelo)
        {
            

            try
            {
                /*
                 Teste Transação
                 */
                //var dbClientCompraTeste = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                //IMongoDatabase dataBaseGatilhoTeste = dbClientCompraTeste.GetDatabase("mp-adquirente");
                //IMongoCollection<TransacoesModelo> colNew = dataBaseGatilhoTeste.GetCollection<TransacoesModelo>("transacoes");

                //List<TransacoesModelo> listTransacaoModelo = new List<TransacoesModelo>();

                //for (int i = 0; i < listAjustesModelo.Count; i++)
                //{
                //    var filtro = Builders<TransacoesModelo>.Filter.Eq(e => e.idEntrega, 29751187401);
                //    listTransacaoModelo.AddRange(colNew.Find(filtro).ToList());
                //}

                //HOMOLOGAÇÃO
                var dbClientCompraTeste = new MongoClient("mongodb://localhost:27017/?serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&3t.uriVersion=3&3t.connection.name=TesteLocal&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                IMongoDatabase dataBaseGatilhoTeste = dbClientCompraTeste.GetDatabase("mp-alf");
                IMongoCollection<UsuarioExternoModelo> colNew = dataBaseGatilhoTeste.GetCollection<UsuarioExternoModelo>("usuariosExternos");

                colNew.InsertOne(listUsuarioExternoModelo);

                //for (int i = 0; i < listUsuarioExternoModelo.Count; i++)
                //{
                //    usuarioExternoModelo = new UsuarioExternoModelo();

                //    usuarioExternoModelo = listUsuarioExternoModelo[i];

                //    colNew.InsertOne(usuarioExternoModelo);

                //    return true;

                //}


                //colNew.UpdateOne(ajustesModelo);
                //colNew.InsertOne(ajustesModelo);
                //colNew.UpdateOneAsync(trackingComissionamentoModelo);

            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        public async Task<Boolean> AlterarDadosUsuarioExterno(UsuarioExternoModelo listAjustesModelo)
        {
            try
            {
                
                //HOMOLOGAÇÃO
                //var dbClient = new MongoClient("mongodb://localhost:27017/?serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&3t.uriVersion=3&3t.connection.name=TesteLocal&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");

                //HLG
                //var dbClient = new MongoClient("mongodb://svc_mktplace_alf:Z1qvUA34UPz@mdbh-mktp-2.dc.nova:27017/mp-alf?readPreference=nearest&serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&authSource=mp-alf&authMechanism=SCRAM-SHA-256&3t.uriVersion=3&3t.connection.name=MP-ALF+-+HLG&3t.databases=mp-alf&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");

                //ESCRITA PRODUÇÃO                
                var dbClient = new MongoClient("mongodb://svc_mktplace:*i4pW1X%23Vp87B@mdbp-mktplace-1.dc.nova:27017,mdbp-mktplace-2.dc.nova:27017,mdbp-mktplace-3.dc.nova:27017/mp-alf?readPreference=nearest&serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=PLATAFORMAP&3t.defaultColor=208,60,60&3t.databases=mp-alf&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");


                IMongoDatabase dataBaseGatilhoTeste = dbClient.GetDatabase("mp-alf");
                IMongoCollection<BsonDocument> colNew = dataBaseGatilhoTeste.GetCollection<BsonDocument>("usuariosExternos");


                var updmanyresult = await colNew.UpdateManyAsync(
                                                     Builders<BsonDocument>.Filter.Eq("_id", listAjustesModelo._id),
                                                     Builders<BsonDocument>.Update.Set("email", listAjustesModelo.email));

                if(updmanyresult.MatchedCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }


}
