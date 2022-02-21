using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;
using SIC.BLL;

namespace SIC
{
    public partial class SKURelated : Forms.FormEdit
    {
        FrmApp frmApp;

        //Modelo
        SKUModelo sKUModelo;

        //BLL
        ProdutosBLL produtosBLL;

        //MODELO
        LoginModelo loginModelo;
        public SKURelated(FrmApp frmApp, LoginModelo loginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            rbSKUID.Checked = true;

            this.loginModelo = loginModelo;

        }

        private void SKURelated_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisarSKU_Click(object sender, EventArgs e)
        {
            sKUModelo = new SKUModelo();
            produtosBLL = new ProdutosBLL();

            if (rbSKUID.Checked == true)
            {
                sKUModelo.sku_id = this.txIdSKU.Text;

                this.gridSeller.DataSource = produtosBLL.ConsultarSKURelated(sKUModelo, loginModelo);
            }

            if (rbIdLojista.Checked == true)
            {
                sKUModelo.store_qualifier_id = this.txIdSKU.Text;

                this.gridSeller.DataSource = produtosBLL.ConsultarSKURelated(sKUModelo, loginModelo);
            }

            if (rbReferenceId.Checked == true)
            {
                sKUModelo.reference_id = this.txIdSKU.Text;

                this.gridSeller.DataSource = produtosBLL.ConsultarSKURelated(sKUModelo, loginModelo);
            }

            if (rbProductId.Checked == true)
            {
                sKUModelo.product_id = Convert.ToInt32(this.txIdSKU.Text);
                this.gridSeller.DataSource = produtosBLL.ConsultarSKURelated(sKUModelo, loginModelo);
            }

            this.txQtdeLinhas.Text = this.gridSeller.RowCount.ToString();

            this.ContarSKUNaoAtivo();
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            produtosBLL = new ProdutosBLL();
            sKUModelo = new SKUModelo();

            sKUModelo.reference_id = this.txIdSKU.Text;
            sKUModelo.store_qualifier_id = this.gridSeller[4, this.gridSeller.CurrentRow.Index].Value.ToString();

            produtosBLL = new ProdutosBLL();
            produtosBLL.AtivarFlagLock(loginModelo, sKUModelo);

        }

        public void ContarSKUNaoAtivo()
        {
            int contadorInativo = 0;
            int contadorAtivo = 0;

            foreach (DataGridViewRow row in gridSeller.Rows)
            {
                string active = String.Empty;

                active = row.Cells[4].FormattedValue.ToString();

                if (active == "Y")
                {
                    contadorAtivo++;
                }
                else
                {
                    contadorInativo++;
                }                
                
            }

            this.txInativo.Text = contadorInativo.ToString();
            this.txAtivo.Text = contadorAtivo.ToString();
        }
    }
}
