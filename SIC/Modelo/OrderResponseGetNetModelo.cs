using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class OrderResponseGetNetModelo
    {

        //public class Rootobject
        //{
            public bool valido { get; set; }
            public Conteudo conteudo { get; set; }
            public string codigo { get; set; }
        //}

        public class Conteudo
        {
            public Transaco[] transacoes { get; set; }
            public Pagamento[] pagamentos { get; set; }
        }

        public class Transaco
        {
            public Resumo resumo { get; set; }
            public Detalhe[] detalhes { get; set; }
        }

        public class Resumo
        {
            public int tipoRegistro { get; set; }
            public string idPedido { get; set; }
            public int idTransacaoMarketplace { get; set; }
            public DateTime dataTransacao { get; set; }
            public string idProduto { get; set; }
            public int tipoTransacao { get; set; }
            public int numeroParcelas { get; set; }
            public string idTransacaoAdquirente { get; set; }
            public int valorTransacaoCartao { get; set; }
            public int somaValorCartaoPagamentoDetalhes { get; set; }
            public int codigoTransacaoStatus { get; set; }
            public string sinalTransacao { get; set; }
            public string nsuTerminal { get; set; }
            public string mensagemMotivo { get; set; }
            public string codigoAutorizacao { get; set; }
            public string idPagamento { get; set; }
            public string canalTransacao { get; set; }
            public string captura { get; set; }
        }

        public class Detalhe
        {
            public int tipoRegistro { get; set; }
            public int idAgendamentoMarketplace { get; set; }
            public string idSubsellerMarketplace { get; set; }
            public string statusLiberacao { get; set; }
            public string cpfcnpjSubseller { get; set; }
            public int idTransacaoMarketplace { get; set; }
            public DateTime dataTransacao { get; set; }
            public string idItem { get; set; }
            public int numeroParcelas { get; set; }
            public int parcelaAtual { get; set; }
            public DateTime dataParcela { get; set; }
            public int valorParcela { get; set; }
            public int valortaxaSubseller { get; set; }
            public float porcentagemTaxaSubseller { get; set; }
            public DateTime dataPagamento { get; set; }
            public DateTime dataEnvioPagamentoSubseller { get; set; }
            public int idSubseller { get; set; }
            public string idSeller { get; set; }
            public string sinalTransacao { get; set; }
            public string idPagamento { get; set; }
            public string nomePlanoPagamento { get; set; }
            public int numeroReferencia { get; set; }
        }

        public class Pagamento
        {
            public int tipoRegistro { get; set; }
            public string cpfcnpjSubseller { get; set; }
            public int subsellerId { get; set; }
            public int marketplaceSubsellerId { get; set; }
            public int quantiaPaga { get; set; }
            public int numeroReferencia { get; set; }
            public string tipoConta { get; set; }
            public string numeroDocumenoBeneficiario { get; set; }
            public string banco { get; set; }
            public string agencia { get; set; }
            public string numeroConta { get; set; }
            public DateTime dataConfirmacaoTaxaSubseller { get; set; }
            public string tipoOperacao { get; set; }
        }

    }
}