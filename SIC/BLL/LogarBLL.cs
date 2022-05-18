using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SIC.BLL
{
    public class LogarBLL
    {
        OracleConnection conexaoADPRD;
        public bool Logar(LoginModelo loginModelo)
        {
            Boolean usuarioConectado = false;

            try
            {
                if (loginModelo.Usuario.Length == 0)
                {
                    MessageBox.Show("Informe o usuário.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (loginModelo.Senha.Length == 0)
                {
                    MessageBox.Show("Informe a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexaoADPRD = new OracleConnection();
                    conexaoADPRD = Conexao.ConectarAD(loginModelo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioConectado;
        }
    }
}
