using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.BLL;
using SIC.Modelo;


namespace SIC
{
    public partial class SellerEdit : Forms.FormEdit
    {
        //BLL
        SellerBLL sellerBLL;

        //DataTable
        DataTable dtSeller;

        //Frm
        FrmApp frmApp;

        //MODELO
        LoginModelo loginModelo;

        public SellerEdit(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        private void SellerEdit_Load(object sender, EventArgs e)
        {
            
        }

        public void PesquisarSeller(int idLogista, LoginModelo loginModelo)
        {
            sellerBLL = new SellerBLL();
            dtSeller = new DataTable();

            try
            {
                dtSeller = sellerBLL.ListagemSellerADPRD(idLogista, loginModelo);

                gridSeller.DataSource = dtSeller;

                if (dtSeller != null)
                {
                    this.txNomeLojista.Text = dtSeller.Rows[0][1].ToString();
                }

                gridSeller.Columns[0].Width = 80;
                gridSeller.Columns[1].Width = 380;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Informe o id do lojista ou verifique se estar conectado a vpn." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPesquisarSeller_Click(object sender, EventArgs e)
        {
            this.PesquisarSeller(Convert.ToInt32(this.txIdLojista.Text), loginModelo);
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarSeller(Convert.ToInt32(this.txIdLojista.Text.Trim()), loginModelo);
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellerBLL = new SellerBLL();
            sellerBLL.AtivarSeller(Convert.ToInt32(this.txIdLojista.Text), loginModelo);
            this.PesquisarSeller(Convert.ToInt32(this.txIdLojista.Text.Trim()),loginModelo);
        }
    }
}
