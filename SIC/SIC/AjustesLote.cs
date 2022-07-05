using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIC
{
    public partial class AjustesLote : Forms.DialogViewer
    {
        //Variável local
        FrmApp frmApp;
        Ajustes ajustes;

        //List
        //List
        List<Int64> listOrder = new List<Int64>();

        public AjustesLote(FrmApp frmApp, Ajustes ajustes)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.ajustes = ajustes;
        }

        private void AjustesLote_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importar ajustes em lote");
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            this.ImportarOrder();
        }

        public void ImportarOrder()
        {
            this.listOrder.Clear();

            string order = rtbImportarLoteAjuste.Text;
            string[] listorder = order.Split('\n');

            foreach(var orderId in listorder)
            {
                if(orderId.Length != 0)
                {
                    listOrder.Add(Convert.ToInt64(orderId));
                }
                
            }

            ajustes.PesquisarAjuste(listOrder);

            this.Dispose();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            FecharJanela();
        }

        public override void FecharJanela()
        {
            base.FecharJanela();
        }
    }
}
