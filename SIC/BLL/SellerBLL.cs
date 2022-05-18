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
    public class SellerBLL
    {
        //DAO
        SellerDAO sellerDAO;

        //Boolean
        Boolean sellerAtivada = false;
        Boolean sellerReprocessada = false;

        public DataTable ListagemSellerADPRD(int idLogista, LoginModelo loginModelo)
        {
            sellerDAO = new SellerDAO();                           
            
            if(idLogista.ToString().Length != 0)
            {
                return sellerDAO.ListagemSellerADPRD(idLogista, loginModelo);
            }

            else
            {
                MessageBox.Show("Digite o código do Seller válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerDAO.ListagemSellerADPRD(idLogista, loginModelo);
        }

        public DataTable ListagemSellerFRONT(int idLogista, LoginModelo loginModelo)
        {
            sellerDAO = new SellerDAO();

            if (idLogista.ToString().Length != 0)
            {
                return sellerDAO.ListagemSellerFront(idLogista);
            }
            else
            {
                MessageBox.Show("Digite o código do Seller válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerDAO.ListagemSellerADPRD(idLogista, loginModelo);
        }

        public Boolean AtivarSeller(int idLoja, LoginModelo loginModelo)
        {
            try
            {

                sellerDAO = new SellerDAO();
                sellerAtivada = sellerDAO.AtivarSellerAD(idLoja, loginModelo);

                if(sellerAtivada == true)
                {
                    MessageBox.Show("Seller ativada com sucesso!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível ativar a Seller", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na ativação do Seller. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerAtivada;
        }
        public Boolean AtivarSellerFront(int idLoja, LoginModelo loginModelo)
        {
            try
            {

                sellerDAO = new SellerDAO();
                sellerAtivada = sellerDAO.AtivarSellerFRONT(idLoja, loginModelo);

                if (sellerAtivada == true)
                {
                    MessageBox.Show("Seller ativada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível ativar a Seller", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na ativação do Seller. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerAtivada;
        }

        public DataTable ListagemSellerReprocessamento(int idLogista, LoginModelo loginModelo)
        {
            try
            {
                sellerDAO = new SellerDAO();
                return sellerDAO.ListagemSellerReprocessamento(idLogista, loginModelo); 
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool ReprocessarLoja(int idLogista, Label label, LoginModelo loginModelo)
        {
            try
            {
                label.Enabled = true;

                sellerDAO = new SellerDAO();
                sellerReprocessada = sellerDAO.ReprocessarLoja(idLogista, loginModelo);

                if (sellerReprocessada == true)
                {
                    MessageBox.Show("Seller reprocessada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível reprocessar a Seller", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                label.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                    
            

            return sellerAtivada;
        }
    }
}
