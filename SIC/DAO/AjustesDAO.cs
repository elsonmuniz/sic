using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SIC.DAO
{
    public class AjustesDAO
    {

        //Modelo
        AjustesModelo ajustesModelo;

        //List
        List<AjustesModelo> listAjusteModelo = new List<AjustesModelo>();
        public List<AjustesModelo> PesquisarAjustes(List<Int64> listOrderid)
        {
            //Entra limpando o list
            listAjusteModelo.Clear();

            //*************************** Conexão  ***************************
            var dbClient = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
            
            //*************************** Collections MP-ADQUIRENTE ***************************
            IMongoDatabase dbMPDinheiro = dbClient.GetDatabase("mp-dinheiro");

            for(int i = 0; i < listOrderid.Count; i++)
            {
                var collectionAjuste = dbMPDinheiro.GetCollection<BsonDocument>("ajustes");
                var filterAjuste = Builders<BsonDocument>.Filter.Eq("numeroPedido", listOrderid[i]);
                var resultAjuste = collectionAjuste.Find(filterAjuste).ToList();

                

                if(resultAjuste.Count > 0)
                {
                    foreach(var itemAjuste in resultAjuste.ToList())
                    {
                        ajustesModelo = new AjustesModelo();
                        AjustesModelo.Motivorecusa[] motivorecusasArray = new AjustesModelo.Motivorecusa[resultAjuste.Count];

                        ajustesModelo._id                       = resultAjuste[i].GetElement("_id").Value.ToString();
                        ajustesModelo.idLojista                 = resultAjuste[i].GetElement("idLojista").Value.ToInt64();
                        ajustesModelo.nomeLojista               = resultAjuste[i].GetElement("nomeLojista").Value.ToString();
                        ajustesModelo.idBandeira                = resultAjuste[i].GetElement("idBandeira").Value.ToInt32();
                        ajustesModelo.dataLiberacao             = Convert.ToDateTime(resultAjuste[i].GetElement("dataLiberacao").Value);
                        ajustesModelo.tipoAjuste                = resultAjuste[i].GetElement("tipoAjuste").Value.ToInt32();
                        ajustesModelo.valorAjuste               = resultAjuste[i].GetElement("valorAjuste").Value.ToString();
                        ajustesModelo.motivoAjustes             = resultAjuste[i].GetElement("motivoAjustes").Value.ToInt32();
                        ajustesModelo.motivoAjustesDescricao    = resultAjuste[i].GetElement("motivoAjustesDescricao").Value.ToString();
                        ajustesModelo.numeroPedido              = resultAjuste[i].GetElement("numeroPedido").Value.ToInt64();
                        ajustesModelo.status                    = resultAjuste[i].GetElement("status").Value.ToString();
                        ajustesModelo.usuarioLogado             = resultAjuste[i].GetElement("usuarioLogado").Value.ToString();
                        ajustesModelo.deveGerarGatilho          = resultAjuste[i].GetElement("deveGerarGatilho").Value.ToBoolean();
                        ajustesModelo.visivelApenasAnalistas    = resultAjuste[i].GetElement("visivelApenasAnalistas").Value.ToBoolean();
                        ajustesModelo._class                    = resultAjuste[i].GetElement("_class").Value.ToString();
                        ajustesModelo.codigoGetnet              = resultAjuste[i].GetElement("codigoGetnet").Value.ToString();
                        ajustesModelo.codigoRetorno             = resultAjuste[i].GetElement("codigoRetorno").Value.ToString();
                        ajustesModelo.dataCriacao               = Convert.ToDateTime(resultAjuste[i].GetElement("dataCriacao").Value);

                        var vMotivoRecusa = itemAjuste.AsBsonDocument.GetValue("motivoRecusa");

                        foreach(var itemMotivoRecusa in vMotivoRecusa.AsBsonArray)
                        {
                            AjustesModelo.Motivorecusa motivoRecusa = new AjustesModelo.Motivorecusa();
                            motivoRecusa.statusNoMomentoDaRecusa = itemMotivoRecusa["statusNoMomentoDaRecusa"].ToString();
                            motivoRecusa.dataDaRecusa = Convert.ToDateTime(itemMotivoRecusa["dataDaRecusa"]);

                            motivorecusasArray[0] = motivoRecusa;
                        }
                        

                        ajustesModelo.setMotivoRecusa(motivorecusasArray);



                        this.listAjusteModelo.Add(ajustesModelo);
                    }
                }
            }

            return listAjusteModelo;

        }
    }
}
