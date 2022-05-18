using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class TrackingComissionamentoModelo
    {

            public string _id { get; set; }
            public long idCompra { get; set; }
            public long idEntrega { get; set; }
            public string status { get; set; }
            public string statusOperacao { get; set; }
            public DateTime dataIntegracao { get; set; }
            public int retentativa { get; set; }
            public object[] motivos { get; set; }
            public bool cancelamentoNotificado { get; set; }
            public Step[] steps { get; set; }
            public DateTime createdDate { get; set; }
            public DateTime lastModifiedDate { get; set; }
            public string usuarioModificacao { get; set; }
            public string _class { get; set; }
        

        public class Step
        {
            public string status { get; set; }
            public string statusOperacao { get; set; }
        }

    }
}
