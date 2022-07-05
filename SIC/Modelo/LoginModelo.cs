using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class LoginModelo
    {

        private String id;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String usuario;        
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String senha;
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private bool logado;
        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        private String versaoSIC;
        public String VersaoSIC
        {
            get { return versaoSIC; }
            set { versaoSIC = value; }
        }
    }
}
