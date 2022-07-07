using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;
using SIC.BLL;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using SIC.DAO;

namespace SIC
{
    public partial class ConsultarPedidoFinanceiro : Forms.FormEdit
    {
        //Modelo
        GatilhoModelo gatilhoModelo;

        //BLL
        MPComprasBLL mPComprasBLL;

        //DataTable
        DataTable dtOrderFinanceiro;

        //DataSet
        DataSet dsOrderFinanceiro;

        //Variável local
        //String statusLiberacao;

        List<OrderResponseGetNetModelo> listTransacao = new List<OrderResponseGetNetModelo>();

        FrmApp frmApp;
        public ConsultarPedidoFinanceiro(FrmApp frmApp)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;
        }
        

        private void ConsultarPedidoFinanceiro_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Consultar pagamento financeiro");
        }

        public void ListarTabela()
        {
            dtOrderFinanceiro = new DataTable();

            DataColumn dcIdEntrega = new DataColumn("IdEntrega", typeof(string));
            DataColumn dcStatusGatilho = new DataColumn("Status Gatilho", typeof(string));
            DataColumn dcStatusPagamento = new DataColumn("Status Pagamento", typeof(string));
            DataColumn dcPontoControlePagamento = new DataColumn("Ponto Controle", typeof(string));
            DataColumn dcTipoTransacao = new DataColumn("Tipo Transação", typeof(string));

            dtOrderFinanceiro.Columns.AddRange(new DataColumn[] { dcIdEntrega, dcStatusGatilho, dcStatusPagamento, dcPontoControlePagamento, dcTipoTransacao });

            gridOrderFinanceiro.DataSource = dtOrderFinanceiro;

            this.gridOrderFinanceiro.Columns[0].Width = 60;
            this.gridOrderFinanceiro.Columns[1].Width = 80;
            this.gridOrderFinanceiro.Columns[2].Width = 80;
            this.gridOrderFinanceiro.Columns[3].Width = 60;

            this.gridOrderGatilho.Columns[4].Width = 390;

        }
        
        public async Task ConsultaPedidoFinanceiro(List<Int64> orderId)
        {
            gatilhoModelo = new GatilhoModelo();
            mPComprasBLL = new MPComprasBLL();

            dsOrderFinanceiro = new DataSet();

            //gatilhoModelo = mPComprasBLL.ConsultarPedidoFinanceiro(idEntrega);
            dsOrderFinanceiro = await mPComprasBLL.ConsultarPedidoFinanceiro(orderId);
            
            gridOrderFinanceiro.DataSource = dsOrderFinanceiro.Tables["Transacao"];
            gridOrderPagamento.DataSource = dsOrderFinanceiro.Tables["Pagamento"];
            gridOrderGatilho.DataSource = dsOrderFinanceiro.Tables["Gatilho"];

            if(gridOrderFinanceiro.DataSource != null)
            {
                gridOrderFinanceiro.Columns[0].Width = 40;
                this.gridOrderFinanceiro.Columns[1].Width = 80;
                this.gridOrderFinanceiro.Columns[3].Width = 60;
            }
            

            if(gridOrderPagamento.DataSource != null)
            {
                gridOrderPagamento.Columns[2].Width = 120;
                gridOrderPagamento.Columns[4].Width = 120;
                gridOrderPagamento.Columns[5].Width = 220;
            }

            if(gridOrderGatilho.DataSource != null)
            {
                gridOrderGatilho.Columns[1].Width = 100;
                gridOrderGatilho.Columns[2].Width = 220;
                gridOrderGatilho.Columns[3].Width = 120;
                gridOrderGatilho.Columns[4].Width = 452;            
            }

        }

        public void btImportarLote_Click(object sender, EventArgs e)
        {
            ImportarTransacaoLote importarTransacaoLote = new ImportarTransacaoLote(frmApp, this);
            importarTransacaoLote.Show();
        }

        private async void btPesquisarOrder_Click(object sender, EventArgs e)
        {
            //this.ConsultaPedidoFinanceiro(Convert.ToInt64(this.txOrderId.Text));
            List<Int64> orderId = new List<long>();
            orderId.Add(Convert.ToInt64(this.txOrderId.Text));

            await this.ConsultaPedidoFinanceiro(orderId);
        }

        private void txOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //this.ConsultaPedidoFinanceiro(List < Int64 > orderId);
            }
            
        }

        private async void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ImportarTransacao();
        }

        public void InsertGatilhoTeste()
        {
            MPComprasDAO mPComprasDAO = new MPComprasDAO();
            mPComprasDAO.IncluirTackingPagamentoTeste();
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.InsertGatilhoTeste();
        }

        public async void ImportarTransacao()
        {
            //Limpando o progressbar
            this.progressBarImportarTransacao.Value = 0; 

            MPComprasDAO mPComprasDAO = new MPComprasDAO();
            List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

            this.lbImportacaoTransacao.Text = "Aguarde importação das transações...";

            //Passar as linhas da tabela aqui por um foreach

            //PROGRESS BAR
            this.progressBarImportarTransacao.Minimum = 1;
            this.progressBarImportarTransacao.Maximum = 0;

            int contProgressBar = 0;

            foreach(DataGridViewRow dr in this.gridOrderFinanceiro.Rows)
            {
                OrderBandeiraModelo orderBandeiraModelo = new OrderBandeiraModelo();
                orderBandeiraModelo.OrderId = Convert.ToInt64(dr.Cells[1].Value); // Convert.ToInt64(gridOrderFinanceiro[1, gridOrderFinanceiro.CurrentRow.Index].Value.ToString());
                orderBandeiraModelo.IdGetnet = dr.Cells[4].Value.ToString();
                //orderBandeiraModelo.DataConfirmacaoPagamento = dr.Cells[5].Value.ToString();
                orderBandeiraModelo.DataPrevisaoPagamento = "";
                orderBandeiraModelo.DataPrevisaoPagamento = dr.Cells[6].Value.ToString();

                listOrderBandeira.Add(orderBandeiraModelo);

                contProgressBar++;
                this.progressBarImportarTransacao.Maximum = contProgressBar;
            }

            
            
            

            listOrderBandeira = mPComprasDAO.ConsultarOrderBandeira(listOrderBandeira);


            //Fazer uma condição aqui para pegar o IdTransação da Getnet somente dos pedidos que não tem o mesmo no Grid
            await this.PesquisarPedidoGetnet(listOrderBandeira);

            int cont = 0;

                for(int i = 0; i < listOrderBandeira.Count; i++)
                {
                cont++;
                this.progressBarImportarTransacao.Increment(1);
                this.progressBarImportarTransacao.Refresh();

                if (listOrderBandeira[i].IdGetnet.Length != 0 && listOrderBandeira[i].DataConfirmacaoPagamento == null ) 
                {
                    if(Convert.ToDateTime(listOrderBandeira[i].DataPrevisaoPagamento) != null && Convert.ToDateTime(listOrderBandeira[i].DataPrevisaoPagamento) < DateTime.Now)
                    {
                        string url = "http://dialga.viavarejo.com.br:80/mp-dinheiro/transacoes/importar?idCompra=";
                        //string urlSemFila = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila";

                        HttpClient client = new HttpClient();
                        HttpResponseMessage response = await client.GetAsync(String.Format(url.Trim() + listOrderBandeira[i].IdGetnet));
                        var responseJson = response.Content.ReadAsStringAsync();

                        

                        this.txQtdConfPagto.Text = cont.ToString();

                        //this.progressBarImportarTransacao.Maximum = cont ;

                        //}


                        this.txQtdConfPagto.Text = cont.ToString();
                    }

                    else
                    {
                        
                    }
                    //progressBarImportarTransacao.Value += i;

                    //if (listOrderBandeira[i].IdGetnet.Length != 0 && listOrderBandeira[i].DataConfirmacaoPagamento == null)
                    //{
                    //string url = "http://dialga.viavarejo.com.br:80/mp-dinheiro/transacoes/importar?idCompra=";
                    ////string urlSemFila = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila";

                    //HttpClient client = new HttpClient();
                    //HttpResponseMessage response = await client.GetAsync(String.Format(url.Trim() + listOrderBandeira[i].IdGetnet));
                    //var responseJson = response.Content.ReadAsStringAsync();

                    //cont++;
                    //}


                    this.txQtdConfPagto.Text = cont.ToString();

                    //string url = "http://dialga.viavarejo.com.br:80/mp-dinheiro/transacoes/importar?idCompra=";
                    ////string urlSemFila = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila";

                    //HttpClient client = new HttpClient();
                    //HttpResponseMessage response = await client.GetAsync(String.Format(url.Trim()+listOrderBandeira[i].IdGetnet));
                    //var responseJson = response.Content.ReadAsStringAsync();

                    /*MODELO POST*/
                    //StringContent content = new StringContent($"[" + listOrderBandeira[i].IdGetnet.ToString() + "]");
                    //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    //var result = await client.PostAsync(url, content);

                    //Sem Fila
                    //HttpClient clientSemFila = new HttpClient();
                    //StringContent contentSemFila = new StringContent($"[" + dr[0].ToString() + "]");
                    //contentSemFila.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    //var resultSemFila = await clientSemFila.PostAsync(urlSemFila, contentSemFila);
                }
                //if((listOrderBandeira[i].IdGetnet.Length != 0 & listOrderBandeira[i].DataConfirmacaoPagamento.Length == 0 & listOrderBandeira[i].DataPrevisaoPagamento.Length == 0))
                //{
                //    string url = "http://dialga.viavarejo.com.br:80/mp-dinheiro/transacoes/importar?idCompra=";
                //    //string urlSemFila = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila";

                //    HttpClient client = new HttpClient();
                //    HttpResponseMessage response = await client.GetAsync(String.Format(url.Trim() + listOrderBandeira[i].IdGetnet));
                //    var responseJson = response.Content.ReadAsStringAsync();

                //    cont++;
                //}

                
            }

            this.lbImportacaoTransacao.Text = "";
            this.lbImportacaoTransacao.Text = "Importação concluída.";

            MessageBox.Show("Importação efetuada com suscesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public async Task<List<OrderBandeiraModelo>> PesquisarPedidoGetnet(List<OrderBandeiraModelo> listOrderBandeira)
        {
            //this.dtOrderGetNet.Clear();

            //this.progressBarImportarTransacao.Minimum = 1;
            //this.progressBarImportarTransacao.Maximum = listOrderBandeira.Count;

            for(int a = 0; a < listOrderBandeira.Count; a++)
            {
                if ((listOrderBandeira[a].IdGetnet.Length == 0 || listOrderBandeira[a].IdGetnet == "Sem transação") || (listOrderBandeira[a].IdGetnet == "Sem transação" || listOrderBandeira[a].IdGetnet == "Sem transação"))
                {
                    OrderResponseGetNetModelo orderResponseGetNetModelo = new OrderResponseGetNetModelo();

                    string idSeller_Extra = "bcffabb4-71bd-4e5f-9f66-0617e2734874";
                    string idSeller_CasasBahia = "f5619066-5eca-4048-aade-e8a7149dc55e";
                    string idSeller_PontoFrio = "90fdcbdd-49ae-4b39-8b2b-fe7ced365e5d";

                    //Variáveis utilizadas no laço abaixo
                    string underline = "_";
                    int valorInicial = 1;

                    var urlParte1 = "http://mp-getnet.mktplace-prd.viavarejo.com.br/extratos?idSeller=";
                    //var idSeller = this.txIdSeller.Text;
                    var idCompra = "&idCompra=" + listOrderBandeira[a].OrderId.ToString().Substring(0, 9);
                    string urlTotal = string.Empty;

                    var client = new HttpClient();
                    var formContent = new Dictionary<string, string>();

                    try
                    {
                        /*extra = 2
                   CB = 3
                   Ponto = 4
                   */

                        switch (listOrderBandeira[a].IdBandeira)
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
                                        listOrderBandeira[a].IdGetnet = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.idPedido;
                                        //this.listTransacao.Add(orderResponseGetNetModelo);
                                        //int cont = orderResponseGetNetModelo.conteudo.transacoes[0].detalhes[0].d;
                                        //DataRow dr = dtOrderGetNet.NewRow();
                                        //dr[0] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].idAgendamentoMarketplace;
                                        //dr[1] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].nomePlanoPagamento;
                                        //dr[2] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].valorParcela;
                                        //dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].numeroParcelas;
                                        //dr[4] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].dataTransacao;
                                        //dr[5] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].dataPagamento;
                                        //dr[6] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao;

                                        //statusLiberacao = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao.ToString();

                                        //return statusLiberacao; // orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].statusLiberacao.ToString();

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

                            switch (listOrderBandeira[a].IdBandeira)
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
                                    for (int b = 0; b < orderResponseGetNetModelo.conteudo.transacoes.Length; b++)
                                    {
                                        listOrderBandeira[a].IdGetnet = orderResponseGetNetModelo.conteudo.transacoes[b].resumo.idPedido;

                                        //DataRow dr = dtOrderGetNet.NewRow();
                                        //dr[0] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].idItem;
                                        //dr[1] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].nomePlanoPagamento;
                                        //dr[2] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].valorParcela;
                                        //dr[3] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].numeroParcelas;
                                        //dr[4] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataTransacao;
                                        //dr[5] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataPagamento;
                                        //dr[6] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao;

                                        //statusLiberacao = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[0].statusLiberacao.ToString();

                                        //return statusLiberacao; // orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao.ToString();



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
                }

                //this.progressBarImportarTransacao.Increment(1);


            }

            
            
            return listOrderBandeira;
        }

        private void btImportarLote_Click_1(object sender, EventArgs e)
        {
            this.progressBarImportarTransacao.Value = 0;
            this.LimparRotuloImportacaoProgressBar();

            ImportarTransacaoLote importarTransacaoLote = new ImportarTransacaoLote(frmApp, this);
            importarTransacaoLote.Show();
        }

        public void LimparRotuloImportacaoProgressBar()
        {
            this.lbImportacaoTransacao.Text = "";
            this.txQtdConfPagto.Text = "";
        }
        
    }
}
