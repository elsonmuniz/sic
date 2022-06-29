using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIC.Modelo
{
    public class AjustesModelo
    {
            public string _id { get; set; }
            public Int64 idLojista { get; set; }
            public string nomeLojista { get; set; }
            public Int32? idBandeira { get; set; }
            public string descricaoBandeira { get; set; }
            public DateTime? dataLiberacao { get; set; }
            public DateTime? dataPrevisaoPagamento { get; set; }
            public int? tipoAjuste { get; set; }
            public string valorAjuste { get; set; }
            public int? motivoAjustes { get; set; }
            public string motivoAjustesDescricao { get; set; }
            public long numeroPedido { get; set; }
            public string protocoloAtendimento { get; set; }
            public string observacoes { get; set; }
            public string status { get; set; }
            public string plataformaTransacao { get; set; }
            public string qtdTentativasEnvioGetNet { get; set; }
            public string usuarioLogado { get; set; }
            public bool deveGerarGatilho { get; set; }
            public bool visivelApenasAnalistas { get; set; }
            public string _class { get; set; }
            public DateTime? dataTentativa { get; set; }
            public string identificadorOrigem { get; set; }
            public bool processado { get; set; }
            public int? ajustesEncontrados { get; set; }        
            public string idDinheiro { get; set; }
            public string idAnterior { get; set; }
            public string codigoGetnet { get; set; }
            public string codigoRetorno { get; set; }
            public Motivorecusa[] motivoRecusa { get; set; }
            public DateTime? dataCriacao { get; set; }
            public DateTime? dataAgendamento { get; set; }


        public class Motivorecusa
        {
            public string statusNoMomentoDaRecusa { get; set; }
            public string mensagem { get; set; }
            public DateTime dataDaRecusa { get; set; }
        }

        public void setMotivoRecusa(Motivorecusa[] motivoRecusa)
        {
            this.motivoRecusa = motivoRecusa;
        }

    }
}
