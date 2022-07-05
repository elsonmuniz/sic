using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIC
{
    public partial class ConsultarLojaGetNetLote : Forms.DialogViewer
    {
        FrmApp frmApp;
        ConsultarLojaGetNet consultarLojaGetNet;

        //List
        List<String> listCNPJ = new List<string>();


        public ConsultarLojaGetNetLote(FrmApp frmApp, ConsultarLojaGetNet consultarLojaGetNet)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.consultarLojaGetNet = consultarLojaGetNet;
        }

        private void ConsultarLojaGetNetLote_Load(object sender, EventArgs e)
        {
            this.NomeDaJanela("Importar CNPJs em lote");
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            

            string  cnpj = richTextBox1.Text;
            string[] linhaCNPJ = cnpj.Split('\n');

            foreach (var itemCNPJ in linhaCNPJ)
            {
                if (itemCNPJ.Length == 14)
                {
                    listCNPJ.Add(itemCNPJ);
                }

                if (itemCNPJ.Length == 13)
                {
                    listCNPJ.Add("0"+itemCNPJ);
                }
                if (itemCNPJ.Length == 12)
                {
                    listCNPJ.Add("00" + itemCNPJ);
                }
            }

            this.consultarLojaGetNet.PesquisarLojista(listCNPJ);

            this.Dispose();
        }
    }
}
