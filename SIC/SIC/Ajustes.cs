using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;
using SIC.BLL;
using SIC.DAO;

namespace SIC
{
    public partial class Ajustes : Forms.FormEdit
    {
        //Frm
        FrmApp frmApp;

        //List
        List<AjustesModelo> listAjuste = new List<AjustesModelo>();
        List<Int64> listOrderId = new List<long>();

        //Modelo

        //BLL
        AjusteBLL ajusteBLL;

        //DataTable
        DataTable dtOrder;

        //Variável Local
        DateTime dataLiberacao;

        public Ajustes(FrmApp frmApp)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;
        }

        public void PesquisarAjuste(List<Int64> listOrderId)
        {
            ajusteBLL = new AjusteBLL();
            dtOrder = new DataTable();

            dtOrder = ajusteBLL.PesquisarAjustes(listOrderId);

            this.gridOrder.DataSource = dtOrder;

            this.gridOrder.Columns[0].Width = 60;
            this.gridOrder.Columns[1].Width = 60;
            this.gridOrder.Columns[3].Width = 70;
            this.gridOrder.Columns[4].Width = 115;
            this.gridOrder.Columns[5].Width = 115;
            this.gridOrder.Columns[6].Width = 115;
            this.gridOrder.Columns[7].Width = 115;
            this.gridOrder.Columns[8].Width = 60;
            this.gridOrder.Columns[9].Width = 180;
            this.gridOrder.Columns[10].Width = 80;


        }

