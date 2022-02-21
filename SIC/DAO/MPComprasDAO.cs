using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Configuration;
using SIC.Modelo;

namespace SIC.DAO
{
    public  class MPComprasDAO
    {
        //MPComprasModelo mPComprasModelo;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConexaoMongoDB"];
            }
        }

        
      


        public IEnumerable<MPComprasModelo> Pesquisar(Int64 idSeller)
        {

            MongoClient cliente = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("mp-compras");

            var colecao = database.GetCollection("compra");

            if(server.State != MongoServerState.Connected)
            {
                server.Connect();
            }
           
                var query = from e in colecao.AsQueryable<MPComprasModelo>()
                            where e.id == idSeller
                            select e;

                return query; //.ToList<MPComprasModelo>();
            
        }



        //        //MongoClient cliente = new MongoClient("mongodb://suporte:suporte@mp-lojista-mongo-prd001.dc.nova:27017,mp-lojista-mongo-prd002.dc.nova:27017,mp-lojista-mongo-prd003.dc.nova:27017/mp-lojista?replicaSet=rsMpLojista&readPreference=secondary&connectTimeoutMS=10000&authSource=mp-lojista&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-Lojista+-+imported+on+10+de+fev+de+2021&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-lojista&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
        //        MongoClient cliente = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");

        //        //MongoClient cliente = new MongoClient("mongodb://suporte:suporte@mp-lojista-mongo-prd001.dc.nova:27017,mp-lojista-mongo-prd002.dc.nova:27017,mp-lojista-mongo-prd003.dc.nova:27017/mp-lojista?replicaSet=rsMpLojista&readPreference=secondary&connectTimeoutMS=10000&authSource=mp-lojista&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-Lojista+-+imported+on+10+de+fev+de+2021&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-lojista&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
        //        //var list = cliente.ListDatabases().ToList();

        //        //23699889001

        //MongoServer server = cliente
        //        //MongoDatabase database = server.GetDatabase("mp-lojista");
        //        var database = cliente.GetDatabase("mp-compras");


        //        IMongoCollection<MPComprasModelo> mongoCollection = database.GetCollection<MPComprasModelo>("mp-compras");
        //        //var contatosLista = database.GetCollection<MPComprasModelo>("compra");
        //        //var contatosLista = database.GetCollection("compra");

        //        //var query = from e in contatosLista.AsQueryable<MPComprasModelo>()
        //        //            where e.Id == id
        //        //            select e;

        //        //mPComprasModelo = JsonConvert.DeserializeObject<MPComprasModelo>(query);

        //        //contatosLista.qu

        //        return await contatosLista.ToList<MPComprasModelo>();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Erro" + ex.Message);
        //    }



        //}

    }
}
