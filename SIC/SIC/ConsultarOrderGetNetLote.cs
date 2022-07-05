using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.Modelo;

namespace SIC
{
    public partial class ConsultarOrderGetNetLote : Forms.DialogViewer
    {
        FrmApp frmApp;
        ConsultarOrderGetNet consultarOrderGetNet;
        public ConsultarOrderGetNetLote(FrmApp frmApp, ConsultarOrderGetNet consultarOrderGetNet)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.consultarOrderGetNet = consultarOrderGetNet;
        }

        private void ConsultarOrderGetNetLote_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importar pedidos em lote");
        }

        public override void FecharJanela()
        {
            base.FecharJanela();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            //List<Int64> listOrder = new List<Int64>();
            List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

            string[] dados = richTextBox1.Text.Split('\n');

            foreach (string id in dados)
            {
                if (id.ToString().Length != 0)
                {
                    listOrderBandeira.Add(new OrderBandeiraModelo(Convert.ToInt64(id),null,0));
                }
            }

            consultarOrderGetNet.ConsultarPedidoBandeira(listOrderBandeira);

            this.Close();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }
    }
}
