using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class ConsultarLojaGetnetModelo
    {
        private long cnpj;
        public long CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private int idLojista;
        public int IdLojista
        {
            get { return idLojista; }
            set { idLojista = value; }
        }
    }
}
