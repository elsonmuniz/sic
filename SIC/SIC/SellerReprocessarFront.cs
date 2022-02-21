using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SIC.BLL;
using SIC.Modelo;

namespace SIC
{
    public partial class SellerReprocessarFront : Forms.FormEdit
    {
        //BLL
        SellerBLL sellerBLL;

        //DataTable
        DataTable dtSeller;
        DataTable dtSellerReprocessamento;

        //Frm
        FrmApp frmApp;

        //MODELO
        LoginModelo loginModelo;
        public SellerReprocessarFront(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.lbMessage.Visible = false;

            this.loginModelo = loginModelo;
        }

        public void PesquisarSeller(int idLogista, LoginModelo loginModelo)
        {
            sellerBLL = new SellerBLL();
            dtSeller = new DataTable();
            dtSellerReprocessamento = new DataTable();

            try
            {
                this.Invoke((EventHandler)(delegate
                {
                    dtSeller = sellerBLL.ListagemSellerADPRD(idLogista, loginModelo);
                    dtSellerReprocessamento = sellerBLL.ListagemSellerReprocessamento(idLogista, loginModelo);
                    gridSeller.DataSource = dtSellerReprocessamento;

                    if (dtSeller.Rows.Count > 0)
                    {
                        this.txNomeLojista.Text = dtSeller.Rows[0][1].ToString();
                    }

                }));

                //gridSeller.Columns[0].Width = 80;
                //gridSeller.Columns[1].Width = 380;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Informe o id do lojista ou verifique se estar conectado a vpn." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //#region Buttons
        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadStart thdStr = delegate
                {
                    this.PesquisarSeller(Convert.ToInt32(this.txIdLojista.Text.Trim()), loginModelo);
                };
                var thd = new Thread(thdStr);
                thd.Start();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Invoke((EventHandler)(delegate {
                    //backgroundWorker1.CancelAsync();
                }));
            }

        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //this.lbMessage.Visible = true;

            sellerBLL = new SellerBLL();
            sellerBLL.ReprocessarLoja(Convert.ToInt32(this.txIdLojista.Text.Trim()), this.lbMessage, loginModelo);

        }

        private void SellerReprocessarFront_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
