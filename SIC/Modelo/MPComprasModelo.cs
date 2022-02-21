using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIC.Modelo
{
    public class MPComprasModelo
    {


        //public class Rootobject
        //{
            public Int64 _id { get; set; }
            public Int64 id { get; set; }
            public DateTime dataCriacaoDocumento { get; set; }
            public DateTime dataModificacaoDocumento { get; set; }
            public Int64 idCompraBandeira { get; set; }
            public Int32 idUnidadeNegocio { get; set; }
            public string idCanalVenda { get; set; }
            public DateTime data { get; set; }
            public double valor { get; set; }
            public double valorFrete { get; set; }
            public double desconto { get; set; }
            public double valorTotal { get; set; }
            public bool splitPagamento { get; set; }
            public string tipoCompra { get; set; }
            public Status status { get; set; }
            public Frete frete { get; set; }
            public Cliente cliente { get; set; }
            public Endereco[] enderecos { get; set; }
            public Lojista lojista { get; set; }
            public Iten[] itens { get; set; }
            public Entrega[] entregas { get; set; }
            public Formaspagamento1[] formasPagamentos { get; set; }
            public string _class { get; set; }
        //}

        public class Status
        {
            public string id { get; set; }
            public string descricao { get; set; }
            public DateTime dataPagamento { get; set; }
        }

        public class Frete
        {
            public double valor { get; set; }
            public double valorCobrado { get; set; }
            public string prazoEstimadoEntrega { get; set; }
            public string informacaoAdicional { get; set; }
        }

        public class Cliente
        {
            public string nome { get; set; }
            public string sobrenome { get; set; }
            public string nomeCompleto { get; set; }
            public string email { get; set; }
            public string sexo { get; set; }
            public string documento { get; set; }
            public string tipoPessoa { get; set; }
            public bool optanteSimplesNacional { get; set; }
            public string classificacaoCliente { get; set; }
            public Telefone[] telefones { get; set; }
        }

        public class Telefone
        {
            public string tipo { get; set; }
            public string numero { get; set; }
        }

        public class Lojista
        {
            public Int64 id { get; set; }
            public string nome { get; set; }
            public string classificacao { get; set; }
            public string estado { get; set; }
        }

        public class Endereco
        {
            public string tipo { get; set; }
            public string pais { get; set; }
            public string estado { get; set; }
            public string municipio { get; set; }
            public string bairro { get; set; }
            public string rua { get; set; }
            public string numero { get; set; }
            public string complemento { get; set; }
            public string cep { get; set; }
            public string receptor { get; set; }
            public string referencia { get; set; }
        }

        public class Iten
        {
            public string tipoInventario { get; set; }
            public string unidadeMedida { get; set; }
            public Int32 quantidade { get; set; }
            public double desconto { get; set; }
            public Descontoaplicado descontoAplicado { get; set; }
            public double precoDe { get; set; }
            public double precoVenda { get; set; }
            public Repasse repasse { get; set; }
            public Categoria[] categorias { get; set; }
            public Frete1 frete { get; set; }
            public Sku sku { get; set; }
        }

        public class Descontoaplicado
        {
            public string tituloPromocao { get; set; }
            public decimal descontoEmReais { get; set; }
            public decimal fatorDesconto { get; set; }
            public Onusdesconto onusDesconto { get; set; }
        }

        public class Onusdesconto
        {
            public decimal fatorViaVarejo { get; set; }
            public decimal fatorLojista { get; set; }
        }

        public class Repasse
        {
            public double valor { get; set; }
            public Comissao comissao { get; set; }
        }

        public class Comissao
        {
            public string idRastreio { get; set; }
            public string origem { get; set; }
            public double percentual { get; set; }
            public double valorComissao { get; set; }
        }

        public class Frete1
        {
            public double valor { get; set; }
            public DateTime dataEstimadaEntrega { get; set; }
            public string prazoEstimadoEntrega { get; set; }
        }

        public class Sku
        {
            public Int64 id { get; set; }
            public string idLojista { get; set; }
            public string nome { get; set; }
            public string tipo { get; set; }
            public string marca { get; set; }
            public Dimensao dimensao { get; set; }
        }

        public class Dimensao
        {
            public double comprimento { get; set; }
            public double largura { get; set; }
            public double altura { get; set; }
            public double peso { get; set; }
        }

        public class Categoria
        {
            public Int64 id { get; set; }
            public string nome { get; set; }
        }

        public class Entrega
        {
            public Int64 idCompraEntrega { get; set; }
            public Int64 idEntrega { get; set; }
            public string idEntregaLojista { get; set; }
            public string tipo { get; set; }
            public double valorTotal { get; set; }
            public double valorTotalDesconto { get; set; }
            public double juros { get; set; }
            public string idSubSeller { get; set; }
            public Iten1[] itens { get; set; }
            public Tracking[] tracking { get; set; }
            public Formaspagamento[] formasPagamento { get; set; }
            public DateTime dataEstimadaEntrega { get; set; }
            public bool envias { get; set; }
            public Marcacoesentrega marcacoesEntrega { get; set; }
        }

        public class Marcacoesentrega
        {
            public DateTime dataEmissaoNF { get; set; }
            public DateTime dataEnvio { get; set; }
            public DateTime dataEntrega { get; set; }
        }

        public class Iten1
        {
            public Int64 sku { get; set; }
            public string skuIdLojista { get; set; }
            public Int32 quantidade { get; set; }
            public double desconto { get; set; }
            public bool skuIdLojistaAtualizado { get; set; }
        }

        public class Tracking
        {
            public string codigo { get; set; }
            public DateTime data { get; set; }
            public DateTime dataCriacao { get; set; }
            public string passo { get; set; }
            public string titulo { get; set; }
            public string mensagem { get; set; }
            public string fase { get; set; }
            public string chaveNF { get; set; }
            public string nfe { get; set; }
            public string objetoId { get; set; }
            public string serieNfe { get; set; }
            public string nomeTransportadora { get; set; }
        }

        public class Formaspagamento
        {
            public Int32 id { get; set; }
            public Int32 idTipo { get; set; }
            public string bandeira { get; set; }
            public Int32 numeroParcelas { get; set; }
            public bool splitPagamento { get; set; }
            public string idPagamentoArranjo { get; set; }
            public string nsuAutorizadora { get; set; }
            public double valorPagamento { get; set; }
            public string tipo { get; set; }
            public double valorComissao { get; set; }
            public string itemSplitTag { get; set; }
            public string idCartao { get; set; }
        }

        public class Formaspagamento1
        {
            public string id { get; set; }
            public string idTipo { get; set; }
            public string bandeira { get; set; }
            public string numeroParcelas { get; set; }
            public bool splitPagamento { get; set; }
            public string idPagamentoArranjo { get; set; }
            public string nsuAutorizadora { get; set; }
            public float valorPagamento { get; set; }
            public string tipo { get; set; }
            public float valorComissao { get; set; }
        }

    }
}
