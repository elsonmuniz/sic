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

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Int64> listOrder = new List<Int64>();

            string[] dados = richTextBox1.Text.Split('\n');

            foreach (string id in dados)
            {
                if(id.ToString().Length != 0)
                {
                    listOrder.Add(Convert.ToInt64(id));
                }
            }

            this.consultarPedidoFinanceiro.ConsultaPedidoFinanceiro(listOrder);

            this.Dispose();
        }
    }
}
