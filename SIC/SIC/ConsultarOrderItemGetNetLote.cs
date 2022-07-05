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
    public partial class ConsultarOrderItemGetNetLote : Forms.DialogViewer
    {

        FrmApp frmApp;
        ConsultarOrderItemGetnet consultarOrderItemGetnet;
        public ConsultarOrderItemGetNetLote(FrmApp frmApp, ConsultarOrderItemGetnet consultarOrderItemGetnet)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.consultarOrderItemGetnet = consultarOrderItemGetnet;
        }

        private void ConsultarOrderItemGetNetLote_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importar liberação de item em lote");
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            List<OrderBandeiraModelo> listOrderBandeira = new List<OrderBandeiraModelo>();

            string[] dados = richTextBox1.Text.Split('\n');

            foreach (string id in dados)
            {
                if (id.ToString().Length != 0)
                {
                    listOrderBandeira.Add(new OrderBandeiraModelo(Convert.ToInt64(id), null, 0));
                }
            }

            consultarOrderItemGetnet.ConsultarPedidoBandeira(listOrderBandeira);

            this.Close();
        }

        public override void FecharJanela()
        {
            base.FecharJanela();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }
    }
}
