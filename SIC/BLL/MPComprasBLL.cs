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
        public DataSet ConsultarPedidoFinanceiro(List<Int64> orderId)
        {
            try
            {
                mPComprasDAO = new MPComprasDAO();
                return mPComprasDAO.ConsultarPedidoFinanceiro(orderId);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
