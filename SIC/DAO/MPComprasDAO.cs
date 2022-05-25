using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using SIC.Modelo;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace SIC.DAO
{
    public  class MPComprasDAO
    {
        //Modelo
        MPComprasModelo mPComprasModelo;
        GatilhoModelo gatilhoModelo;
        PagamentosModelo pagamentosModelo;
        PagamentosModelo.Payload[] pagamentosPayload;
        TransacoesModelo transacoesModelo;

        //DataTable
        DataTable dtOrderFinanceiro = new DataTable("Transacao");
        DataTable dtOrderPagamento = new DataTable("Pagamento");
        DataTable dtOrderGatilho = new DataTable("Gatilho");

        //Variável privada
        private Int32 idBandeira;
        private String statusLiberacao;

        //DataSet
        DataSet dsOrderFinanceiro;

        //List
        List<OrderBandeiraModelo> listResultOrderBandeira = new List<OrderBandeiraModelo>();

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConexaoMongoDB"];
            }
        }

        List<GatilhoModelo> gatilhoModeloList = new List<GatilhoModelo>();

        public MPComprasModelo PesquisarAsync(Int64 idSeller)
        {
     
            //23860499801
           
            var dbClientCompra = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
            IMongoDatabase dataBaseCompra = dbClientCompra.GetDatabase("mp-compras");
            
            var collectionCompra = dataBaseCompra.GetCollection<BsonDocument>("compra");            
            var filterCompra =  Builders<BsonDocument>.Filter.Eq("id", idSeller);
            var resultCompra =  collectionCompra.Find(filterCompra).FirstOrDefault();

            //Instanciando Objetos locais
            mPComprasModelo = new MPComprasModelo();
            MPComprasModelo.Status mPstatus = new MPComprasModelo.Status();
            List<MPComprasModelo> listModelo = new List<MPComprasModelo>();
            List<MPComprasModelo.Status> listModeloStatus = new List<MPComprasModelo.Status>();

            
            //Passando valores Json para Objeto MPModelo
            mPComprasModelo._id                     = resultCompra.GetValue("_id").ToInt64();
            mPComprasModelo.Id                      = resultCompra.GetValue("id").ToInt64();
            mPComprasModelo.DataCriacaoDocumento    = ((DateTime)resultCompra.GetValue("dataCriacaoDocumento"));
            mPComprasModelo.DataCriacaoDocumento    = ((DateTime)resultCompra.GetValue("dataModificacaoDocumento"));
            mPComprasModelo.IdCompraBandeira        = resultCompra.GetValue("idCompraBandeira").ToInt64();
            mPComprasModelo.IdUnidadeNegocio        = resultCompra.GetValue("idUnidadeNegocio").ToInt32();
            mPComprasModelo.IdCanalVenda            = resultCompra.GetValue("idCanalVenda").ToString();
            mPComprasModelo.Data                    = ((DateTime)resultCompra.GetValue("data"));
            mPComprasModelo.Valor                   = resultCompra.GetValue("valor").ToDouble();
            mPComprasModelo.ValorFrete              = resultCompra.GetValue("valorFrete").ToDouble();
            mPComprasModelo.Desconto                = resultCompra.GetValue("desconto").ToDouble();
            mPComprasModelo.ValorTotal              = resultCompra.GetValue("valorTotal").ToDouble();
            mPComprasModelo.SplitPagamento          = resultCompra.GetValue("splitPagamento").ToBoolean();

            //Pegando os valores do statuso do pedido do BsonDocumentElement
            mPstatus.Id                             = resultCompra["status"].AsBsonDocument["id"].ToString();
            mPstatus.Descricao                      = resultCompra["status"].AsBsonDocument["descricao"].ToString();
            mPstatus.DataPagamento                  = ((DateTime)resultCompra["status"].AsBsonDocument["dataPagamento"]);

            //Passando os valores do statuso do pedido
            mPComprasModelo.status = mPstatus;

            return mPComprasModelo;
        }

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

        //********************************************
        List<PagamentosModelo> listPagamentos = new List<PagamentosModelo>();
        public void setListPagamentos(PagamentosModelo listpagamentos)
        {
            this.listPagamentos.Add(listpagamentos);
        }

        //Cria List de Gatilhos
        List<GatilhoModelo> listGatilhos = new List<GatilhoModelo>();
        public void setListGatilhos(GatilhoModelo listgatilhos)
        {
            this.listGatilhos.Add(listgatilhos);
        }

        List<TransacoesModelo> listTransacoes = new List<TransacoesModelo>();
        public void setTransacoes(TransacoesModelo listtransacoes)
        {
            this.listTransacoes.Add(listtransacoes);
        }

        //ListDescobreBaneira
        List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

        // private methods
        public DataSet ConsultarPedidoFinanceiro(List<Int64> orderId)
        {
            
            int contadorPedido = 0;
            Int64 orderIdAtual = 0;
            int contPagamento = 1;
            int contGatilho = 1;

            //Instanciando DataSet
            dsOrderFinanceiro = new DataSet("OrderFinanceiro");

            //27485514901 - Não tem Gatilho

            //Pedido em análise
            //30400966101

            //Criação da DataTable TRANSAÇÃO para retorno
            DataColumn dcNumero                 = new DataColumn("Nro", typeof(string));
            DataColumn dcIdEntrega              = new DataColumn("IdEntrega", typeof(string));
            DataColumn dcBandeira               = new DataColumn("Bandeira", typeof(string));
            DataColumn dcSite                   = new DataColumn("Site", typeof(string));
            DataColumn dcIdTransacaoGet         = new DataColumn("Id Getnet", typeof(string));
            DataColumn dcConfirmacaoPagamento   = new DataColumn("Confirmação de Pagamento", typeof(string));
            DataColumn dcDataPrevisaoPagamento  = new DataColumn("Previsão Pagto", typeof(string));
            DataColumn dcInicioCiclo            = new DataColumn("Início Ciclo", typeof(string));
            DataColumn dcFimCiclo               = new DataColumn("Fim Ciclo", typeof(string));
            DataColumn dcStatusGatilho          = new DataColumn("Tipo Transação", typeof(string));
            //DataColumn dcQtdeParcela            = new DataColumn("Qtd Parcela", typeof(string));
            DataColumn dcVarlorParcela          = new DataColumn("Valor Parcela", typeof(string));
            DataColumn dcValorPedido            = new DataColumn("Valor Pedido", typeof(string));

            //Inserindo as colunas criadas acima na tabela de Transação
            dtOrderFinanceiro.Columns.AddRange(new DataColumn[] {dcNumero, dcIdEntrega, dcBandeira, dcSite, dcIdTransacaoGet,
                                                                    dcConfirmacaoPagamento, dcDataPrevisaoPagamento, dcInicioCiclo, dcFimCiclo,
                dcStatusGatilho, dcVarlorParcela,  dcValorPedido });


            //Criação da DataTable PAGAMENTO para retorno
            DataColumn dcNumeroPagamento = new DataColumn("Número", typeof(string));
            DataColumn dcIdEntregaPagamento = new DataColumn("Id Entrega", typeof(string));
            DataColumn dcStatusOperacaoPagamento  = new DataColumn("Status Operação", typeof(string));
            DataColumn dcPontoControlePagamento = new DataColumn("Ponto Controle", typeof(string));
            DataColumn dcDataCriacaoPagamento = new DataColumn("Data Criação", typeof(string));
            DataColumn dcIdPagamentoPagamento = new DataColumn("Id Pagamento", typeof(string));

            //Inserindo as colunas criadas acima na tabela de Pagamento
            dtOrderPagamento.Columns.AddRange(new DataColumn[] {dcNumeroPagamento, dcIdEntregaPagamento, dcStatusOperacaoPagamento,
                                                                dcPontoControlePagamento, dcDataCriacaoPagamento, dcIdPagamentoPagamento});

            //Criação da DataTable GATILHO para retorno
            DataColumn dcNumeroGatilho = new DataColumn("Número", typeof(string));
            DataColumn dcIdEntregaGatilho = new DataColumn("Id Entrega", typeof(string));
            //DataColumn dcPlataformaTransacao = new DataColumn("Plataforma Transação", typeof(string));
            DataColumn dcStatusOperacaoGatilho = new DataColumn("Status Operação", typeof(string));
            DataColumn dcDataGatilhoGatilho = new DataColumn("Data Criação", typeof(string));
            DataColumn dcMotivo = new DataColumn("Motivo", typeof(string));

            //Inserindo as colunas criadas acima na tabela de Gatilhos
            dtOrderGatilho.Columns.AddRange(new DataColumn[] { dcNumeroGatilho, dcIdEntregaGatilho, dcStatusOperacaoGatilho, dcDataGatilhoGatilho, dcMotivo });
            

            try
            {
                //*************************** Conexão  ***************************
                var dbClient = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                var dbMPComprasClient = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");

                //*************************** Collections MP-ADQUIRENTE ***************************
                IMongoDatabase db = dbClient.GetDatabase("mp-adquirente");
                IMongoDatabase dbPagamento = dbClient.GetDatabase("mp-dinheiro");

                //*************************** Collections MP-COMPRAS ***************************
                IMongoDatabase dbMPCompras = dbMPComprasClient.GetDatabase("mp-compras");
                
                //Percorre todo o trajeto com um determiado pedido recebido da List deste método
                for (int i = 0; i < orderId.Count; i++)
                {
                    contadorPedido = i;
                    orderIdAtual = orderId[i];

                    //var pedido = orderIdAtual.ToString().Substring(0, 9);

                    // *************************** MP-Compra ***************************
                    var mpComprasCollection = dbMPCompras.GetCollection<BsonDocument>("compra");
                    var filterMPCompras = Builders<BsonDocument>.Filter.Eq("id", Convert.ToInt64(orderId[i].ToString().Substring(0,9)+"01"));
                    var resultMPCompras = mpComprasCollection.Find(filterMPCompras).ToList();

                    // *************************** Pagamentos ***************************
                    var pagamentoCollection = dbPagamento.GetCollection<BsonDocument>("pagamentos");
                    var filterPagamentos = Builders<BsonDocument>.Filter.Eq("idEntrega", orderId[i]);
                    var resultPagamentos = pagamentoCollection.Find(filterPagamentos).ToList();

                    //*************************** Gatilhos ***************************
                    var gatilhoCollection = db.GetCollection<BsonDocument>("gatilhos");
                    var filterGatilho = Builders<BsonDocument>.Filter.Eq("idEntrega", orderId[i]);
                    var resultGatilho = gatilhoCollection.Find(filterGatilho).ToList();

                    //*************************** Transacoes ***************************
                    var pagamentoTransacoes = dbPagamento.GetCollection<BsonDocument>("transacoes");
                    var filterTransacoes = Builders<BsonDocument>.Filter.Eq("idEntrega", orderId[i]);
                    var resultTransacoes = pagamentoTransacoes.Find(filterTransacoes).ToList();


                    /*
                     Pegar a bandeira para a consulta da GetNet no método
                     */
                    this.idBandeira = resultMPCompras[0].GetElement("idUnidadeNegocio").Value.ToInt32(); // ToBsonDocument().GetElement("idUnidadeNegocio").Value.ToInt32(); // idBandeira.ToBsonDocument("idUnidadeNegocio").AsBsonArray[i].AsBsonValue; // ("idUnidadeNegocio").ToInt32();
                    
                    if(resultGatilho.Count > 0)
                    {
                        foreach (var itemGatilho in resultGatilho.ToArray())
                        {
                            //Instancia um objeto de Gatilho
                            gatilhoModelo = new GatilhoModelo();

                            //Cria um Arry de Gatilho/Pagamento
                            GatilhoModelo.Liberacaopagamentodto[] liberacao = new GatilhoModelo.Liberacaopagamentodto[2];

                            //Sempre inicia limpando o list
                            this.listElements.Clear();

                            //Inserindo objeto no list para validação dos campos retornados
                            this.setElement(itemGatilho);

                            //Criação de variáveis para verificar se as TAGs existem nos Elements do Payload    
                            String sIdEntregaGatilho = this.getElement("idEntrega");
                            if (sIdEntregaGatilho.Length != 0)
                            {
                                gatilhoModelo.IdEntrega = itemGatilho.GetValue("idEntrega").ToInt64();
                            }

                            gatilhoModelo.setLiberacaoPagamentoDTO(liberacao);

                            String sDataGatilho = this.getElement("dataGatilho");
                            if (sDataGatilho.Length != 0)
                            {
                                gatilhoModelo.DataGatilho = ((DateTime)itemGatilho.GetValue("dataGatilho"));
                            }

                            String sIdEntrega = this.getElement("idEntrega");
                            if (sIdEntrega.Length != 0)
                            {
                                gatilhoModelo.IdEntrega = itemGatilho.GetValue("idEntrega").ToInt64();
                            }

                            String sRetentativa = this.getElement("retentativa");
                            if (sRetentativa.Length != 0)
                            {
                                gatilhoModelo.Retentativa = itemGatilho.GetValue("retentativa").ToInt32();
                            }

                            String sstatusOperacao = this.getElement("statusOperacao");
                            if (sstatusOperacao.Length != 0)
                            {
                                gatilhoModelo.StatusOperacao = itemGatilho.GetValue("statusOperacao").ToString();
                            }

                            String sProcessado = this.getElement("processado");
                            if (sProcessado.Length != 0)
                            {
                                gatilhoModelo.Processado = itemGatilho.GetValue("processado").ToBoolean();
                            }

                            String sMotivos = this.getElement("motivos");
                            if(sMotivos.Length != 0)
                            {
                                var gatilho = itemGatilho.AsBsonDocument.GetElement("motivos");

                                GatilhoModelo.Motivos motivos = new GatilhoModelo.Motivos();
                                motivos.zero = gatilho.Value.AsBsonArray[0].ToString();
                                motivos.um = gatilho.Value.AsBsonArray[1].ToString();
                                motivos.dois = gatilho.Value.AsBsonArray[2].ToString();
                                motivos.tres = gatilho.Value.AsBsonArray[3].ToString();

                                GatilhoModelo.Motivos[] motivosArray = new GatilhoModelo.Motivos[1];
                                motivosArray[0] = motivos;

                                gatilhoModelo.setMotivos(motivosArray);
                            }
                            

                            //var tres = gatilho.Value.AsBsonArray[3].ToString();

                            String s_class = this.getElement("_class");
                            if (s_class.Length != 0)
                            {
                                gatilhoModelo._class = itemGatilho.GetValue("_class").ToString();
                            }

                            if(gatilhoModelo.motivos != null)
                            {
                                //Insere os dados lidos acima da tabela Gatilho para retorno em tela
                                dtOrderGatilho.Rows.Add(contGatilho, gatilhoModelo.IdEntrega.ToString(), gatilhoModelo.StatusOperacao, gatilhoModelo.DataGatilho, gatilhoModelo.motivos[0].tres);
                            }
                            else
                            {
                                dtOrderGatilho.Rows.Add(contGatilho, gatilhoModelo.IdEntrega.ToString(), gatilhoModelo.StatusOperacao, gatilhoModelo.DataGatilho, "");
                            }
                            

                            contGatilho++;

                        }
                    }
                    else
                    {
                        dtOrderGatilho.Rows.Add(contGatilho, orderId[i].ToString(), "Sem gatilho", "Sem gatilho");

                        contGatilho++;
                    }
                    //Percorre o resultado de Gatilho
                    

                    //PREENCHIMENTO DOS OBJETOS CONFOMRE RETORNO DO MONGODB ACIMA


                    //gatilhoModelo = new GatilhoModelo();
                    GatilhoModelo.Dadosparapagamento[] dadosPagto = new GatilhoModelo.Dadosparapagamento[2];


                    //Pagamentos
                    pagamentosPayload = new PagamentosModelo.Payload[2];

                    if(resultPagamentos.Count > 0)
                    {
                        //Percorredo a consulta de Pagamentos
                        foreach (var pagamento in resultPagamentos.ToArray())
                        {

                            pagamentosModelo = new PagamentosModelo();

                            this.listElements.Clear();
                            this.setElement(pagamento);


                            String _idPagamento = this.getElement("_id");
                            if (_idPagamento.Length != 0)
                            {
                                pagamentosModelo._id = pagamento.GetElement("_id").ToString();
                            }

                            String idEntregaPagamento = this.getElement("idEntrega");
                            if (idEntregaPagamento.Length != 0)
                            {
                                pagamentosModelo.idEntrega = pagamento.GetElement("idEntrega").Value.ToInt64();
                            }

                            String statusOperacaoPgamento = this.getElement("statusOperacao");
                            if (statusOperacaoPgamento.Length != 0)
                            {
                                pagamentosModelo.statusOperacao = pagamento.GetElement("statusOperacao").Value.ToString();
                            }

                            String idPagamentoPgamento = this.getElement("idPagamentoArranjo");
                            if (idPagamentoPgamento.Length != 0)
                            {
                                pagamentosModelo.idPagamentoArranjo = pagamento.GetElement("idPagamentoArranjo").Value.ToString();
                            }

                            String pontoControlePgamento = this.getElement("pontoControle");
                            if (pontoControlePgamento.Length != 0)
                            {
                                pagamentosModelo.pontoControle = pagamento.GetElement("pontoControle").Value.ToString();
                            }

                            String createdDatePgamento = this.getElement("createdDate");
                            if (createdDatePgamento.Length != 0)
                            {
                                pagamentosModelo.createdDate = Convert.ToDateTime(pagamento.GetElement("createdDate").Value);
                            }

                            String lastModifiedDatePgamento = this.getElement("lastModifiedDate");
                            if (lastModifiedDatePgamento.Length != 0)
                            {
                                pagamentosModelo.lastModifiedDate = Convert.ToDateTime(pagamento.GetElement("lastModifiedDate").Value);
                            }

                            String _classPgamento = this.getElement("_class");
                            if (_classPgamento.Length != 0)
                            {
                                pagamentosModelo._class = pagamento.GetElement("_class").Value.ToString();
                            }

                            //Pegando valores de Payload
                            var payload = pagamento.AsBsonDocument.GetValue("payload");

                            //O loop tá entrando em payload 9 vezes, fazer essa correção para ficar OK.69.
                            PagamentosModelo.Payload payloadModelo = new PagamentosModelo.Payload();

                            this.listElements.Clear();
                            this.setElement(payload);

                            //Criação de variáveis para verificar se as TAGs existem nos Elements do Payload    
                            String sIdLojista = this.getElement("idLojista");

                            if (sIdLojista == "idLojista")
                            {
                                payloadModelo.idLojista = payload["idLojista"].ToInt64();
                            }

                            String sIdEntrega = this.getElement("idEntrega");
                            if (sIdEntrega.Length != 0)
                            {
                                payloadModelo.idEntrega = payload["idEntrega"].ToInt64();
                            }

                            String sIdBandeira = this.getElement("idBandeira");
                            if (sIdBandeira.Length != 0)
                            {
                                payloadModelo.idBandeira = payload["idBandeira"].ToInt32();
                            }

                            String sDataTracking = this.getElement("dataTracking");
                            if (sDataTracking.Length != 0)
                            {
                                payloadModelo.dataTracking = ((DateTime)payload["dataTracking"]);
                            }

                            String sPlataformaTransacao = this.getElement("plataformaTransacao");
                            if (sPlataformaTransacao.Length != 0)
                            {
                                payloadModelo.plataformaTransacao = payload["plataformaTransacao"].ToString();
                            }

                            String sPorcentagemComissao = this.getElement("porcentagemComissao");
                            if (sPorcentagemComissao.Length != 0)
                            {
                                payloadModelo.porcentagemComissao = payload["porcentagemComissao"].ToString();
                            }

                            String sDataDaCompra = this.getElement("dataDaCompra");
                            if (sDataDaCompra.Length != 0)
                            {
                                payloadModelo.dataDaCompra = ((DateTime)payload["dataDaCompra"]);
                            }

                            //Verificando se o documento é um BsonDocument
                            if (payload.IsBsonDocument == true)
                            {
                                foreach (var pay in payload.AsBsonDocument)
                                {

                                    if (pay.Name == "dadosParaPagamento")
                                    {
                                        var pl = pay.Value;
                                        var dadosPagamentoCount = pl.AsBsonArray.Count;
                                        int countDadosPagamento = 0;
                                        PagamentosModelo.Dadosparapagamento[] dadosParaPagamentoModelo = new PagamentosModelo.Dadosparapagamento[dadosPagamentoCount];
                                        foreach (var item in pl.AsBsonArray)
                                        {
                                            PagamentosModelo.Dadosparapagamento dadosparapagamento = new PagamentosModelo.Dadosparapagamento();

                                            this.listElements.Clear();

                                            this.setElement(item);


                                            String _idPayload = this.getElement("idPagamento");
                                            if (_idPayload.Length != 0)
                                            {
                                                dadosparapagamento.idPagamento = item["idPagamento"].ToString();
                                            }

                                            String quantidadeParcelasPayload = this.getElement("quantidadeParcelas");
                                            if (quantidadeParcelasPayload.Length != 0)
                                            {
                                                dadosparapagamento.quantidadeParcelas = item["quantidadeParcelas"].ToInt32();
                                            }

                                            String valorCentavosPayload = this.getElement("valorCentavos");
                                            if (valorCentavosPayload.Length != 0)
                                            {
                                                dadosparapagamento.valorCentavos = item["valorCentavos"].ToDecimal();
                                            }

                                            String valorRepasseCentavosPayload = this.getElement("valorRepasseCentavos");
                                            if (valorRepasseCentavosPayload.Length != 0)
                                            {
                                                dadosparapagamento.valorRepasseCentavos = item["valorRepasseCentavos"].ToDecimal();
                                            }

                                            String valorComissaoCentavosPayload = this.getElement("valorComissaoCentavos");
                                            if (valorComissaoCentavosPayload.Length != 0)
                                            {
                                                dadosparapagamento.valorComissaoCentavos = item["valorComissaoCentavos"].ToDecimal();
                                            }

                                            String valorJurosCentavosPayload = this.getElement("valorJurosCentavos");
                                            if (valorJurosCentavosPayload.Length != 0)
                                            {
                                                dadosparapagamento.valorJurosCentavos = item["valorJurosCentavos"].ToDecimal();
                                            }

                                            String valorFreteCentavosPayload = this.getElement("valorFreteCentavos");
                                            if (valorFreteCentavosPayload.Length != 0)
                                            {
                                                dadosparapagamento.valorFreteCentavos = item["valorFreteCentavos"].ToDecimal();
                                            }

                                            String dataCapturaPayload = this.getElement("dataCaptura");
                                            if (dataCapturaPayload.Length != 0)
                                            {
                                                dadosparapagamento.dataCaptura = ((DateTime)item["dataCaptura"]);
                                            }

                                            String nsuAutorizadoraPayload = this.getElement("nsuAutorizadora");
                                            if (nsuAutorizadoraPayload.Length != 0)
                                            {
                                                dadosparapagamento.nsuAutorizadora = item["nsuAutorizadora"].ToString();
                                            }

                                            dadosParaPagamentoModelo[countDadosPagamento] = dadosparapagamento;
                                            payloadModelo.setDadosParaPagamento(dadosParaPagamentoModelo);

                                            countDadosPagamento++;
                                        }
                                    }
                                }
                                pagamentosModelo.setPayload(payloadModelo);
                                this.setListPagamentos(pagamentosModelo);

                                dtOrderPagamento.Rows.Add(contPagamento, pagamentosModelo.idEntrega, pagamentosModelo.statusOperacao, pagamentosModelo.pontoControle,
                                    pagamentosModelo.createdDate, pagamentosModelo.idPagamentoArranjo);
                                //dsOrderFinanceiro.Tables.Add(dtOrderPagamento);

                                contPagamento++;
                            }
                            else
                            {
                                dtOrderPagamento.Rows.Add(contPagamento, pagamentosModelo.idEntrega, pagamentosModelo.statusOperacao, pagamentosModelo.pontoControle,
                                    pagamentosModelo.createdDate, pagamentosModelo.idPagamentoArranjo);

                                contPagamento++;
                            }

                        }
                    }
                    else
                    {
                        dtOrderPagamento.Rows.Add(contPagamento, orderId[i], "Sem pagamento", "Sem pagamento",
                                    "Sem pagamento", "Sem pagamento");
                        
                        contPagamento++;
                    }

                    

                    //Deleta o o registro anterior que tá em listElements
                    this.listElements.Clear();
                    //Transações

                    if (resultTransacoes.Count > 0)
                    {
                        int contTransacao = 0;
                        foreach (var itemTransacao in resultTransacoes.ToArray())
                        {
                            contTransacao++;
                            
                            this.listElements.Clear(); 
                            this.setElement(itemTransacao.AsBsonValue);

                            //PED. EXEMPLO: 24660835702

                            transacoesModelo = new TransacoesModelo();

                        String _Id = this.getElement("_id");
                        if(_Id.Length != 0)
                        {
                            transacoesModelo._id = itemTransacao.GetElement("_id").Value.ToString();
                        }

                        String dataCriacao = this.getElement("dataCriacao");
                        if (dataCriacao.Length != 0)
                        {
                            transacoesModelo.dataCriacao = ((DateTime)itemTransacao.GetElement("dataCriacao").Value);
                        }

                        String dataModificacao = this.getElement("dataModificacao");
                        if (dataModificacao.Length != 0)
                        {
                            transacoesModelo.dataModificacao = ((DateTime)itemTransacao.GetElement("dataModificacao").Value);
                        }

                        String idAgendamentoMarketplace = this.getElement("idAgendamentoMarketplace");
                        if (idAgendamentoMarketplace.Length != 0)
                        {
                            transacoesModelo.idAgendamentoMarketplace = itemTransacao.GetElement("idAgendamentoMarketplace").Value.ToInt64();
                        }

                        String valorComissao = this.getElement("valorComissao");
                        if (valorComissao.Length != 0)
                        {
                            transacoesModelo.valorComissao = itemTransacao.GetElement("valorComissao").Value.ToString();
                        }

                        String valorTransacao = this.getElement("valorTransacao");
                        if (valorTransacao.Length != 0)
                        {
                            transacoesModelo.valorTransacao = itemTransacao.GetElement("valorTransacao").Value.ToString();
                        }

                        String valorPedido = this.getElement("valorPedido");
                        if (valorPedido.Length != 0)
                        {
                            transacoesModelo.valorPedido = itemTransacao.GetElement("valorPedido").Value.ToString();
                        }

                        String valorParcela = this.getElement("valorParcela");
                        if (valorParcela.Length != 0)
                        {
                            transacoesModelo.valorParcela = itemTransacao.GetElement("valorParcela").Value.ToString();
                        }

                        String valorRepasse = this.getElement("valorRepasse");
                        if (valorRepasse.Length != 0)
                        {
                            transacoesModelo.valorRepasse = itemTransacao.GetElement("valorRepasse").Value.ToString();
                        }

                        String porcentagemComissao = this.getElement("porcentagemComissao");
                        if (porcentagemComissao.Length != 0)
                        {
                            transacoesModelo.porcentagemComissao = itemTransacao.GetElement("porcentagemComissao").Value.ToString();
                        }

                        String dataTransacao = this.getElement("dataTransacao");
                        if (dataTransacao.Length != 0)
                        {
                            transacoesModelo.dataTransacao = ((DateTime)itemTransacao.GetElement("dataTransacao").Value);
                        }

                        String dataImportacao = this.getElement("dataImportacao");
                        if (dataImportacao.Length != 0)
                        {
                            transacoesModelo.dataImportacao = ((DateTime)itemTransacao.GetElement("dataImportacao").Value);
                        }

                        String dataEnvio = this.getElement("dataEnvio");
                        if (dataEnvio.Length != 0)
                        {
                            transacoesModelo.dataEnvio = ((DateTime)itemTransacao.GetElement("dataEnvio").Value);
                        }

                        String dataGatilho = this.getElement("dataGatilho");
                        if (dataGatilho.Length != 0)
                        {
                            transacoesModelo.dataGatilho = ((DateTime)itemTransacao.GetElement("dataGatilho").Value);
                        }

                        String dataPrevisaoPagamento = this.getElement("dataPrevisaoPagamento");
                        if (dataPrevisaoPagamento.Length != 0)
                        {
                            transacoesModelo.dataPrevisaoPagamento = ((DateTime)itemTransacao.GetElement("dataPrevisaoPagamento").Value);
                        }

                            String dataEnvioPagamento = this.getElement("dataEnvioPagamento");
                            if (dataEnvioPagamento.Length != 0)
                            {
                                transacoesModelo.dataEnvioPagamento = ((DateTime)itemTransacao.GetElement("dataEnvioPagamento").Value);
                            }

                            String dataConfirmacaoPagamento = this.getElement("dataConfirmacaoPagamento");
                            if (dataConfirmacaoPagamento.Length != 0)
                            {
                                transacoesModelo.dataConfirmacaoPagamento = ((DateTime)itemTransacao.GetElement("dataConfirmacaoPagamento").Value);
                            }

                            String dataPedido = this.getElement("dataPedido");
                        if (dataPedido.Length != 0)
                        {
                            transacoesModelo.dataPedido = ((DateTime)itemTransacao.GetElement("dataPedido").Value);
                        }

                        String dataParcela = this.getElement("dataParcela");
                        if (dataParcela.Length != 0)
                        {
                            transacoesModelo.dataParcela = ((DateTime)itemTransacao.GetElement("dataParcela").Value);
                        }

                        String numeroParcelas = this.getElement("numeroParcelas");
                        if (numeroParcelas.Length != 0)
                        {
                            transacoesModelo.numeroParcelas = itemTransacao.GetElement("numeroParcelas").Value.ToInt32();
                        }

                        String idEntrega = this.getElement("idEntrega");
                        if (idEntrega.Length != 0)
                        {
                            transacoesModelo.idEntrega = itemTransacao.GetElement("idEntrega").Value.ToInt64();
                        }

                        String idCompraBandeira = this.getElement("idCompraBandeira");
                        if (idCompraBandeira.Length != 0)
                        {
                            transacoesModelo.idCompraBandeira = itemTransacao.GetElement("idCompraBandeira").Value.ToInt64();
                        }

                        String cpfcnpjSubseller = this.getElement("cpfcnpjSubseller");
                        if (cpfcnpjSubseller.Length != 0)
                        {
                            transacoesModelo.cpfcnpjSubseller = itemTransacao.GetElement("cpfcnpjSubseller").Value.ToString();
                        }

                        String cnpjMarketplace = this.getElement("cnpjMarketplace");
                        if (cnpjMarketplace.Length != 0)
                        {
                            transacoesModelo.cnpjMarketplace = itemTransacao.GetElement("cnpjMarketplace").Value.ToString();
                        }

                        String codigoBandeiraCartao = this.getElement("codigoBandeiraCartao");
                        if (codigoBandeiraCartao.Length != 0)
                        {
                            transacoesModelo.codigoBandeiraCartao = itemTransacao.GetElement("codigoBandeiraCartao").Value.ToInt32();
                        }

                        String descricaoBandeiraCartao = this.getElement("descricaoBandeiraCartao");
                        if (descricaoBandeiraCartao.Length != 0)
                        {
                            transacoesModelo.descricaoBandeiraCartao = itemTransacao.GetElement("descricaoBandeiraCartao").Value.ToString();
                        }

                        //Provisório, depois melhorar essa pegado do Id do lojista
                            var site = itemTransacao.GetElement("site");
                            int idSite = site.Value[0].ToInt32();

                        String tipoTransacao = this.getElement("tipoTransacao");
                        if (tipoTransacao.Length != 0)
                        {
                            transacoesModelo.tipoTransacao = itemTransacao.GetElement("tipoTransacao").Value.ToString();
                        }

                        String idGetNet = this.getElement("idGetNet");
                        if (idGetNet.Length != 0)
                        {
                            transacoesModelo.idGetNet = itemTransacao.GetElement("idGetNet").Value.ToString();
                        }

                        String dataAprovacao = this.getElement("dataAprovacao");
                        if (dataAprovacao.Length != 0)
                        {
                            transacoesModelo.dataAprovacao = ((DateTime)itemTransacao.GetElement("dataAprovacao").Value);
                        }

                        String pontoControle = this.getElement("pontoControle");
                        if (pontoControle.Length != 0)
                        {
                            transacoesModelo.pontoControle = itemTransacao.GetElement("pontoControle").Value.ToString();
                        }

                        String dataNotificacao = this.getElement("dataNotificacao");
                        if (dataNotificacao.Length != 0)
                        {
                            transacoesModelo.dataNotificacao = ((DateTime)itemTransacao.GetElement("dataNotificacao").Value);
                        }

                        String valorFrete = this.getElement("valorFrete");
                        if (valorFrete.Length != 0)
                        {
                            transacoesModelo.valorFrete = itemTransacao.GetElement("valorFrete").Value.ToString();
                        }

                        String valorFreteLojista = this.getElement("valorFreteLojista");
                        if (valorFreteLojista.Length != 0)
                        {
                            transacoesModelo.valorFreteLojista = itemTransacao.GetElement("valorFreteLojista").Value.ToString();
                        }

                        String sDataInicioCiclo = this.getElement("dataInicioCiclo");
                        if(sDataInicioCiclo.Length != 0)
                         {
                                transacoesModelo.dataInicioCiclo = Convert.ToDateTime(itemTransacao.GetElement("dataInicioCiclo").Value);
                         }

                            String sDataFimCiclo = this.getElement("dataFimCiclo");
                            if (sDataFimCiclo.Length != 0)
                            {
                                transacoesModelo.dataFimCiclo = Convert.ToDateTime(itemTransacao.GetElement("dataFimCiclo").Value);
                            }

                            String plataformaTransacao = this.getElement("plataformaTransacao");
                        if (plataformaTransacao.Length != 0)
                        {
                            transacoesModelo.plataformaTransacao = itemTransacao.GetElement("plataformaTransacao").Value.ToString();
                        }

                        String tipoFrete = this.getElement("tipoFrete");
                        if (tipoFrete.Length != 0)
                        {
                            transacoesModelo.tipoFrete = itemTransacao.GetElement("tipoFrete").Value.ToString();
                        }

                        String tipoPagamento = this.getElement("tipoPagamento");
                        if (tipoPagamento.Length != 0)
                        {
                            transacoesModelo.tipoPagamento = itemTransacao.GetElement("tipoPagamento").Value.ToString();
                        }

                        String valorItem = this.getElement("valorItem");
                        if (valorItem.Length != 0)
                        {
                            transacoesModelo.valorItem = itemTransacao.GetElement("valorItem").Value.ToString();
                        }

                        String canal = this.getElement("canal");
                        if (canal.Length != 0)
                        {
                            transacoesModelo.canal = itemTransacao.GetElement("canal").Value.ToString();
                        }

                        String _class = this.getElement("_class");
                        if (_class.Length != 0)
                        {
                            transacoesModelo._class = itemTransacao.GetElement("_class").Value.ToString();
                        }

                        //Inserindo na tabela de transação
                        dtOrderFinanceiro.Rows.Add(contadorPedido + 1, orderIdAtual, transacoesModelo.descricaoBandeiraCartao, idSite,
                            transacoesModelo.idGetNet, transacoesModelo.dataConfirmacaoPagamento, transacoesModelo.dataPrevisaoPagamento, transacoesModelo.dataInicioCiclo, transacoesModelo.dataFimCiclo,
                            transacoesModelo.tipoTransacao, 
                                            string.Format("{0:N}", transacoesModelo.valorTransacao), transacoesModelo.valorPedido);

                            
                    }
                }
                    else
                {
                        //Se não tiver transação preenche a tabela de transação conforme abaixo
                    dtOrderFinanceiro.Rows.Add(contadorPedido + 1, orderIdAtual, "Sem transação", "Sem transação", "Sem transação", "Sem transação", "Sem transação",
                                                "Sem transação", "Sem transação", "Sem transação", "Sem transação");
                    }

            }
                //Insere as tabelas preenchidas no DataSet
                dsOrderFinanceiro.Tables.Add(dtOrderGatilho);
                dsOrderFinanceiro.Tables.Add(dtOrderFinanceiro);
                dsOrderFinanceiro.Tables.Add(dtOrderPagamento);
            }

            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao consultar o pedido " + orderIdAtual + "." + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Retorna o DataSet preenchido
            return dsOrderFinanceiro;
        }

        public void IncluirTackingPagamentoTeste()
        {
            try
            {
                var dbClientCompraTeste = new MongoClient("mongodb://localhost:27017/?serverSelectionTimeoutMS=5000&connectTimeoutMS=10000&3t.uriVersion=3&3t.connection.name=TesteLocal&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                IMongoDatabase dataBaseGatilhoTeste = dbClientCompraTeste.GetDatabase("mp-adquirente");
                IMongoCollection<TrackingComissionamentoModelo> colNew = dataBaseGatilhoTeste.GetCollection<TrackingComissionamentoModelo>("trackingComissionamento");

                TrackingComissionamentoModelo trackingComissionamentoModelo = new TrackingComissionamentoModelo();
                //trackingComissionamentoModelo._id = dataBaseGatilhoTeste.getne
                trackingComissionamentoModelo.idCompra = 29042673401;
                trackingComissionamentoModelo.idEntrega = 29042673401;                
                trackingComissionamentoModelo.status = "ENT";
                trackingComissionamentoModelo.statusOperacao = "NOVO";
                trackingComissionamentoModelo.dataIntegracao = DateTime.Now;
                trackingComissionamentoModelo.retentativa = 0;
                //trackingComissionamentoModelo.motivos.SetValue("[]",0);
                trackingComissionamentoModelo.createdDate = DateTime.Now;
                trackingComissionamentoModelo.lastModifiedDate = DateTime.Now;
                trackingComissionamentoModelo._class = "br.com.viavarejo.mpdinheiro.model.mongodb.TrackingComissionamentoEntity";
                
                colNew.InsertOne(trackingComissionamentoModelo);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<string> PesquisarPedidoGetnet(Int64 orderId, Int32 idBandeira)
        {
            //this.dtOrderGetNet.Clear();

            

            OrderResponseGetNetModelo orderResponseGetNetModelo = new OrderResponseGetNetModelo();

            string idSeller_Extra = "bcffabb4-71bd-4e5f-9f66-0617e2734874";
            string idSeller_CasasBahia = "f5619066-5eca-4048-aade-e8a7149dc55e";
            string idSeller_PontoFrio = "90fdcbdd-49ae-4b39-8b2b-fe7ced365e5d";

            //Variáveis utilizadas no laço abaixo
            string underline = "_";
            int valorInicial = 1;

            var urlParte1 = "http://mp-getnet.mktplace-prd.viavarejo.com.br/extratos?idSeller=";
            //var idSeller = this.txIdSeller.Text;
            var idCompra = "&idCompra=" + orderId.ToString().Substring(0,9);
            string urlTotal = string.Empty;

            var client = new HttpClient();
            var formContent = new Dictionary<string, string>();

            try
            {
                /*extra = 2
           CB = 3
           Ponto = 4
           */

                switch (idBandeira)
                {
                    case 2:
                        urlTotal = urlParte1 + idSeller_Extra + idCompra + underline + valorInicial + underline;
                        break;
                    case 3:
                        urlTotal = urlParte1 + idSeller_CasasBahia + idCompra + underline + valorInicial + underline;
                        break;
                    case 4:
                        urlTotal = urlParte1 + idSeller_PontoFrio + idCompra + underline + valorInicial + underline;
                        break;
                }

                //Va
                int valorFinal = 2;

                for (int i = 0; i <= 10; i++)
                {
                    orderResponseGetNetModelo = new OrderResponseGetNetModelo();

                    //Monta requisição
                    HttpResponseMessage response = await client.GetAsync(String.Format(urlTotal.Trim() + i));
                    //HttpResponseMessage responses = client.get client.GetAsync(String.Format(urlTotal.Trim() + i));

                    //idSeller: f5619066-5eca-4048-aade-e8a7149dc55e
                    //idCompra: 259860918_1_2

                    if (response.StatusCode != HttpStatusCode.NotFound)
                    {
                        var responseJson = response.Content.ReadAsStringAsync();
                        orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

                        if (orderResponseGetNetModelo.conteudo.transacoes != null)
                        {
                            for (int j = 0; j < orderResponseGetNetModelo.conteudo.transacoes.Length; j++)
                            {
                                //int cont = orderResponseGetNetModelo.conteudo.transacoes[0].detalhes[0].d;
                                //DataRow dr = dtOrderGetNet.NewRow();
                                //dr[0] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].idAgendamentoMarketplace;
                                //dr[1] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].nomePlanoPagamento;
                                //dr[2] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].valorParcela;
                                //dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].numeroParcelas;
                                //dr[4] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].dataTransacao;
                                //dr[5] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].dataPagamento;
                                //dr[6] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao;

                                statusLiberacao = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao.ToString();

                                return statusLiberacao; // orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao.ToString();

                                //dtOrderGetNet.Rows.Add(dr);

                            }
                        }

                        //if (dtOrderGetNet.Rows.Count != 0)
                        //{
                        //    return;
                        //}

                    }

                }

                for (int i = 0; i <= 10; i++)
                {
                    orderResponseGetNetModelo = new OrderResponseGetNetModelo();

                    switch (idBandeira)
                    {
                        case 2:
                            urlTotal = urlParte1 + idSeller_Extra + idCompra + underline + valorFinal + underline;
                            break;
                        case 3:
                            urlTotal = urlParte1 + idSeller_CasasBahia + idCompra + underline + valorFinal + underline;
                            break;
                        case 4:
                            urlTotal = urlParte1 + idSeller_PontoFrio + idCompra + underline + valorFinal + underline;
                            break;
                    }

                    urlTotal += i;

                    //Monta requisição
                    HttpResponseMessage response2 = await client.GetAsync(String.Format(urlTotal.Trim() + i));

                    if (response2.StatusCode != HttpStatusCode.NotFound)
                    {
                        var responseJson = response2.Content.ReadAsStringAsync();
                        orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

                        if (orderResponseGetNetModelo.conteudo.transacoes != null)
                        {
                            for (int a = 0; a < orderResponseGetNetModelo.conteudo.transacoes.Length; a++)
                            {
                                //DataRow dr = dtOrderGetNet.NewRow();
                                //dr[0] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].idItem;
                                //dr[1] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].nomePlanoPagamento;
                                //dr[2] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].valorParcela;
                                //dr[3] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].numeroParcelas;
                                //dr[4] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataTransacao;
                                //dr[5] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataPagamento;
                                //dr[6] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao;

                                statusLiberacao = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao.ToString();

                                return statusLiberacao; // orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao.ToString();

                                

                                //dtOrderGetNet.Rows.Add(dr);

                            }
                        }
                        //if (dtOrderGetNet.Rows.Count != 0)
                        //{
                        //    return;
                        //}
                    }
                }

                //return statusLiberacao;
                //this.gridSeller.DataSource = dtOrderGetNet;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return statusLiberacao;
        }

        public List<OrderBandeiraModelo> ConsultarOrderBandeira(List<OrderBandeiraModelo> listOrderBandeira)
        {
            var dbClientCompra = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
            IMongoDatabase dataBaseCompra = dbClientCompra.GetDatabase("mp-compras");

            for(int i = 0; i < listOrderBandeira.Count; i++)
            {
                var collectionCompra = dataBaseCompra.GetCollection<BsonDocument>("compra");
                var filterCompra = Builders<BsonDocument>.Filter.Eq("id", listOrderBandeira[i].OrderId);
                var resultCompra = collectionCompra.Find(filterCompra).ToList();

                foreach(var itemOrder in resultCompra.ToArray())
                {
                    //Passando valores Json para Objeto MPModelo
                    OrderBandeiraModelo orderBandeiraModelo = new OrderBandeiraModelo();
                    orderBandeiraModelo.OrderId = itemOrder.GetElement("id").Value.ToInt64(); //resultCompra[i].GetElement("id").Value.ToInt64();
                    orderBandeiraModelo.IdBandeira = itemOrder.GetElement("idUnidadeNegocio").Value.ToInt32(); // resultCompra[i].GetElement("idUnidadeNegocio").Value.ToInt32();
                    listResultOrderBandeira.Add(orderBandeiraModelo);
                }
                
            }

            return listResultOrderBandeira;

        }
         
    }
}
