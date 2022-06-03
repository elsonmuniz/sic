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

        //*********** Elements ******************
        List<BsonValue> listElements = new List<BsonValue>();
        public void setElement(BsonValue listElement)
        {
            this.listElements.Add(listElement);
        }
        //Valida se o nome do campo existe não dar erro
        public String getElement(String sElement)
        {
            foreach (var itemTransaction in listElements)
            {
                if (itemTransaction.IsBsonDocument == true)
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
            }

            return "";
        }
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

                        this.listElements.Clear();

                        this.setElement(itemAjuste);

                        //Criação de variáveis para verificar se as TAGs existem nos Elements do Payload    
                        String s_Id = this.getElement("_id");
                        if (s_Id.Length != 0)
                        {
                            ajustesModelo._id = itemAjuste.GetElement("_id").Value.ToString();
                        }

                        String sIdLojista = this.getElement("idLojista");
                        if (sIdLojista.Length != 0)
                        {
                            ajustesModelo.idLojista = itemAjuste.GetElement("idLojista").Value.ToInt64();
                        }

                        String sNomeLojista = this.getElement("nomeLojista");
                        if (sNomeLojista.Length != 0)
                        {
                            ajustesModelo.nomeLojista = itemAjuste.GetElement("nomeLojista").Value.ToString();
                        }

                        String sIdBandeira = this.getElement("idBandeira");
                        if (sIdBandeira.Length != 0)
                        {
                            ajustesModelo.idBandeira = itemAjuste.GetElement("idBandeira").Value.ToInt32();
                        }

                        String sDataLiberacao = this.getElement("dataLiberacao");
                        if (sDataLiberacao.Length != 0)
                        {
                            ajustesModelo.dataLiberacao = Convert.ToDateTime(itemAjuste.GetElement("dataLiberacao").Value);
                        }

                        String sTipoAjuste = this.getElement("tipoAjuste");
                        if (sTipoAjuste.Length != 0)
                        {
                            ajustesModelo.tipoAjuste = itemAjuste.GetElement("tipoAjuste").Value.ToInt32();
                        }

                        String sValorAjuste = this.getElement("valorAjuste");
                        if (sValorAjuste.Length != 0)
                        {
                            ajustesModelo.valorAjuste = itemAjuste.GetElement("valorAjuste").Value.ToString();
                        }

                        String sMotivoAjustes = this.getElement("motivoAjustes");
                        if (sMotivoAjustes.Length != 0)
                        {
                            ajustesModelo.motivoAjustes = itemAjuste.GetElement("motivoAjustes").Value.ToInt32();
                        }

                        String sMotivoAjustesDescricao = this.getElement("motivoAjustesDescricao");
                        if (sMotivoAjustesDescricao.Length != 0)
                        {
                            ajustesModelo.motivoAjustesDescricao = itemAjuste.GetElement("motivoAjustesDescricao").Value.ToString();
                        }

                        String sNumeroPedido = this.getElement("numeroPedido");
                        if (sNumeroPedido.Length != 0)
                        {
                            ajustesModelo.numeroPedido = itemAjuste.GetElement("numeroPedido").Value.ToInt64();
                        }

                        String sStatus = this.getElement("status");
                        if (sStatus.Length != 0)
                        {
                            ajustesModelo.status = itemAjuste.GetElement("status").Value.ToString();
                        }

                        String sUsuarioLogado = this.getElement("usuarioLogado");
                        if (sUsuarioLogado.Length != 0)
                        {
                            ajustesModelo.usuarioLogado = itemAjuste.GetElement("usuarioLogado").Value.ToString();
                        }

                        String sDeveGerarGatilho = this.getElement("deveGerarGatilho");
                        if (sDeveGerarGatilho.Length != 0)
                        {
                            ajustesModelo.deveGerarGatilho = itemAjuste.GetElement("deveGerarGatilho").Value.ToBoolean();
                        }

                        String sVisivelApenasAnalistas = this.getElement("visivelApenasAnalistas");
                        if (sVisivelApenasAnalistas.Length != 0)
                        {
                            ajustesModelo.visivelApenasAnalistas = itemAjuste.GetElement("visivelApenasAnalistas").Value.ToBoolean();
                        }

                        String s_Class = this.getElement("_class");
                        if (s_Class.Length != 0)
                        {
                            ajustesModelo._class = itemAjuste.GetElement("_class").Value.ToString();
                        }

                        String sCodigoGetnet = this.getElement("codigoGetnet");
                        if (sCodigoGetnet.Length != 0)
                        {
                            ajustesModelo.codigoGetnet = itemAjuste.GetElement("codigoGetnet").Value.ToString();
                        }

                        String sCodigoRetorno = this.getElement("codigoRetorno");
                        if (sCodigoRetorno.Length != 0)
                        {
                            ajustesModelo.codigoRetorno = itemAjuste.GetElement("codigoRetorno").Value.ToString();
                        }

                        String sDataCriacao = this.getElement("dataCriacao");
                        if (sCodigoRetorno.Length != 0)
                        {
                            ajustesModelo.dataCriacao = Convert.ToDateTime(itemAjuste.GetElement("dataCriacao").Value);
                        }


                        

                        var vMotivoRecusa = itemAjuste.AsBsonDocument.GetValue("motivoRecusa");

                        foreach(var itemMotivoRecusa in vMotivoRecusa.AsBsonArray)
                        {
                            AjustesModelo.Motivorecusa motivoRecusa = new AjustesModelo.Motivorecusa();

                            this.listElements.Clear();


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
