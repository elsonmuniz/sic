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


            public Int64 _id { get; set; }
            public Int64 Id { get; set; }
            public DateTime DataCriacaoDocumento { get; set; }
            public DateTime DataModificacaoDocumento { get; set; }
            public Int64 IdCompraBandeira { get; set; }
            public Int32 IdUnidadeNegocio { get; set; }
            public string IdCanalVenda { get; set; }
            public DateTime Data { get; set; }
            public double Valor { get; set; }
            public double ValorFrete { get; set; }
            public double Desconto { get; set; }
            public double ValorTotal { get; set; }
            public bool SplitPagamento { get; set; }
            public string TipoCompra { get; set; }
            public Status status { get; set; }
            public Frete frete { get; set; }
            public Cliente cliente { get; set; }
            public Endereco[] enderecos { get; set; }
            public Lojista lojista { get; set; }
            public Iten[] itens { get; set; }
            public Entrega[] entregas { get; set; }
            public Formaspagamento1[] formasPagamentos { get; set; }
            public string _class { get; set; }
       

        public class Status
        {
            public string Id { get; set; }
            public string Descricao { get; set; }
            public DateTime DataPagamento { get; set; }
        }

        public class Frete
        {
            public double Valor { get; set; }
            public double ValorCobrado { get; set; }
            public string PrazoEstimadoEntrega { get; set; }
            public string InformacaoAdicional { get; set; }
        }

        public class Cliente
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string NomeCompleto { get; set; }
            public string Email { get; set; }
            public string Sexo { get; set; }
            public string Documento { get; set; }
            public string TipoPessoa { get; set; }
            public bool OptanteSimplesNacional { get; set; }
            public string ClassificacaoCliente { get; set; }
            public Telefone[] Telefones { get; set; }
        }

        public class Telefone
        {
            public string Tipo { get; set; }
            public string Numero { get; set; }
        }

        public class Lojista
        {
            public Int64 Id { get; set; }
            public string Nome { get; set; }
            public string Classificacao { get; set; }
            public string Estado { get; set; }
        }

        public class Endereco
        {
            public string Tipo { get; set; }
            public string Pais { get; set; }
            public string Estado { get; set; }
            public string Municipio { get; set; }
            public string Bairro { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Cep { get; set; }
            public string Receptor { get; set; }
            public string Referencia { get; set; }
        }

        public class Iten
        {
            public string TipoInventario { get; set; }
            public string UnidadeMedida { get; set; }
            public Int32 Quantidade { get; set; }
            public double Desconto { get; set; }
            public Descontoaplicado descontoAplicado { get; set; }
            public double PrecoDe { get; set; }
            public double PrecoVenda { get; set; }
            public Repasse Repasse { get; set; }
            public Categoria[] categorias { get; set; }
            public Frete1 frete { get; set; }
            public Sku Sku { get; set; }
        }

        public class Descontoaplicado
        {
            public string TituloPromocao { get; set; }
            public decimal DescontoEmReais { get; set; }
            public decimal FatorDesconto { get; set; }
            public Onusdesconto onusDesconto { get; set; }
        }

        public class Onusdesconto
        {
            public decimal FatorViaVarejo { get; set; }
            public decimal FatorLojista { get; set; }
        }

        public class Repasse
        {
            public double Valor { get; set; }
            public Comissao Comissao { get; set; }
        }

        public class Comissao
        {
            public string IdRastreio { get; set; }
            public string Origem { get; set; }
            public double Percentual { get; set; }
            public double ValorComissao { get; set; }
        }

        public class Frete1
        {
            public double Valor { get; set; }
            public DateTime DataEstimadaEntrega { get; set; }
            public string PrazoEstimadoEntrega { get; set; }
        }

        public class Sku
        {
            public Int64 Id { get; set; }
            public string IdLojista { get; set; }
            public string Nome { get; set; }
            public string Tipo { get; set; }
            public string Marca { get; set; }
            public Dimensao dimensao { get; set; }
        }

        public class Dimensao
        {
            public double Comprimento { get; set; }
            public double Largura { get; set; }
            public double Altura { get; set; }
            public double Peso { get; set; }
        }

        public class Categoria
        {
            public Int64 Id { get; set; }
            public string Nome { get; set; }
        }

        public class Entrega
        {
            public Int64 IdCompraEntrega { get; set; }
            public Int64 IdEntrega { get; set; }
            public string IdEntregaLojista { get; set; }
            public string Tipo { get; set; }
            public double ValorTotal { get; set; }
            public double ValorTotalDesconto { get; set; }
            public double Juros { get; set; }
            public string IdSubSeller { get; set; }
            public Iten1[] itens { get; set; }
            public Tracking[] tracking { get; set; }
            public Formaspagamento[] formasPagamento { get; set; }
            public DateTime dataEstimadaEntrega { get; set; }
            public bool Envias { get; set; }
            public Marcacoesentrega marcacoesEntrega { get; set; }
        }

        public class Marcacoesentrega
        {
            public DateTime DataEmissaoNF { get; set; }
            public DateTime DataEnvio { get; set; }
            public DateTime DataEntrega { get; set; }
        }

        public class Iten1
        {
            public Int64 Sku { get; set; }
            public string SkuIdLojista { get; set; }
            public Int32 Quantidade { get; set; }
            public double Desconto { get; set; }
            public bool SkuIdLojistaAtualizado { get; set; }
        }

        public class Tracking
        {
            public string Codigo { get; set; }
            public DateTime Data { get; set; }
            public DateTime DataCriacao { get; set; }
            public string Passo { get; set; }
            public string Titulo { get; set; }
            public string Mensagem { get; set; }
            public string Fase { get; set; }
            public string ChaveNF { get; set; }
            public string Nfe { get; set; }
            public string ObjetoId { get; set; }
            public string SerieNfe { get; set; }
            public string NomeTransportadora { get; set; }
        }

        public class Formaspagamento
        {
            public Int32 Id { get; set; }
            public Int32 IdTipo { get; set; }
            public string Bandeira { get; set; }
            public Int32 NumeroParcelas { get; set; }
            public bool SplitPagamento { get; set; }
            public string IdPagamentoArranjo { get; set; }
            public string NsuAutorizadora { get; set; }
            public double ValorPagamento { get; set; }
            public string Tipo { get; set; }
            public double ValorComissao { get; set; }
            public string ItemSplitTag { get; set; }
            public string IdCartao { get; set; }
        }

        public class Formaspagamento1
        {
            public string Id { get; set; }
            public string IdTipo { get; set; }
            public string Bandeira { get; set; }
            public string NumeroParcelas { get; set; }
            public bool SplitPagamento { get; set; }
            public string IdPagamentoArranjo { get; set; }
            public string NsuAutorizadora { get; set; }
            public float ValorPagamento { get; set; }
            public string Tipo { get; set; }
            public float ValorComissao { get; set; }
        }

    }
}
