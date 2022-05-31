using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class UsuarioExternoModelo
    {
            public string _id { get; set; }
            public string usuario { get; set; }
            public string cpf { get; set; }
            public string email { get; set; }
            public string nome { get; set; }
            public string senha { get; set; }
            public string sobrenome { get; set; }
            public bool inativo { get; set; }
            public int tentativasAutenticacao { get; set; }
            public bool contaBloqueada { get; set; }
            public object[] perfis { get; set; }
            public Loja[] lojas { get; set; }
            public bool emailVerificado { get; set; }
            public bool emOnboarding { get; set; }
            public DateTime dataCriacao { get; set; }
            public DateTime dataAtualizacao { get; set; }
            public string criadoPor { get; set; }
            public string modificadoPor { get; set; }
            public string _class { get; set; }
        }

        public class Loja
        {
            public string nome { get; set; }
            public string idLoja { get; set; }
            public bool contaPrincipal { get; set; }
            public bool envvias { get; set; }
        }
    
}
