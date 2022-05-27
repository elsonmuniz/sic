using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using SIC.BLL;
using SIC.Modelo;
using Newtonsoft.Json;
using SIC.DAO;
using System.Threading.Tasks;

namespace SIC
{
    public partial class ConsultarOrderGetNet : Forms.FormEdit
    {
        FrmApp frmApp;

        //MODELO
        LoginModelo loginModelo;
        OrderResponseGetNetModelo orderResponseGetNetModelo;

        //DataTable
        DataTable dtOrderGetNet;

        public ConsultarOrderGetNet(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;

            this.cbBandeira.SelectedIndex = 0;
        }

        public void ListagemTransacoesGetNet()
        {
            dtOrderGetNet = new DataTable();

            DataColumn dcNro = new DataColumn("Nro", typeof(string));
            DataColumn dcIdItem = new DataColumn("Id Item", typeof(string));
            DataColumn dcTransacao = new DataColumn("Id Transação", typeof(string));
            DataColumn dcNomePlanoPagamento = new DataColumn("Nome Plano Pgto", typeof(string));
            DataColumn dcValorParcelas = new DataColumn("Valor Parcela", typeof(string));
            DataColumn dcOrder = new DataColumn("OrderId", typeof(string));
            DataColumn dcDataTransacao = new DataColumn("Data Transação", typeof(string));
            DataColumn dcDataPagto = new DataColumn("Data Pagto", typeof(string));
            DataColumn dcStatusLiberacao = new DataColumn("StatusLiberacao", typeof(string));
            DataColumn dcSinal = new DataColumn("Sinal", typeof(string));

            dtOrderGetNet.Columns.AddRange(new DataColumn []{ dcNro, dcIdItem, dcTransacao,dcNomePlanoPagamento, dcValorParcelas, dcOrder, dcDataTransacao, dcDataPagto, dcStatusLiberacao, dcSinal });

            this.gridSeller.DataSource = dtOrderGetNet;

            this.gridSeller.Columns[0].Width = 30;
            this.gridSeller.Columns[1].Width = 70;
            this.gridSeller.Columns[2].Width = 100;
            this.gridSeller.Columns[3].Width = 150;
            this.gridSeller.Columns[4].Width = 60;
            this.gridSeller.Columns[5].Width = 80;
            this.gridSeller.Columns[6].Width = 120;
            this.gridSeller.Columns[7].Width = 120;
            this.gridSeller.Columns[8].Width = 85;
            this.gridSeller.Columns[9].Width = 60;
        }

        private async void btPesquisarSKU_Click(object sender, EventArgs e)
        {
            this.dtOrderGetNet.Clear();

            string idSeller_Extra       = "bcffabb4-71bd-4e5f-9f66-0617e2734874";
            string idSeller_CasasBahia  = "f5619066-5eca-4048-aade-e8a7149dc55e";
            string idSeller_PontoFrio   = "90fdcbdd-49ae-4b39-8b2b-fe7ced365e5d";
                                           
            //Variáveis utilizadas no laço abaixo
            string underline = "_";
            int valorInicial = 1;

            var urlParte1 = "http://mp-getnet.mktplace-prd.viavarejo.com.br/extratos?idSeller=";
            //var idSeller = this.txIdSeller.Text;
            var idCompra = "&idCompra=" + this.txIdCompra.Text;
            string urlTotal = string.Empty;

           

            var client = new HttpClient();
            var formContent = new Dictionary<string, string>();

            

            try
            {
                /*extra = 2
           /*CB = 3
           Ponto = 4
           */

                switch (cbBandeira.SelectedIndex)
                {
                    case 0:
                        urlTotal = urlParte1 + idSeller_Extra + idCompra + underline + valorInicial + underline;
                        break;
                    case 1:
                        urlTotal = urlParte1 + idSeller_CasasBahia + idCompra + underline + valorInicial + underline;
                        break;
                    case 2:
                        urlTotal = urlParte1 + idSeller_PontoFrio + idCompra + underline + valorInicial + underline;
                        break;
                }

                //Va
                int valorFinal = 2;

                for (int i = 0; i <= 10; i++)
                {
                    

                   //Monta requisição
                    HttpResponseMessage response = await client.GetAsync(String.Format(urlTotal.Trim() + i));

                    //idSeller: f5619066-5eca-4048-aade-e8a7149dc55e
                    //idCompra: 259860918_1_2

                    if (response.StatusCode != HttpStatusCode.NotFound)
                    {
                        orderResponseGetNetModelo = new OrderResponseGetNetModelo();
                        var responseJson = response.Content.ReadAsStringAsync();
                        orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

                        if (orderResponseGetNetModelo.conteudo.pagamentos != null)
                        {
                            for(int j = 0; j < orderResponseGetNetModelo.conteudo.transacoes.Length; j++)
                            {
                                //for(int y =0; y < orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].ToString().Length; y++)
                                //int cont = orderResponseGetNetModelo.conteudo.transacoes[0].detalhes[0].d;
                                DataRow dr = dtOrderGetNet.NewRow();
                                if(orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[0] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].idAgendamentoMarketplace;
                                }
                                
                                dr[1] = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.idPedido;
                                
                                if(orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[2] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].nomePlanoPagamento;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].valorParcela;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[4] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].numeroParcelas;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[5] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].dataTransacao;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[6] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].dataPagamento;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                {
                                    dr[7] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].statusLiberacao;
                                }

