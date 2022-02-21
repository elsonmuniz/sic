using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.DAO;
using System.Data.Odbc;
using System.Data.SqlClient;


namespace SIC
{
    public partial class SellerViewer : Forms.FormViewer
    {
        
        public SellerViewer()
        {
            InitializeComponent();
        }

        private void SellerViewer_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable dt = new DataTable();
            //    sellerDAO = new SellerDAO();
            //    dt = sellerDAO.ListagemSellerADPRD();

            //    //conexao = Conexao.ConectarAD();
            //    conexao.Open();

            //    if(conexao.State == ConnectionState.Open)
            //    {
            //        MessageBox.Show("Conexão efetuada.","Informação",MessageBoxButtons.OK);

            //    }
            //    else
            //    {
            //        conexao.Close();
            //    }
                
            //}
            //catch (Exception ex)
            //{

            //    throw new Exception(ex.Message);
            //}
            
            
        }
    }
}
