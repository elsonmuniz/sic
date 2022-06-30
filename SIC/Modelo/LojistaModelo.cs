using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class LojistaModelo
    {

        
            public int _id { get; set; }
            public Aprovacao aprovacao { get; set; }
            public DateTime dataCriacao { get; set; }
            public DateTime dataModificacaoDocumento { get; set; }
            public string nomeFantasia { get; set; }
            public string razaoSocial { get; set; }
            public string nomeLoja { get; set; }
            public string inscricaoEstadual { get; set; }
            public string numeroDocumento { get; set; }
            public string telefoneComercial { get; set; }
            public string email { get; set; }
            public Contato[] contatos { get; set; }
            public Endereco[] enderecos { get; set; }
            public Enderecoscd[] enderecosCD { get; set; }
            public Permissao permissao { get; set; }
            public string idGrupoItens { get; set; }
            public string status { get; set; }
            public string urlSite { get; set; }
            public Metricas metricas { get; set; }
            public Bandeira[] bandeiras { get; set; }
            public Token[] tokens { get; set; }
            public Configuracoes configuracoes { get; set; }
            public Financeiro financeiro { get; set; }
            public string nomeExibicao { get; set; }
            public Naturezajuridica naturezaJuridica { get; set; }
            public bool isMEI { get; set; }
            public Frete frete { get; set; }
            public string[] servicos { get; set; }
            public bool envvias { get; set; }
            public bool etiquetaDanfe { get; set; }
            public Faturamento faturamento { get; set; }
            public bool internacional { get; set; }
            public string _class { get; set; }
            public DateTime onBoardingDateKafkaSent { get; set; }
            public bool kafkaSent { get; set; }
            public DateTime escribaDateKafkaSent { get; set; }
            public int hashEnderecoAtual { get; set; }
        

        public class Aprovacao
        {
            public string status { get; set; }
            public DateTime data { get; set; }
            public string observacao { get; set; }
        }

        public class Permissao
        {
            public string tipo { get; set; }
            public string descricao { get; set; }
        }

        public class Metricas
        {
            public int totalSkus { get; set; }
            public int skusAtivos { get; set; }
            public int skusEstoque { get; set; }
            public DateTime ultimaAlteracaoPreco { get; set; }
            public DateTime ultimaAlteracaoEstoque { get; set; }
        }

        public class Configuracoes
        {
            public Lojista lojista { get; set; }
            public Negocio negocio { get; set; }
            public Sistema sistema { get; set; }
            public Integraco[] integracoes { get; set; }
        }

        public class Lojista
        {
            public string informacoesLoja { get; set; }
            public string urlLogo { get; set; }
            public string statusLoja { get; set; }
            public string urlLogoExtra { get; set; }
            public string politicaTroca { get; set; }
            public string politicaFrete { get; set; }
        }

        public class Negocio
        {
            public bool pagamentoAntecipado { get; set; }
            public bool restricaoVendaPJ { get; set; }
        }

        public class Sistema
        {
            public string tipoFrete { get; set; }
            public bool ornAtivo { get; set; }
            public object margemContingenciaReserva { get; set; }
            public object pontoControleComissionamento { get; set; }
        }

        public class Integraco
        {
            public string tipo { get; set; }
            public string endpoint { get; set; }
            public string tamanhoLote { get; set; }
        }

        public class Financeiro
        {
            public Carteira[] carteiras { get; set; }
            public Dadosbancarios dadosBancarios { get; set; }
            public string idTransacaoAdquirente { get; set; }
            public DateTime dataUltimaAtualizacao { get; set; }
        }

        public class Dadosbancarios
        {
            public string banco { get; set; }
            public string agencia { get; set; }
            public string digitoAgencia { get; set; }
            public string conta { get; set; }
            public string digitoConta { get; set; }
        }

        public class Carteira
        {
            public string bandeira { get; set; }
            public string merchantId { get; set; }
            public string idBandeiraGetNet { get; set; }
            public string idLojistaGetNet { get; set; }
            public DateTime dataIntegracao { get; set; }
            public string status { get; set; }
            public bool capturaHabilitada { get; set; }
            public bool antecipacaoHabilitada { get; set; }
            public bool habilitado { get; set; }
            public string idPlanoPagamento { get; set; }
            public DateTime dataCriacao { get; set; }
            public string msgIteracao { get; set; }
        }

        public class Naturezajuridica
        {
            public string codigo { get; set; }
            public string nome { get; set; }
        }

        public class Frete
        {
            public string descricao { get; set; }
            public string endpoint { get; set; }
            public string tempoPreparo { get; set; }
            public string cepOrigem { get; set; }
        }

        public class Faturamento
        {
            public DateTime valoresAtualizadosEm { get; set; }
            public DateTime valoresApuradosAte { get; set; }
            public Faturamentoanual[] faturamentoAnual { get; set; }
        }

        public class Faturamentoanual
        {
            public int ano { get; set; }
            public string valor { get; set; }
        }

        public class Contato
        {
            public string tipo { get; set; }
            public string nome { get; set; }
            public string sobrenome { get; set; }
            public string email { get; set; }
            public string telefone { get; set; }
        }

        public class Endereco
        {
            public string tipo { get; set; }
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string numero { get; set; }
        }

        public class Enderecoscd
        {
            public string idEndereco { get; set; }
            public string tipo { get; set; }
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string numero { get; set; }
            public string pais { get; set; }
        }

        public class Bandeira
        {
            public string id { get; set; }
            public string nome { get; set; }
            public string status { get; set; }
        }

        public class Token
        {
            public string tipo { get; set; }
            public string valor { get; set; }
        }

    }
}
