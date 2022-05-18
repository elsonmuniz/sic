using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SIC.DAO;
using System.Windows.Forms;
using SIC.Modelo;

namespace SIC.BLL
{
    public class TempBLL
    {
        TempDAO tempDAO;

        public DataTable ConsultarPrecoAlterado(string sChamado, LoginModelo loginModelo)
        {
            tempDAO = new TempDAO();

            if (sChamado.ToString().Length != 0)
            {
                return tempDAO.ConsultarPrecoAlterado(sChamado, loginModelo);
            }
            else
            {
                MessageBox.Show("Digite o código do Seller válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tempDAO.ConsultarPrecoAlterado(sChamado, loginModelo);
        }
    }
}
