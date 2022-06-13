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
            this.gridOrder.Columns[1].Width = 60;
            this.gridOrder.Columns[3].Width = 70;
            this.gridOrder.Columns[4].Width = 115;
            this.gridOrder.Columns[5].Width = 115;
            this.gridOrder.Columns[6].Width = 115;
            this.gridOrder.Columns[7].Width = 115;
            this.gridOrder.Columns[8].Width = 60;
            this.gridOrder.Columns[9].Width = 180;
            this.gridOrder.Columns[10].Width = 80;


        }

        private void btPesquisarOrderId_Click(object sender, EventArgs e)
        {
            //Limpa o liste depois da consulta
            this.listOrderId.Clear();

            this.PesquisarAjuste(listOrderId);
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {

        }

        public void PesquisarAjustes(List<Int64> listOrder)
        {
            ajusteBLL = new AjusteBLL();

            if(this.txOrderId.Text.Length != 0)
            {
                listOrder.Add(Convert.ToInt64(this.txOrderId.Text));
            }

            ajusteBLL.PesquisarAjustes(listOrder);

        }

        private void btImportarOrderLote_Click(object sender, EventArgs e)
        {
            AjustesLote ajustesLote = new AjustesLote(frmApp, this);
            ajustesLote.Show();
        }
    }
}
