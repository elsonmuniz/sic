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
    public class MPComprasBLL
    {
        MPComprasDAO mPComprasDAO;
        public async Task<DataSet> ConsultarPedidoFinanceiro(List<Int64> orderId)
        {
            try
            {
                mPComprasDAO = new MPComprasDAO();
                return await mPComprasDAO.ConsultarPedidoFinanceiro(orderId);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
