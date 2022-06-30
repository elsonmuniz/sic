using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
//using MongoDB.Driver;

namespace SIC.Modelo
{
    public class LojistaAdquirenteModelo
    {

            public Int64 _id { get; set; }
            public string nomeFantasia { get; set; }
            public string razaoSocial { get; set; }
            public string nomeLoja { get; set; }
            public string numeroDocumento { get; set; }
            public string nomeExibicao { get; set; }
            public string status { get; set; }
            public Aprovacao aprovacao { get; set; }
            public Antecipacao antecipacao { get; set; }
            public Contabancaria contaBancaria { get; set; }
            public Carteira[] carteiras { get; set; }
            public DateTime dataModificacao { get; set; }
            public string transacaoVinculada { get; set; }
            public string _class { get; set; }
            //Não tem na TAG original    
            public string email { get; set; }


        public void setCarteiras(Carteira[] carteira)
        {
            this.carteiras = carteira;
        }


        public class Aprovacao
        {
            public string status { get; set; }
            public DateTime data { get; set; }
        }

        public class Antecipacao
        {
            public Stone stone { get; set; }
        }

        public class Stone
        {
            public string tipo { get; set; }
            public DateTime dataCriacao { get; set; }
        }

        public class Contabancaria
        {
            public string banco { get; set; }
            public string agencia { get; set; }
            public string digitoAgencia { get; set; }
            public string conta { get; set; }
            public string digitoConta { get; set; }
        }

        public class Carteira
        {
            public string tipoCarteiraAdquirente { get; set; }
            public int site { get; set; }
            public string idPlanoPagamento { get; set; }
            public string _id { get; set; }
            public bool repasseBloqueado { get; set; }
            public bool ativo { get; set; }
            public string status { get; set; }
            public string statusGetnet { get; set; }
            public DateTime dataIntegracao { get; set; }
            public bool capturaHabilitada { get; set; }
        }

        //[BsonId()]
        //public int Id { get; set; }

        //[BsonElement("title")]
        //[BsonRequired()]
        public string Title { get; set; }

        //1
        ///callback/getnet/retentativa/lojista/{lojistaId}
        //http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/retentativa/lojista/40159?atualizarBaseLojistaAntes=true

        //2
        ///callback/getnet/sincronizador/semfila
        /////http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila
    }
}
