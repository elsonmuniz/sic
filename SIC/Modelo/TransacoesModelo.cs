using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class TransacoesModelo
    { 
        
            public string _id { get; set; }
            public DateTime dataCriacao { get; set; }
            public DateTime dataModificacao { get; set; }
            public Int64 idAgendamentoMarketplace { get; set; }
            public string valorComissao { get; set; }
            public string valorTransacao { get; set; }
            public string valorPedido { get; set; }
            public string valorParcela { get; set; }
            public string valorRepasse { get; set; }
            public string porcentagemComissao { get; set; }
            public DateTime? dataTransacao { get; set; }
            public DateTime? dataImportacao { get; set; }
            public DateTime? dataEnvio { get; set; }
            public DateTime? dataGatilho { get; set; }
            public DateTime? dataPrevisaoPagamento { get; set; }
            public DateTime? dataEnvioPagamento { get; set; }
            public DateTime? dataConfirmacaoPagamento { get; set; }
            public DateTime dataPedido { get; set; }
            public DateTime dataParcela { get; set; }
            public int numeroParcelas { get; set; }
            public long idEntrega { get; set; }
            public Int64 idCompraBandeira { get; set; }
            public int parcelaAtual { get; set; }
            public string cpfcnpjSubseller { get; set; }
            public string cnpjMarketplace { get; set; }
            public int codigoBandeiraCartao { get; set; }
            public string descricaoBandeiraCartao { get; set; }
            public Site site { get; set; }
            public Compra compra { get; set; }
            public Lojista lojista { get; set; }
            public string tipoTransacao { get; set; }
            public string idGetNet { get; set; }
            public Conciliacao conciliacao { get; set; }
            public DateTime dataAprovacao { get; set; }
            public string pontoControle { get; set; }
            public DateTime dataNotificacao { get; set; }
            public string valorFrete { get; set; }
            public string valorFreteVia { get; set; }
        public string valorFreteLojista { get; set; }
        public string plataformaTransacao { get; set; }
            public string tipoFrete { get; set; }
            public string tipoPagamento { get; set; }
            public string tipoLiquidacao { get; set; }
            public string valorItem { get; set; }
            public string canal { get; set; }
            public Pagamento pagamento { get; set; }
            public bool visivelApenasAnalistas { get; set; }
            public string _class { get; set; }
        

        public class Site
        {
            public int _id { get; set; }
            public string nome { get; set; }
        }

        public class Compra
        {
            public long _id { get; set; }
            public DateTime dataPedido { get; set; }
            public Sku sku { get; set; }
            public Formapagamento formaPagamento { get; set; }
        }

        public class Sku
        {
            public int _id { get; set; }
            public string idLojista { get; set; }
            public string nome { get; set; }
            public Categorias categorias { get; set; }
            public Frete frete { get; set; }
        }

        public class Categorias
        {
            public int idDepartamento { get; set; }
            public string departamento { get; set; }
            public string categoria { get; set; }
            public int idCategoria { get; set; }
        }

        public class Frete
        {
            public float valor { get; set; }
            public DateTime dataEstimadaEntrega { get; set; }
            public string prazoEstimadoEntrega { get; set; }
        }

        public class Formapagamento
        {
            public string bandeira { get; set; }
            public int numeroParcelas { get; set; }
            public string tipo { get; set; }
            public Comissao comissao { get; set; }
            public bool multiplasFormasPagamento { get; set; }
        }

        public class Comissao
        {
            public string origem { get; set; }
            public string percentual { get; set; }
            public float valorComissao { get; set; }
            public string original { get; set; }
            public string tipoOriginal { get; set; }
        }

        public class Lojista
        {
            public int _id { get; set; }
            public string cnpj { get; set; }
            public string nomeFantasia { get; set; }
            public string razaoSocial { get; set; }
        }

        public class Conciliacao
        {
            public bool divergente { get; set; }
            public bool pedidoLocalizado { get; set; }
            public bool gatilhoLocalizado { get; set; }
            public string valorComissaoMarketplace { get; set; }
            public string valorComissaoGetnet { get; set; }
            public string valorRepasseMarketplace { get; set; }
            public string valorRepasseGetnet { get; set; }
            public string percentualComissaoMarketplace { get; set; }
            public string percentualComissaoGetnet { get; set; }
            public bool pagamentoDuplicado { get; set; }
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
            public string tipoOperacao { get; set; }
        }

    }
}
