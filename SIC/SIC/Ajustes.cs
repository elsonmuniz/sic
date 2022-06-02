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
    public partial class Ajustes : Forms.FormEdit
    {
        //Frm
        FrmApp frmApp;

        //List
        List<AjustesModelo> listAjuste = new List<AjustesModelo>();
        List<Int64> listOrderId = new List<long>();

        //Modelo

        //BLL
        AjusteBLL ajusteBLL;

        //DataTable
        DataTable dtOrder;

        public Ajustes(FrmApp frmApp)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;
        }

        public void PesquisarAjuste(List<Int64> listOrderId)
        {
            ajusteBLL = new AjusteBLL();
            dtOrder = new DataTable();

            dtOrder = ajusteBLL.PesquisarAjustes(listOrderId);

            this.gridOrder.DataSource = dtOrder;

            this.gridOrder.Columns[0].Width = 60;
            this.gridOrder.Columns[2].Width = 80;
            this.gridOrder.Columns[3].Width = 115;
            this.gridOrder.Columns[4].Width = 115;
            this.gridOrder.Columns[5].Width = 115;
            this.gridOrder.Columns[6].Width = 60;
            this.gridOrder.Columns[7].Width = 230;
            this.gridOrder.Columns[8].Width = 100;


        }

        private void btPesquisarOrderId_Click(object sender, EventArgs e)
        {
            this.listOrderId.Add(Convert.ToInt64(this.txOrderId.Text));

            this.PesquisarAjuste(listOrderId);

            //Limpa o liste depois da consulta
            this.listOrderId.Clear();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {

        }
    }
}
