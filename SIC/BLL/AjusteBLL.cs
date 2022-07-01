using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;
using System.Data;
using MongoDB.Bson;

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

            int cont = 1;
            if(listOrder.Count > 0)
            {
                for (int i = 0; i < listOrder.Count; i++)
                {
                    DataRow dr = dtOrderAjuste.NewRow();

                    dr[0] = cont;
                    dr[1] = listOrder[i].idLojista;
                    dr[2] = listOrder[i]._id;
                    dr[3] = listOrder[i].nomeLojista;
                    dr[4] = listOrder[i].valorAjuste;

                    if(listOrder[i].motivoRecusa != null)
                    {
                        dr[5] = listOrder[i].motivoRecusa[0].mensagem;
                    }
                    
                    dr[6] = listOrder[i].dataCriacao;
                    dr[7] = listOrder[i].dataLiberacao;
                    dr[8] = listOrder[i].dataPrevisaoPagamento;
                    dr[9] = listOrder[i].idBandeira;
                    dr[10] = listOrder[i].status;
                    dr[11] = listOrder[i].numeroPedido;

                    dtOrderAjuste.Rows.Add(dr);

                    cont++;
                }
                
            }
            else
            {
                DataRow dr = dtOrderAjuste.NewRow();
                dr[0] = cont;
                dr[1] = "Não existe ajuste";
                dr[2] = DBNull.Value; // ObjectId.Parse("");
                dr[3] = "Não existe ajuste";
                dr[4] = "Não existe ajuste";
                dr[5] = "Não existe ajuste";
                dr[6] = "Não existe ajuste";
                dr[7] = "Não existe ajuste";
                dr[8] = "Não existe ajuste";
                dr[9] = "Não existe ajuste";
                dr[10] = "Não existe ajuste";
                dr[11] = "Não existe ajuste";

                dtOrderAjuste.Rows.Add(dr);

                cont++;
            }

            return dtOrderAjuste;

        }

        public void MontarTabela()
        {
            DataColumn dcNumero = new DataColumn("Número", typeof(string));
            DataColumn dcIdLojista = new DataColumn("IdLojista", typeof(string));
            DataColumn dc_Id = new DataColumn("Id", typeof(ObjectId));
            DataColumn dcLojista = new DataColumn("Lojista", typeof(string));
            DataColumn dcValor = new DataColumn("Valor", typeof(string));
            DataColumn dcMotivo = new DataColumn("Motivo", typeof(string));
            DataColumn dcCriacao = new DataColumn("Criação", typeof(string));
            DataColumn dcLiberacao = new DataColumn("Liberação", typeof(string));
            DataColumn dcPrevisaoPagamento = new DataColumn("Prev. Pagamento", typeof(string));
            DataColumn dcBandeira = new DataColumn("Bandeira", typeof(string));
            DataColumn dcStatus = new DataColumn("Status", typeof(string));
            DataColumn dcPedido = new DataColumn("Pedido", typeof(string));

            dtOrderAjuste.Columns.AddRange(new DataColumn[] { dcNumero, dcIdLojista, dc_Id, dcLojista, dcValor, dcMotivo, dcCriacao, dcLiberacao, dcPrevisaoPagamento, dcBandeira, dcStatus, dcPedido });
        }

        public async Task<Boolean> ReprocessarAjusteAsync(List<AjustesModelo> listAjuste)
        {
            Boolean processado = false;

            try
            {
                if(listAjuste.Count >= 0)
                {
                    ajustesDAO = new AjustesDAO();
                    processado = await ajustesDAO.ReprocessarAjuste(listAjuste);

                }

                if(processado == false)
                {
                    
                }

            }
            catch (Exception)
            {

                throw;
            }

            return processado;

        }
    }
}
