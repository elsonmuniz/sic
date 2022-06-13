using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class OrderBandeiraModelo
    {
        public OrderBandeiraModelo()
        {

        }

        public OrderBandeiraModelo(Int64 orderId, string idGetNet, Int32 idBandeira)
        {
            this.OrderId = orderId;
            this.IdGetnet = idGetNet;
            this.IdBandeira = idBandeira;
        }

        public Int64 OrderId { get; set; }
        public string IdGetnet { get; set; }
        public Int32 IdBandeira { get; set; }
        public string DataConfirmacaoPagamento { get; set; }
        public string DataPrevisaoPagamento { get; set; }
    }
}
