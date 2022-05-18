using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class PagamentosModelo
    {

            public string _id { get; set; }
            public long idEntrega { get; set; }
            public string statusOperacao { get; set; }
            public string idPagamentoArranjo { get; set; }
            public string pontoControle { get; set; }
            public Payload payload { get; set; }
            public DateTime createdDate { get; set; }
            public DateTime lastModifiedDate { get; set; }
            public string _class { get; set; }

        public void setPayload(Payload payload)
        {
            this.payload = payload;
        }
        
        public class Payload
        {
            public Int64 idLojista { get; set; }
            public Int64 idEntrega { get; set; }
            public Int32 idBandeira { get; set; }
            public DateTime dataTracking { get; set; }
            public string plataformaTransacao { get; set; }
            public string porcentagemComissao { get; set; }
            public DateTime dataDaCompra { get; set; }
            public DateTime dataDaCaptura { get; set; }
            public Dadosparapagamento[] dadosParaPagamento { get; set; }
            public string _class { get; set; }

            public void setDadosParaPagamento(Dadosparapagamento[] dadosparapagamentos)
            {
                this.dadosParaPagamento = dadosparapagamentos;
            }
        
        }

        public class Dadosparapagamento
        {
            public Int32 quantidadeParcelas { get; set; }
            public string idPagamento { get; set; }
            public decimal valorCentavos { get; set; }
            public decimal valorRepasseCentavos { get; set; }
            public decimal valorComissaoCentavos { get; set; }
            public decimal valorJurosCentavos { get; set; }
            public decimal valorFreteCentavos { get; set; }
            public DateTime dataCaptura { get; set; }
            public string nsuAutorizadora { get; set; }
        }

    }
}