        private void btPesquisarOrderId_Click(object sender, EventArgs e)
        {
            //Limpa o liste depois da consulta
            this.listOrderId.Clear();

            this.PesquisarAjuste(listOrderId);
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {

        }

        public void PesquisarAjustes(List<Int64> listOrder)
        {
            ajusteBLL = new AjusteBLL();

            if(this.txOrderId.Text.Length != 0)
            {
                listOrder.Add(Convert.ToInt64(this.txOrderId.Text));
            }

            ajusteBLL.PesquisarAjustes(listOrder);

        }

        private void btImportarOrderLote_Click(object sender, EventArgs e)
        {
            AjustesLote ajustesLote = new AjustesLote(frmApp, this);
            ajustesLote.Show();
        }

        private void incluirAjusteTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjustesDAO ajustesDAO = new AjustesDAO();
/*
            AjustesModelo ajustesModelo1 = new AjustesModelo();

            ajustesModelo1._id = "61b4b14e954270191a593028";
            ajustesModelo1.idLojista = 35823;
            ajustesModelo1.nomeLojista = "TAQI OFICIAL";
            ajustesModelo1.idBandeira = 3;
            ajustesModelo1.descricaoBandeira = "Casas Bahia";
            ajustesModelo1.dataCriacao = Convert.ToDateTime("2021-12-13T12:43:28.108+0000");
            ajustesModelo1.dataLiberacao = Convert.ToDateTime("2022-01-10T03:00:00.000+0000");
            ajustesModelo1.tipoAjuste = 1;
            ajustesModelo1.valorAjuste = "52.36";
            ajustesModelo1.motivoAjustes = 16;
            ajustesModelo1.motivoAjustesDescricao = "Credito de Campanha";
            ajustesModelo1.numeroPedido = 30308615501;
            //ajustesModelo1.protocoloAtendimento = "220104-007078";
            //ajustesModelo2.observacoes = "10.11 - Cancelamento indevido - Via ajuste valores (Repasse e Comissao) - VIA0202478";
            ajustesModelo1.status = "INTEGRADO";
            ajustesModelo1.plataformaTransacao = "GETNET";
            ajustesModelo1.qtdTentativasEnvioGetNet = "0";
            ajustesModelo1.codigoRetorno = "4572237";
            ajustesModelo1.usuarioLogado = "AUTOMATICO";
            ajustesModelo1._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";
            ajustesModelo1.dataTentativa = Convert.ToDateTime( "2022-01-06T12:59:12.624+0000");
            ajustesModelo1.processado = true;
            ajustesModelo1.ajustesEncontrados = 1;
            ajustesModelo1.idDinheiro = "61b4b14e954270191a593028";
            ajustesModelo1.idAnterior = "61b73ff050d1805ca9931f94";

            ajustesModelo1.codigoGetnet = null;


            //AjustesModelo.Motivorecusa motivorecusa1 = new AjustesModelo.Motivorecusa();
            //motivorecusa1.statusNoMomentoDaRecusa = "AGENDADO";
            //motivorecusa1.mensagem = "";
            //motivorecusa1.dataDaRecusa = Convert.ToDateTime("2022-03-28T23:23:16.174+0000");

            //AjustesModelo.Motivorecusa[] arrayMotivorecusa1 = new AjustesModelo.Motivorecusa[1];

            //ajustesModelo1.setMotivoRecusa(arrayMotivorecusa1);

            //ajustesModelo1.setMotivoRecusa(arrayMotivorecusa1);

            //ajustesModelo1._id = "613b92213d056f18574edb26";
            //ajustesModelo1.idLojista = 26695;
            //ajustesModelo1.nomeLojista = "Moderna Mobília";
            //ajustesModelo1.idBandeira = 3;
            //ajustesModelo1.dataCriacao = Convert.ToDateTime("18/04/2022 22:25:59");
            //ajustesModelo1.dataLiberacao = Convert.ToDateTime("20/04/2022 03:00:00");
            //ajustesModelo1.tipoAjuste = 2;
            //ajustesModelo1.valorAjuste = "266.86";
            //ajustesModelo1.motivoAjustes = 18;
            //ajustesModelo1.motivoAjustesDescricao = "Cadastro de Comissão";
            //ajustesModelo1.numeroPedido = 28275505001;
            //ajustesModelo1.protocoloAtendimento = "210828-009116";
            //ajustesModelo1.status = "INTEGRADO_COM_O_ARRANJO";
            //ajustesModelo1.qtdTentativasEnvioGetNet = "0";
            //ajustesModelo1.codigoGetnet = "3112647";
            ////ajustesMode1lo.dataPrevisaoPagamento = Convert.ToDateTime("20/04/2022 00:00:00");
            //ajustesModelo1._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";

            listAjuste.Add(ajustesModelo1);


            AjustesModelo ajustesModelo2 = new AjustesModelo();

            ajustesModelo2._id = "61d6e16c060e271b3e927148";
            ajustesModelo2.idLojista = 35823;
            ajustesModelo2.nomeLojista = "TAQI OFICIAL";
            ajustesModelo2.idBandeira = 3;
            ajustesModelo2.descricaoBandeira = "Casas Bahia";
            ajustesModelo2.dataCriacao = Convert.ToDateTime("2022-01-06T12:32:44.065+0000");
            ajustesModelo2.dataLiberacao = Convert.ToDateTime("2022-01-10T03:00:00.000+0000");
            ajustesModelo2.tipoAjuste = 2;
            ajustesModelo2.valorAjuste = "94.3";
            ajustesModelo2.motivoAjustes = 18;
            ajustesModelo2.motivoAjustesDescricao = "Cancelamento do Lojista";
            ajustesModelo2.numeroPedido = 30308615501;
            ajustesModelo2.protocoloAtendimento = "220104-007078";
            //ajustesModelo2.observacoes = "10.11 - Cancelamento indevido - Via ajuste valores (Repasse e Comissao) - VIA0202478";
            ajustesModelo2.status = "ERRO_AJUSTE";
            //ajustesModelo2
            ajustesModelo2.qtdTentativasEnvioGetNet = "0";
            ajustesModelo2.usuarioLogado = "AUTOMATICO";
            ajustesModelo2._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";
            ajustesModelo2.codigoGetnet = null;
            ajustesModelo2.codigoRetorno = null;

            AjustesModelo.Motivorecusa motivorecusa = new AjustesModelo.Motivorecusa();
            motivorecusa.statusNoMomentoDaRecusa = "AGENDADO";
            motivorecusa.mensagem = "";
            motivorecusa.dataDaRecusa = Convert.ToDateTime("2022-03-28T23:23:16.174+0000");

            AjustesModelo.Motivorecusa[] arrayMotivorecusa = new AjustesModelo.Motivorecusa[1];

            ajustesModelo2.setMotivoRecusa(arrayMotivorecusa);

            ajustesModelo2.setMotivoRecusa(arrayMotivorecusa);

            listAjuste.Add(ajustesModelo2);


            //************* 3

            AjustesModelo ajustesModelo3 = new AjustesModelo();

            ajustesModelo3._id = "61d6e16c060e271b3e92714a";
            ajustesModelo3.idLojista = 35823;
            ajustesModelo3.nomeLojista = "TAQI OFICIAL";
            ajustesModelo3.idBandeira = 3;
            //ajustesModelo3.descricaoBandeira = "Casas Bahia";
            ajustesModelo3.dataCriacao = Convert.ToDateTime("2022-01-06T12:44:26.059+0000");
            ajustesModelo3.dataLiberacao = Convert.ToDateTime("2022-01-20T03:00:00.000+0000");
            ajustesModelo3.tipoAjuste = 2;
            ajustesModelo3.valorAjuste = "52.36";
            ajustesModelo3.motivoAjustes = 17;
            ajustesModelo3.motivoAjustesDescricao = "Estorno de Campanha";
            ajustesModelo3.numeroPedido = 30308615501;
            ajustesModelo3.protocoloAtendimento = "220104-007078";
            //ajustesModelo2.observacoes = "10.11 - Cancelamento indevido - Via ajuste valores (Repasse e Comissao) - VIA0202478";
            ajustesModelo3.status = "INTEGRADO";
            ajustesModelo3.plataformaTransacao = "GETNET";
            //ajustesModelo2
            ajustesModelo3.qtdTentativasEnvioGetNet = "0";
            ajustesModelo3.codigoRetorno = "4666233";
            ajustesModelo3.usuarioLogado = "AUTOMATICO";
            ajustesModelo3._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";
            ajustesModelo3.dataTentativa = Convert.ToDateTime( "2022-01-17T23:41:57.421+0000");
            ajustesModelo3.identificadorOrigem = "marketplace.financeiro.adquirente.ajuste_1_626882";
            ajustesModelo3.ajustesEncontrados = 1;
            ajustesModelo3.idDinheiro = "61d6e16c060e271b3e92714a";
            ajustesModelo3.idAnterior = "61d6e42a40356552b0cb17d4";
            //ajustesModelo3.codigoGetnet = null;
            

            AjustesModelo.Motivorecusa motivorecusa3 = new AjustesModelo.Motivorecusa();
            motivorecusa3.statusNoMomentoDaRecusa = "AGENDADO";
            motivorecusa3.mensagem = "";
            motivorecusa3.dataDaRecusa = Convert.ToDateTime("2022-03-28T23:23:16.174+0000");

            AjustesModelo.Motivorecusa[] arrayMotivorecusa3 = new AjustesModelo.Motivorecusa[1];

            ajustesModelo3.setMotivoRecusa(arrayMotivorecusa3);

            ajustesModelo3.setMotivoRecusa(arrayMotivorecusa3);

            listAjuste.Add(ajustesModelo3);

            */

            //************* 4

            AjustesModelo ajustesModelo4 = new AjustesModelo();

            ajustesModelo4._id = "61c4c330a57cf8714cd7e8f4";
            ajustesModelo4.idLojista = 35823;
            ajustesModelo4.nomeLojista = "TAQI OFICIAL";
            ajustesModelo4.idBandeira = 4;
            ajustesModelo4.descricaoBandeira = "Ponto Frio";
            ajustesModelo4.dataCriacao = Convert.ToDateTime("2021-12-23T18:42:56.891+0000");
            ajustesModelo4.dataLiberacao = Convert.ToDateTime("2022-01-10T03:00:00.000+0000");
            ajustesModelo4.tipoAjuste = 2;
            ajustesModelo4.valorAjuste = "465.19";
            ajustesModelo4.motivoAjustes = 18;
            ajustesModelo4.motivoAjustesDescricao = "Cancelamento do Lojista";
            ajustesModelo4.numeroPedido = 29545893201;
            ajustesModelo4.protocoloAtendimento = "211218-004077";
            //ajustesModelo2.observacoes = "10.11 - Cancelamento indevido - Via ajuste valores (Repasse e Comissao) - VIA0202478";
            ajustesModelo4.status = "ERRO_AJUSTE";
            ajustesModelo4.plataformaTransacao = "GETNET";
            ajustesModelo4.qtdTentativasEnvioGetNet = "0";
            ajustesModelo4.codigoRetorno = null;
            ajustesModelo4.usuarioLogado = "AUTOMATICO";
            ajustesModelo4.identificadorOrigem = "marketplace.financeiro.adquirente.ajuste_1_602329";
            ajustesModelo4._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";
            ajustesModelo4.dataAgendamento = Convert.ToDateTime("2022-01-10T03:00:00.000+0000");
            ajustesModelo4.dataTentativa = Convert.ToDateTime("2022-03-28T21:14:46.979+0000");
            
            //ajustesModelo4.ajustesEncontrados = 1;
            //ajustesModelo4.idDinheiro = "61d6e16c060e271b3e92714a";
            //ajustesModelo4.idAnterior = "61d6e42a40356552b0cb17d4";
            //ajustesModelo3.codigoGetnet = null;


            AjustesModelo.Motivorecusa motivorecusa4 = new AjustesModelo.Motivorecusa();
            motivorecusa4.statusNoMomentoDaRecusa = "AGENDADO";
            motivorecusa4.mensagem = "";
            motivorecusa4.dataDaRecusa = Convert.ToDateTime("2022-03-28T23:23:17.062+0000");

            AjustesModelo.Motivorecusa[] arrayMotivorecusa4 = new AjustesModelo.Motivorecusa[1];

            ajustesModelo4.setMotivoRecusa(arrayMotivorecusa4);

            ajustesModelo4.setMotivoRecusa(arrayMotivorecusa4);

            listAjuste.Add(ajustesModelo4);



            ajustesDAO.IncluirAjusteTeste(listAjuste);
        }