                                if (orderResponseGetNetModelo.conteudo.transacoes[j].resumo != null)
                                {
                                    dr[8] = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.sinalTransacao;
                                }

                                dtOrderGetNet.Rows.Add(dr);

                            }
                        }

                        else
                        {
                            //MessageBox.Show("Pedido não localizado o pedido " + txIdCompra.Text + "na getnet.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if(dtOrderGetNet.Rows.Count != 0)
                        {
                            return;
                        }
                        
                    }

                }

                for (int i = 0; i <= 10; i++)
                {
                    orderResponseGetNetModelo = new OrderResponseGetNetModelo();
                                       
                    switch (cbBandeira.SelectedIndex)
                    {
                        case 0:
                            urlTotal = urlParte1 + idSeller_Extra + idCompra + underline + valorFinal + underline;
                            break;
                        case 1:
                            urlTotal = urlParte1 + idSeller_CasasBahia + idCompra + underline + valorFinal + underline;
                            break;
                        case 2:
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
                                DataRow dr = dtOrderGetNet.NewRow();
                                dr[0] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].idItem;
                                dr[1] = orderResponseGetNetModelo.conteudo.transacoes[0].resumo.idPedido;
                                dr[2] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].nomePlanoPagamento;
                                dr[3] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].valorParcela;
                                dr[4] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].numeroParcelas;
                                dr[5] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataTransacao;
                                dr[6] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].dataPagamento;
                                dr[7] = orderResponseGetNetModelo.conteudo.transacoes[a].detalhes[0].statusLiberacao;

                                dtOrderGetNet.Rows.Add(dr);

                            }
                        }
                        if (dtOrderGetNet.Rows.Count != 0)
                        {
                            return;
                        }
                    }
                }

                this.gridSeller.DataSource = dtOrderGetNet;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + this.txIdCompra.Text + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void ConsultarOrderGetNet_Load(object sender, EventArgs e)
        {
            this.ListagemTransacoesGetNet();
        }

        private void btConsultarEmLote_Click(object sender, EventArgs e)
        {
            ConsultarOrderGetNetLote consultarOrderGetNetLote = new ConsultarOrderGetNetLote(frmApp, this);
            consultarOrderGetNetLote.Show();
        }

        public async void ConsultarPedidoBandeira(List<OrderBandeiraModelo> listOrderBandeira)
        {
            MPComprasDAO mPComprasDAO = new MPComprasDAO();
            //List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

            listOrderBandeira = mPComprasDAO.ConsultarOrderBandeira(listOrderBandeira);

            await this.PesquisarPedidoGetnet(listOrderBandeira);

        }

        public async Task<List<OrderBandeiraModelo>> PesquisarPedidoGetnet(List<OrderBandeiraModelo> listOrderBandeira)
        {
            this.dtOrderGetNet.Clear();

            for(int a = 0; a < listOrderBandeira.Count; a++)
            {
                string idSeller_Extra = "bcffabb4-71bd-4e5f-9f66-0617e2734874";
                string idSeller_CasasBahia = "f5619066-5eca-4048-aade-e8a7149dc55e";
                string idSeller_PontoFrio = "90fdcbdd-49ae-4b39-8b2b-fe7ced365e5d";

                //Variáveis utilizadas no laço abaixo
                string underline = "_";
                int valorInicial = 1;

                var urlParte1 = "http://mp-getnet.mktplace-prd.viavarejo.com.br/extratos?idSeller=";
                //var idSeller = this.txIdSeller.Text;
                var idCompra = "&idCompra=" + listOrderBandeira[a].OrderId.ToString().Substring(0,9);
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

                    for (int i = 0; i <= 10; i++)
                    {


                        //Monta requisição
                        HttpResponseMessage response = await client.GetAsync(String.Format(urlTotal.Trim() + i));

                        //idSeller: f5619066-5eca-4048-aade-e8a7149dc55e
                        //idCompra: 259860918_1_2

                        if (response.StatusCode != HttpStatusCode.NotFound)
                        {
                            orderResponseGetNetModelo = new OrderResponseGetNetModelo();
                            var responseJson = response.Content.ReadAsStringAsync();
                            orderResponseGetNetModelo = JsonConvert.DeserializeObject<OrderResponseGetNetModelo>(responseJson.Result);

                            if ((orderResponseGetNetModelo.conteudo.pagamentos != null) || (orderResponseGetNetModelo.conteudo.transacoes != null))
                            {
                                for (int j = 0; j < orderResponseGetNetModelo.conteudo.transacoes.Length; j++)
                                {
                                    //for(int y =0; y < orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[0].ToString().Length; y++)
                                    //int cont = orderResponseGetNetModelo.conteudo.transacoes[0].detalhes[0].d;
                                    DataRow dr = dtOrderGetNet.NewRow();

                                    dr[0] = a + 1;

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[1] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].idAgendamentoMarketplace;
                                    }

                                    dr[2] = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.idPedido;

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].resumo != null)
                                    {
                                        //dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].nomePlanoPagamento;
                                        dr[3] = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.mensagemMotivo;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[4] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].valorParcela;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[5] = listOrderBandeira[a].OrderId; //orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].numeroParcelas;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[6] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].dataTransacao;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[7] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].dataPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].detalhes != null)
                                    {
                                        dr[8] = orderResponseGetNetModelo.conteudo.transacoes[j].detalhes[j].statusLiberacao;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[j].resumo != null)
                                    {
                                        dr[9] = orderResponseGetNetModelo.conteudo.transacoes[j].resumo.sinalTransacao;
                                    }

                                    dtOrderGetNet.Rows.Add(dr);

                                    //return listOrderBandeira;

                                }
                            }

                            //else
                            //{
                            //    //MessageBox.Show("Pedido não localizado o pedido " + txIdCompra.Text + "na getnet.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                            if (dtOrderGetNet.Rows.Count != 0)
                            {
                                //return;
                            }

                        }

                    }

                    for (int i = 0; i <= 10; i++)
                    {
                        orderResponseGetNetModelo = new OrderResponseGetNetModelo();

                        switch (cbBandeira.SelectedIndex)
                        {
                            case 0:
                                urlTotal = urlParte1 + idSeller_Extra + idCompra + underline + valorFinal + underline;
                                break;
                            case 1:
                                urlTotal = urlParte1 + idSeller_CasasBahia + idCompra + underline + valorFinal + underline;
                                break;
                            case 2:
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
                                    DataRow dr = dtOrderGetNet.NewRow();
                                    dr[0] = a + 1;

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[1] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].idAgendamentoMarketplace;
                                    }

                                    dr[2] = orderResponseGetNetModelo.conteudo.transacoes[b].resumo.idPedido;

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[3] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].nomePlanoPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[4] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].valorParcela;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[5] = listOrderBandeira[a].OrderId;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[6] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataTransacao;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[7] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].dataPagamento;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].detalhes != null)
                                    {
                                        dr[8] = orderResponseGetNetModelo.conteudo.transacoes[b].detalhes[b].statusLiberacao;
                                    }

                                    if (orderResponseGetNetModelo.conteudo.transacoes[b].resumo != null)
                                    {
                                        dr[9] = orderResponseGetNetModelo.conteudo.transacoes[b].resumo.sinalTransacao;
                                    }

                                    dtOrderGetNet.Rows.Add(dr);

                                    //return listOrderBandeira;

                                }
                            }

                            if(i == 10)
                            {
                                bool pedidoJaExiste = false;

                                pedidoJaExiste = await this.LocalizarPedidoExistente(dtOrderGetNet, listOrderBandeira[a].OrderId.ToString());

                                if(!pedidoJaExiste)
                                {
                                    DataRow dr = dtOrderGetNet.NewRow();

                                    dr[0] = a + 1;
                                    dr[5] = listOrderBandeira[a].OrderId;

                                    dtOrderGetNet.Rows.Add(dr);
                                }
                                
                            }
                            
                        }
                    }

                    this.gridSeller.DataSource = dtOrderGetNet;
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

             foreach(DataRow drItem in  dtPedidos.Rows)
            {
                 if(drItem[5].ToString() == pedido)
                {
                     pedidoJaExiste = true;

                    return pedidoJaExiste;
                }
                
            }

            return await Task.FromResult<Boolean>(pedidoJaExiste);
        }

    }
}
