using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class GatilhoModelo
    {

        private List<GatilhoModelo> gatilhoModeloList = new List<GatilhoModelo>();


            public string _id { get; set; }
            public Liberacaopagamentodto[] LiberacaoPagamentoDTO { get; set; }
            public Dadosparapagamento[] dadosParaPagamento { get; set; }
            public DateTime DataGatilho { get; set; }
            public long IdEntrega { get; set; }
            public Payload[] payload { get; set; }
            public int Retentativa { get; set; }
            public string StatusOperacao { get; set; }
            public bool Processado { get; set; }
            public Motivos[] motivos { get; set; }
            public string _class { get; set; }

        public void setLiberacaoPagamentoDTO(Liberacaopagamentodto[] liberacaopagamentodto)
        {
            this.LiberacaoPagamentoDTO = liberacaopagamentodto;
        }

        public void setPayload(Payload[] payload)
        {
            this.payload = payload;
        }

        public void setDadosParaPagamento(Dadosparapagamento[] dadosParaPagamento)
        {
            this.dadosParaPagamento = dadosParaPagamento;
        }

        public void setMotivos(Motivos[] motivos)
        {
            this.motivos = motivos;
        }


        public class Liberacaopagamentodto
        {
            public int idLojista { get; set; }
            public long idEntrega { get; set; }
            public int idBandeira { get; set; }
            public DateTime dataTracking { get; set; }
            public string plataformaTransacao { get; set; }
            public string porcentagemComissao { get; set; }
            public DateTime dataDaCompra { get; set; }
            public DateTime dataDaCaptura { get; set; }
            public Dadosparapagamento[] dadosParaPagamento { get; set; }
            public string idPlanoPagamento { get; set; }
        }

        public class Dadosparapagamento
        {
            public string itemSplitTag { get; set; }
            public string idPagamento { get; set; }
            public string valorCentavos { get; set; }
            public string valorJurosCentavos { get; set; }
        }

        public class Payload
        {
            public Idspagamento[] idsPagamentos { get; set; }
            public DateTime dataLiberacaoPagamento { get; set; }
            public string idSubSeller { get; set; }
            public Itensliberado[] itensLiberados { get; set; }
            public string idSeller { get; set; }
            public string _class { get; set; }
        }

        public class Idspagamento
        {
            public string idPagamento { get; set; }
        }

        public class Itensliberado
        {
            public string _id { get; set; }
            public int valor { get; set; }
            public string tagItem { get; set; }
        }

        public class Motivos
        {
            public string zero { get; set; }
            public string um { get; set; }
            public string dois { get; set; }
            public string tres { get; set; }            
        }


    }
}
