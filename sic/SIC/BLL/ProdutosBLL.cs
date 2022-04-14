using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using SIC.DAO;
using SIC.Modelo;


namespace SIC.BLL
{
    public class ProdutosBLL
    {
        ProdutosDAO produtosDAO;
        public DataTable ListarSKUNaoExisteFront(int idLogista, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            if (idLogista.ToString().Length != 0)
            {
                return produtosDAO.ListarSKUNaoExisteFront(idLogista, loginModelo);
            }
            else
            {
                MessageBox.Show("Digite o código do Seller válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produtosDAO.ListarSKUNaoExisteFront(idLogista, loginModelo);
        }

        public DataTable ConsultarSkuAtivoComVariante(int idLogista, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            try
            {
                return produtosDAO.ConsultarSkuAtivoComVariante(idLogista, loginModelo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produtosDAO.ConsultarSkuAtivoComVariante(idLogista, loginModelo);

        }

        public DataTable ConsultarIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            try
            {
                return produtosDAO.ConsultarIntegracaoSKU(idSKU, loginModelo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produtosDAO.ConsultarIntegracaoSKU(idSKU, loginModelo);
        }

        public DataTable ConsultarErroIntegracaoSKU(int idSKU, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            try
            {
                return produtosDAO.ConsultarErroIntegracaoSKU(idSKU, loginModelo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produtosDAO.ConsultarErroIntegracaoSKU(idSKU, loginModelo);
        }

        public DataTable LerPlanilhaPreco(string planilhaPreco)
        {
            produtosDAO=new ProdutosDAO();

            return produtosDAO.LerPlanilhaPreco(planilhaPreco);
            
        }

        public DataTable CompararPlanilhaPreco(string planilhaPreco, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            return produtosDAO.CompararPlanilhaPreco(planilhaPreco, loginModelo);
        }

        public DataTable ConsultarSKURelated(SKUModelo sKUModelo, LoginModelo loginModelo)
        {
            produtosDAO = new ProdutosDAO();

            return produtosDAO.ConsultarSKURelated(sKUModelo, loginModelo);
        }

        public void AtivarFlagLock(LoginModelo loginModelo, SKUModelo sKUModelo)
        {
            produtosDAO = new ProdutosDAO();

            bool skuAlterado = false;
            
            try
            {
                skuAlterado = produtosDAO.AtivarFlagLock(loginModelo, sKUModelo);

                if (skuAlterado == true)
                {
                    MessageBox.Show("Flag lock ativado com sucesso!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar a Flag lock.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }


            

        }
    }
}
