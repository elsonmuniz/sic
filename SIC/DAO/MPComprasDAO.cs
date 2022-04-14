using System;
//using System.Collections.Generic;
//using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
//using MongoDB.Driver.Linq;
using System.Configuration;
using SIC.Modelo;
using MongoDB.Bson.Serialization.Serializers;

using System.IO;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;


namespace SIC.DAO
{
    public  class MPComprasDAO
    {
        MPComprasModelo mPComprasModelo;



        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConexaoMongoDB"];
            }
        }
        public MPComprasModelo PesquisarAsync(Int64 idSeller)
        {
     
            //23860499801
           
            var dbClient = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
            IMongoDatabase db = dbClient.GetDatabase("mp-compras");
            
            var carros = db.GetCollection<BsonDocument>("compra");            
            var filter =  Builders<BsonDocument>.Filter.Eq("id", idSeller);
            var doc =  carros.Find(filter).FirstOrDefault();

            

            mPComprasModelo = new MPComprasModelo();
            MPComprasModelo.Status mPstatus = new MPComprasModelo.Status();
            List<MPComprasModelo> listModelo = new List<MPComprasModelo>();
            List<MPComprasModelo.Status> listModeloStatus = new List<MPComprasModelo.Status>();

            //orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

            //mPComprasModelo = JsonConvert.DeserializeObject<MPComprasModelo>(doc.Values);

            //Passando valroe Json para Objeto MPModelo
            mPComprasModelo._id = doc.GetValue("_id").ToInt64();
            mPComprasModelo.Id = doc.GetValue("id").ToInt64();
            mPComprasModelo.DataCriacaoDocumento = ((DateTime)doc.GetValue("dataCriacaoDocumento"));
            mPComprasModelo.DataCriacaoDocumento = ((DateTime)doc.GetValue("dataModificacaoDocumento"));
            mPComprasModelo.IdCompraBandeira = doc.GetValue("idCompraBandeira").ToInt64();
            mPComprasModelo.IdUnidadeNegocio = doc.GetValue("idUnidadeNegocio").ToInt32();
            mPComprasModelo.IdCanalVenda = doc.GetValue("idCanalVenda").ToString();
            mPComprasModelo.Data = ((DateTime)doc.GetValue("data"));
            mPComprasModelo.Valor = doc.GetValue("valor").ToDouble();
            mPComprasModelo.ValorFrete = doc.GetValue("valorFrete").ToDouble();
            mPComprasModelo.Desconto = doc.GetValue("desconto").ToDouble();
            mPComprasModelo.ValorTotal = doc.GetValue("valorTotal").ToDouble();
            mPComprasModelo.SplitPagamento = doc.GetValue("splitPagamento").ToBoolean();

            //Pegando os valores do statuso do pedido do BsonDocumentElement
            mPstatus.Id = doc["status"].AsBsonDocument["id"].ToString();
            mPstatus.descricao = doc["status"].AsBsonDocument["descricao"].ToString();
            mPstatus.dataPagamento = ((DateTime)doc["status"].AsBsonDocument["dataPagamento"]);

            //Passando os valores do statuso do pedido
            mPComprasModelo.status = mPstatus;

            //listModelo.AddRange(new MPComprasModelo[] { mPComprasModelo });

            
            return mPComprasModelo;
        }

        // private methods
        private BsonDocument Deserialize(byte[] bson, PartiallyRawBsonDocumentSerializer serializer)
        {
            using (var stream = new MemoryStream(bson))
            using (var reader = new BsonBinaryReader(stream))
            {
                var context = BsonDeserializationContext.CreateRoot(reader);
                return serializer.Deserialize(context);
            }
        }

    }
}
