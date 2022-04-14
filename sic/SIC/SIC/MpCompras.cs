using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.DAO;
using SIC.Modelo;
using Superpower;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB;
using System.Runtime.Serialization.Json;
using System.IO;
using SIC.BLL;

namespace SIC
{
    public partial class MpCompras : Forms.FormEdit
    {
        FrmApp frmApp;

        //MODELO
        LoginModelo LoginModelo;
        public MpCompras(FrmApp frmApp, LoginModelo LoginModelo)
        {
            InitializeComponent();

            this.frmApp = frmApp;
            this.MdiParent = frmApp;
            this.LoginModelo = LoginModelo;
        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            MPComprasDAO mPComprasDAO = new MPComprasDAO();
            MPComprasModelo mPComprasModelo = new MPComprasModelo();

            mPComprasModelo = mPComprasDAO.PesquisarAsync(Convert.ToInt64(this.txIdLojista.Text));

            lstbDados.Items.Add(mPComprasModelo.Id);


            ////23699889001

        }

        private void MpCompras_Load(object sender, EventArgs e)
        {

























        }
    }
}
