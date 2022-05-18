using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;

namespace SIC.BLL
{
    public class LojistaAdquirenteBLL
    {
        //DAO
        SellerDAO sellerDAO;

        //LIST
        List<LojistaAdquirenteModelo> listLojistaAdquirenteModelo;

        //Modelo
        LojistaAdquirenteModelo lojistaAdquirenteModelo;

        public List<LojistaAdquirenteModelo> PesquisarAsync(List<String> idSeller)
        {
            sellerDAO = new SellerDAO();
            lojistaAdquirenteModelo = new LojistaAdquirenteModelo();
            listLojistaAdquirenteModelo = new List<LojistaAdquirenteModelo>();

            return sellerDAO.PesquisarAsync(idSeller);

            //return lojistaAdquirenteModelo;

            //try
            //{
            //    sellerDAO = new SellerDAO();
            //    return sellerDAO.PesquisarAsync(idSeller);

            //}
            //catch(Exception ex)
            //{
            //    throw new Exception("Erro: " + ex.Message);
            //}
        }
    }
}
