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
    public partial class SellerEditFront : Forms.FormEdit
    {
        //BLL
        SellerBLL sellerBLL;

        //DataTable
        DataTable dtSeller;

        //Frm
        FrmApp frmApp;

        //MODELO
        LoginModelo loginModelo;
        public SellerEditFront(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        public void PesquisarSellerFront(int idLogista, LoginModelo loginModelo)
        {
            sellerBLL = new SellerBLL();
            dtSeller = new DataTable();

            try
            {
                dtSeller = sellerBLL.ListagemSellerFRONT(idLogista, loginModelo);

                gridSellerFront.DataSource = dtSeller;

                if (dtSeller.Rows.Count > 0 || dtSeller != null)
                {
                    this.txNomeLojista.Text = dtSeller.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Não existe registro retornado da tabela", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }

            gridSellerFront.Columns[0].Width = 80;
            gridSellerFront.Columns[1].Width = 280;
            gridSellerFront.Columns[2].Width = 100;
            gridSellerFront.Columns[3].Width = 100;
            gridSellerFront.Columns[4].Width = 100;

        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            this.PesquisarSellerFront(Convert.ToInt32(this.txIdLojista.Text.Trim()), loginModelo);
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellerBLL = new SellerBLL();
            sellerBLL.AtivarSellerFront(Convert.ToInt32(this.txIdLojista.Text), loginModelo);
            this.PesquisarSellerFront(Convert.ToInt32(this.txIdLojista.Text.Trim()), loginModelo);
        }

        private void SellerEditFront_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Consulta loja ativa front");
        }
    }
}
