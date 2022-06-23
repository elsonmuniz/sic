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

            //AjustesModelo ajustesModelo1 = new AjustesModelo();

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

            //listAjuste.Add(ajustesModelo1);


            AjustesModelo ajustesModelo2 = new AjustesModelo();

            ajustesModelo2._id = "61d32cac060e271b3e908e62";
            ajustesModelo2.idLojista = 41754;
            ajustesModelo2.nomeLojista = "VX";
            ajustesModelo2.idBandeira = 3;
            ajustesModelo2.descricaoBandeira = "Casas Bahia";
            ajustesModelo2.dataCriacao = Convert.ToDateTime("2022-01-03T17:04:44.355+0000");
            ajustesModelo2.dataLiberacao = Convert.ToDateTime("2022-01-10T03:00:00.000+0000");
            ajustesModelo2.tipoAjuste = 2;
            ajustesModelo2.valorAjuste = "87.3";
            ajustesModelo2.motivoAjustes = 18;
            ajustesModelo2.motivoAjustesDescricao = "Cancelamento do Lojista";
            ajustesModelo2.numeroPedido = 29961391601;
            ajustesModelo2.protocoloAtendimento = "211229-003783";
            //ajustesModelo2.observacoes = "10.11 - Cancelamento indevido - Via ajuste valores (Repasse e Comissao) - VIA0202478";
            ajustesModelo2.status = "RECUSADO_ARRANJO";
            ajustesModelo2.qtdTentativasEnvioGetNet = "0";
            ajustesModelo2.usuarioLogado = "AUTOMATICO";
            ajustesModelo2._class = "br.com.viavarejo.mpdinheiro.model.mongodb.AjusteEntity";
            ajustesModelo2.codigoGetnet = null;
            ajustesModelo2.codigoRetorno = null;

            AjustesModelo.Motivorecusa motivorecusa = new AjustesModelo.Motivorecusa();
            motivorecusa.statusNoMomentoDaRecusa = "NOVO";
            motivorecusa.mensagem = "DATE ADJUSTMENT IS INVALID";
            motivorecusa.dataDaRecusa = Convert.ToDateTime("2022-06-22T13:08:39.062+0000");

            AjustesModelo.Motivorecusa[] arrayMotivorecusa = new AjustesModelo.Motivorecusa[1];

            //arrayMotivorecusa[0].statusNoMomentoDaRecusa = motivorecusa.statusNoMomentoDaRecusa;
            //arrayMotivorecusa[1].mensagem = motivorecusa.mensagem;
            //arrayMotivorecusa[2].mensagem = motivorecusa.mensagem;

            


            //arrayMotivorecusa[0].statusNoMomentoDaRecusa = motivorecusa.statusNoMomentoDaRecusa;
            //arrayMotivorecusa[1].mensagem = motivorecusa.mensagem;
            //arrayMotivorecusa[2].dataDaRecusa = motivorecusa.dataDaRecusa;

            ajustesModelo2.setMotivoRecusa(arrayMotivorecusa);


            ajustesModelo2.setMotivoRecusa(arrayMotivorecusa);

            listAjuste.Add(ajustesModelo2);
            






            //ajustesModelo._id = "613b92213d056f18574edb26";
            //ajustesModelo.idLojista = 18368;
            //ajustesModelo.valorAjuste = "266.86";
            //ajustesModelo.motivoAjustesDescricao = "Cadastro de Comissão";
            //ajustesModelo.dataCriacao = Convert.ToDateTime("18/04/2022 22:25:59");
            //ajustesModelo.dataLiberacao = Convert.ToDateTime("20/04/2022 03:00:00");
            //ajustesModelo.dataPrevisaoPagamento = Convert.ToDateTime("20/04/2022 00:00:00");
            //ajustesModelo.idBandeira = 3;
            //ajustesModelo.status = "INTEGRADO_COM_O_ARRANJO";
            //ajustesModelo.numeroPedido = 31853962001;

            //foreach (DataRow drOrder in dtOrder.Rows)
            //{
            //    ajustesModelo.idLojista = Convert.ToInt64(drOrder["IdLojista"]);
            //    ajustesModelo.valorAjuste = drOrder["Valor"].ToString();
            //    ajustesModelo.motivoAjustesDescricao = drOrder["Motivo"].ToString();
            //    ajustesModelo.dataCriacao = Convert.ToDateTime(drOrder["Criação"]);
            //    ajustesModelo.dataLiberacao = Convert.ToDateTime(drOrder["Liberação"]);
            //    //ajustesModelo.dataPrevisaoPagamento = Convert.ToDateTime("");
            //    ajustesModelo.idBandeira = Convert.ToInt32(drOrder["Bandeira"]);
            //    ajustesModelo.status = drOrder["Status"].ToString();
            //    ajustesModelo.numeroPedido = Convert.ToInt64(drOrder["Pedido"]);

            //    listAjuste.Add(ajustesModelo);

                
            //}

            ajustesDAO.IncluirAjusteTeste(listAjuste);
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
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
                //ajustesModelo.dataLiberacao = Convert.ToDateTime(drOrder["Liberação"]);
                ajustesModelo.idBandeira = Convert.ToInt32(drOrder["Bandeira"]);
                ajustesModelo.status = drOrder["Status"].ToString();
                ajustesModelo.numeroPedido = Convert.ToInt64(drOrder["Pedido"]);

                listAjuste.Add(ajustesModelo);                
            }

            AjustesDAO dao = new AjustesDAO();
            dao.UpdateAjusteTeste(listAjuste);
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
