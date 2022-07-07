using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIC
{
    public partial class ImportarTransacaoLote : Forms.DialogViewer
    {
        FrmApp frmApp;
        ConsultarPedidoFinanceiro consultarPedidoFinanceiro;
        public ImportarTransacaoLote(FrmApp frmApp, ConsultarPedidoFinanceiro consultarPedidoFinanceiro)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.consultarPedidoFinanceiro = consultarPedidoFinanceiro;
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            progressBarImportarPedido.Visible = true;
            this.lbImportandoPedido.Text = "Aguarde consulta dos pedidos...";
            progressBarImportarPedido.Minimum = 1;
            
            List<Int64> listOrder = new List<Int64>();

            string[] dados = richTextBox1.Text.Split('\n');
            
            progressBarImportarPedido.Maximum = 0;
            int cont = 0;

            foreach (string id in dados)
            {
                if (id.ToString().Length != 0)
                {
                    cont++;
                    progressBarImportarPedido.Maximum = cont;
                }
            }


            foreach (string id in dados)
            {
                if(id.ToString().Length != 0)
                {
                    listOrder.Add(Convert.ToInt64(id));
                    
                    progressBarImportarPedido.Increment(1);
                    progressBarImportarPedido.Refresh();
                }

                

            }

            await this.consultarPedidoFinanceiro.ConsultaPedidoFinanceiro(listOrder);

            this.Dispose();
        }

        public override void FecharJanela()
        {
            base.FecharJanela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }

        private void ImportarTransacaoLote_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importar pedidos em lote");
        }
    }
}