        private async void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listAjuste = new List<AjustesModelo>();

            foreach(DataRow drOrder in dtOrder.Rows)
            {
                AjustesModelo ajustesModelo = new AjustesModelo();

                ajustesModelo.dataLiberacao = this.ProcessarDataLiberacao();

                ajustesModelo.idLojista = Convert.ToInt32( drOrder["Idlojista"]);
                ajustesModelo.valorAjuste = drOrder["Valor"].ToString();
                ajustesModelo.motivoAjustesDescricao = drOrder["Motivo"].ToString();
                ajustesModelo.dataCriacao = Convert.ToDateTime(drOrder["Criação"]);
                ajustesModelo.dataLiberacao = this.ProcessarDataLiberacao();// Convert.ToDateTime(drOrder["Liberação"]);
                ajustesModelo.idBandeira = Convert.ToInt32(drOrder["Bandeira"]);
                ajustesModelo.status = drOrder["Status"].ToString();
                ajustesModelo.numeroPedido = Convert.ToInt64(drOrder["Pedido"]);

                listAjuste.Add(ajustesModelo);                
            }

            bool reprocessado = false;

            ajusteBLL = new AjusteBLL();
            reprocessado = await ajusteBLL.ReprocessarAjusteAsync(listAjuste);

            if(reprocessado == true)
            {
                MessageBox.Show("Pedido reprocessado com sucesso!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                {
                    MessageBox.Show("Não foi possível efetuar alteração no ajuste. Verifique permissão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //this.PesquisarAjuste(listOrderId);
        }

        //Calcula o pagamento nas datas do dia 10 ou 20 do mês sequinte
        //Se a data > 10 o próximo pagamento será dia 20 caso contrário dia 10
        //Se a data do pagamento for sábado ou domingo joga pro próximo dia últil
        public DateTime ProcessarDataLiberacao()
        {
            int mesAtual = Convert.ToInt32(DateTime.Now.Month);
            int proximoMes = 0;
            int anoAtual = Convert.ToInt32(DateTime.Now.Year);

            DateTime dateTime = DateTime.Now;

            if (dateTime.Day > 20)
            {

                proximoMes = mesAtual + 1;

                dataLiberacao = new DateTime(anoAtual, proximoMes, 10);

                if (dataLiberacao.DayOfWeek == DayOfWeek.Saturday)
                {
                    dataLiberacao = dataLiberacao.AddDays(2);                   

                }
                if(dataLiberacao.DayOfWeek == DayOfWeek.Sunday)
                {
                    dataLiberacao = dataLiberacao.AddDays(1);
                }
            }

            if((dateTime.Day > 10) && dateTime.Day < 20)
            {
                proximoMes = mesAtual + 1;
                
                dataLiberacao = new DateTime(anoAtual, proximoMes, 20);

                if (dataLiberacao.DayOfWeek == DayOfWeek.Saturday)
                {
                    dataLiberacao = dataLiberacao.AddDays(2);

                }
                if (dataLiberacao.DayOfWeek == DayOfWeek.Sunday)
                {
                    dataLiberacao = dataLiberacao.AddDays(1);
                }

            }

            return dataLiberacao;

        }
    }
}
