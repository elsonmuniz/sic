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
    public partial class ConsultarSkuAtivoComVariante : Forms.FormEdit
    {
        FrmApp frmApp;

        //BLL
        ProdutosBLL produtosBLL;

        //DataTable
        DataTable dtSKU;

        //MODELO
        LoginModelo loginModelo;
        public ConsultarSkuAtivoComVariante(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.loginModelo = loginModelo;
        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            this.PesquisarSKU(Convert.ToInt32(this.txIdLojista.Text), loginModelo);
        }

        private void ConsultarSkuAtivoComVariante_Load(object sender, EventArgs e)
        {
            
        }

        public void PesquisarSKU(int idLogista, LoginModelo loginModelo)
        {
            produtosBLL = new ProdutosBLL();
            

            try
            {
                dtSKU = new DataTable();
                DataTable dt = new DataTable();

                DataColumn dcId = new DataColumn("Id", typeof(int));
                dcId.AutoIncrement = true;

                DataColumn dcSKU = new DataColumn("IdSKU", typeof(String));
                
                dtSKU.Columns.AddRange(new DataColumn[] { dcId, dcSKU });

                dt = produtosBLL.ConsultarSkuAtivoComVariante(idLogista, loginModelo);

                int count = 0;

                foreach(DataRow dr in dt.Rows)
                {
                    count++;

                    dtSKU.Rows.Add(count, dr[0]);
                }

                

                gridSKU.DataSource = dtSKU;

                gridSKU.Columns[0].Width = 100;
                gridSKU.Columns[1].Width = 380;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Informe o id do lojista ou verifique se estar conectado a vpn." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
