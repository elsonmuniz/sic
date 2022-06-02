using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;
using System.Data;

namespace SIC.BLL
{
    public class AjusteBLL
    {
        //DAO
        AjustesDAO ajustesDAO;

        //DataTable
        DataTable dtOrderAjuste = new DataTable();

        //List
        List<AjustesModelo> listOrder = new List<AjustesModelo>();

        public DataTable PesquisarAjustes(List<Int64> listOrderid)
        {
            ajustesDAO = new AjustesDAO();
            listOrder = ajustesDAO.PesquisarAjustes(listOrderid);

            this.MontarTabela();

            for(int i = 0; i < listOrder.Count; i++)
            {
                DataRow dr = dtOrderAjuste.NewRow();

                dr[0] = listOrder[i].idLojista;
                dr[1] = listOrder[i].nomeLojista;
                dr[2] = listOrder[i].valorAjuste;
                dr[3] = listOrder[i].motivoAjustesDescricao;
                dr[4] = listOrder[i].dataCriacao;
                dr[5] = listOrder[i].dataLiberacao;
                dr[6] = listOrder[i].idBandeira;
                dr[7] = listOrder[i].status;
                dr[8] = listOrder[i].numeroPedido;

                dtOrderAjuste.Rows.Add(dr);
            }

            return dtOrderAjuste;

        }

        public void MontarTabela()
        {
            DataColumn dcIdLojista = new DataColumn("IdLojista", typeof(string));
            DataColumn dcLojista = new DataColumn("Lojista", typeof(string));
            DataColumn dcValor = new DataColumn("Valor", typeof(string));
            DataColumn dcMotivo = new DataColumn("Motivo", typeof(string));
            DataColumn dcCriacao = new DataColumn("Criação", typeof(string));
            DataColumn dcLiberacao = new DataColumn("Liberação", typeof(string));
            DataColumn dcBandeira = new DataColumn("Bandeira", typeof(string));
            DataColumn dcStatus = new DataColumn("Status", typeof(string));
            DataColumn dcPedido = new DataColumn("Pedido", typeof(string));

            dtOrderAjuste.Columns.AddRange(new DataColumn[] { dcIdLojista, dcLojista, dcValor, dcMotivo, dcCriacao, dcLiberacao, dcBandeira, dcStatus, dcPedido });
        }
    }
}
