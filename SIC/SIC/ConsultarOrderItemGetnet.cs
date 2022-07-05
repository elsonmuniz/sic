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
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using SIC.DAO;

namespace SIC
{
    public partial class ConsultarOrderItemGetnet : Forms.FormEdit
    {
        FrmApp frmApp;

        //MODELO
        //LoginModelo loginModelo;
        OrderResponseGetNetModelo orderResponseGetNetModelo;

        //DataTable
        DataTable dtOrderGetNet;
        List<OrderResponseGetNetModelo> listOrderResponseGetNet = new List<OrderResponseGetNetModelo>();

        public ConsultarOrderItemGetnet(FrmApp frmApp)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;
        }

        public void ListagemGrid()
        {
            dtOrderGetNet = new DataTable();

            DataColumn dcNro = new DataColumn("Nro", typeof(string));
            DataColumn dcBandeira = new DataColumn("Bandeira", typeof(string));
            DataColumn dcTransacao = new DataColumn("Id Transação", typeof(string));
            DataColumn dcNomePlanoPagamento = new DataColumn("Nome Plano Pgto", typeof(string));
            DataColumn dcValorParcelas = new DataColumn("Valor Parcela", typeof(string));
            DataColumn dcOrder = new DataColumn("OrderId", typeof(string));
            DataColumn dcDataTransacao = new DataColumn("Data Transação", typeof(string));
            DataColumn dcDataPagto = new DataColumn("Data Pagto", typeof(string));
            DataColumn dcStatusLiberacao = new DataColumn("StatusLiberacao", typeof(string));
            DataColumn dcSinal = new DataColumn("Sinal", typeof(string));

            dtOrderGetNet.Columns.AddRange(new DataColumn[] { dcNro, dcBandeira, dcTransacao, dcNomePlanoPagamento, dcValorParcelas, dcOrder, dcDataTransacao, dcDataPagto, dcStatusLiberacao, dcSinal });

            this.gridOrderItem.DataSource = dtOrderGetNet;

            this.gridOrderItem.Columns[0].Width = 30;
            this.gridOrderItem.Columns[1].Width = 70;
            this.gridOrderItem.Columns[2].Width = 100;
            this.gridOrderItem.Columns[3].Width = 150;
            this.gridOrderItem.Columns[4].Width = 60;
            this.gridOrderItem.Columns[5].Width = 80;
            this.gridOrderItem.Columns[6].Width = 120;
            this.gridOrderItem.Columns[7].Width = 120;
            this.gridOrderItem.Columns[8].Width = 85;
            this.gridOrderItem.Columns[9].Width = 60;
        }

        public async void ConsultarPedidoBandeira(List<OrderBandeiraModelo> listOrderBandeira)
        {
            MPComprasDAO mPComprasDAO = new MPComprasDAO();
            //List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

            listOrderBandeira = mPComprasDAO.ConsultarOrderBandeira(listOrderBandeira);

            await this.PesquisarPedidoGetnet(listOrderBandeira);

        }
        //Consulta o pedido na Getnet, não precisa retirar o 01 do pedido
        public async Task<List<OrderBandeiraModelo>> PesquisarPedidoGetnet(List<OrderBandeiraModelo> listOrderBandeira)
        {
            this.dtOrderGetNet.Clear();

            for (int a = 0; a < listOrderBandeira.Count; a++)
            {
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
               /*CB = 3
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

                    for (int i = 0; i < 10; i++)
                    {

                        //Monta requisição
                        HttpResponseMessage response = await client.GetAsync(String.Format(urlTotal.Trim() + i));

                        if (response.StatusCode != HttpStatusCode.NotFound)
                        {
                            orderResponseGetNetModelo = new OrderResponseGetNetModelo();
                            var responseJson = response.Content.ReadAsStringAsync();
                            orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

                            if (orderResponseGetNetModelo.conteudo.transacoes != null)
                            {
                                for (int j = 0; j < orderResponseGetNetModelo.conteudo.transacoes.Length; j++)
                                {
                                    if(orderResponseGetNetModelo.conteudo.transacoes[j].detalhes.Length != 0)
                                    {
                                        for (int y = 0; y < orderResponseGetNetModelo.conteudo.transacoes[j].detalhes.Length; y++)
                                        {

                                            DataRow dr = dtOrderGetNet.NewRow();

                                            dr[0] = a + 1;

                                            dr[1] = listOrderBandeira[a].IdBandeira;

                                            dr[2] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].statusLiberacao;

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].nomePlanoPagamento != null)
                                            {
                                                dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].nomePlanoPagamento;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y] != null)
                                            {
                                                dr[4] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].valorParcela;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[y].detalhes != null)
                                            {
                                                dr[5] = listOrderBandeira[a].OrderId;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                            {
                                                dr[6] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].dataPagamento;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                            {
                                                dr[7] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].dataParcela;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                            {
                                                dr[8] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].dataPagamento;
                                            }

                                            if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].dataPagamento != null)
                                            {
                                                dr[9] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[y].dataPagamento;
                                            }

                                            dtOrderGetNet.Rows.Add(dr);
                                        }
                                    }
                                }
                            }

                            if (dtOrderGetNet.Rows.Count != 0)
                            {
                                //return;
                            }

                        }

                    }

                    for (int i = 0; i < 10; i++)
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

                        //urlTotal += i;

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
                                    DataRow dr = dtOrderGetNet.NewRow();
                                    dr[0] = a + 1;

                                    dr[1] = listOrderBandeira[a].IdBandeira;

                                    dr[2] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].statusLiberacao;

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].nomePlanoPagamento != null)
                                    {
                                        dr[3] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].nomePlanoPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b] != null)
                                    {
                                        dr[4] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].valorParcela;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[5] = listOrderBandeira[a].OrderId;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[6] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[7] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[8] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento != null)
                                    {
                                        dr[9] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento;
                                    }

                                    dtOrderGetNet.Rows.Add(dr);
                                }
                            }

                            if (i == 10)
                            {
                                bool pedidoJaExiste = false;

                                pedidoJaExiste = await this.LocalizarPedidoExistente(dtOrderGetNet, listOrderBandeira[a].OrderId.ToString());

                                if (!pedidoJaExiste)
                                {
                                    DataRow dr = dtOrderGetNet.NewRow();

                                    dr[0] = a + 1;
                                    dr[5] = listOrderBandeira[a].OrderId;

                                    dtOrderGetNet.Rows.Add(dr);
                                }

                            }

                        }
                    }

                    this.gridOrderItem.DataSource = dtOrderGetNet;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro" + this.txIdCompra.Text + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return listOrderBandeira;
        }

        //Percorre a tabela de pedidos para verificar se já existe o pedido
        //Se não existe insere só o pedido na linha do grid
        public async Task<Boolean> LocalizarPedidoExistente(DataTable dtPedidos, string pedido)
        {
            Boolean pedidoJaExiste = false;

            foreach (DataRow drItem in dtPedidos.Rows)
            {
                if (drItem[5].ToString() == pedido)
                {
                    pedidoJaExiste = true;

                    return pedidoJaExiste;
                }

            }

            return await Task.FromResult<Boolean>(pedidoJaExiste);
        }

        private void ConsultarOrderItemGetnet_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Consultar liberação de item");
            this.ListagemGrid();
        }

        private void btConsultarEmLote_Click(object sender, EventArgs e)
        {
            ConsultarOrderItemGetNetLote consultarOrderItemGetNetLote = new ConsultarOrderItemGetNetLote(frmApp, this);
            consultarOrderItemGetNetLote.Show();
        }
    }
}
