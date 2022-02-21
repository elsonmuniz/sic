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

        JsonConversaoBLL jsonConversaoBLL;

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

            ////mPComprasModelo.Id = Convert.ToInt64(txIdLojista.Text);
            ///
            var consulta = mPComprasDAO.Pesquisar(Convert.ToInt64(this.txIdLojista.Text));

            lstbDados.Items.Add(consulta);

            //foreach (var contato in consulta)
            //{
            //    lstbDados.Items.Add(contato);
            //}


            //var consulta = mPComprasDAO.GetOrderId(Convert.ToInt64(txIdLojista.Text));

            //MongoDB.Driver.MongoClient client = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");

            ////23699889001

            //var database = client.GetDatabase("mp-compras");



            //MongoDB.Driver.IMongoCollection<MPComprasModelo> mongoCollection = database.GetCollection<MPComprasModelo>("compra");

            //var filter = new BsonDocument("codigo", codigo);
            //var result = conexaoDB.MongoCollection.Find(filter).ToList();


            //var query = from e in mongoCollection.AsQueryable<MPComprasModelo>()
            //            select e;

            //Int64 order = 23699889001;


            ////var orderLista = database.GetCollection<MPComprasModelo>("MPComprasModelo");
            //MongoDB.Driver.Linq.IMongoQueryable<MPComprasModelo> lmPComprasModelos = orderLista.AsQueryable<MPComprasModelo>();
            ////var query = from r in lmPComprasModelos.asquer
            ////            where r.Id == order
            ////            select r;

            //var filtro = Builders<MPComprasModelo>.Filter.Where(x => x.Id == order);



            //var mmPComprasModelo = JsonConvert.DeserializeObject<MPComprasModelo>(filtro.ToString());


            //public IEnumerable<MPComprasModelo> GetContatosPorOrder(string nome)
            //{
            //    MongoClient cliente = new MongoClient("mongodb://mp-compras-admin:mp-compras-admin%40@mp-compras-mongo-prd001.dc.nova:27017,mp-compras-mongo-prd002.dc.nova:27017,mp-compras-mongo-prd003.dc.nova:27017/mp-compras?readPreference=secondary&connectTimeoutMS=10000&authSource=mp-compras&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-COMPRAS+-+leitura&3t.ssh=true&3t.sshAddress=10.128.46.16&3t.sshPort=22&3t.sshAuthMode=password&3t.sshUser=leitura&3t.sshPassword=temp@123&3t.databases=mp-compras&3t.alwaysShowAuthDB=false&3t.alwaysShowDBFromUserRole=false");
            //    MongoServer server = cliente.GetServer();
            //    MongoDatabase database1 = server.GetDatabase("mp_compras");

            //    var contatosLista = database1.GetCollection<MPComprasModelo>("compra");

            //    var query = from e in contatosLista.AsQueryable<MPComprasModelo>()
            //                where e.Nome == nome
            //                select e;

            //    return query;
            //}


        }



    }
}
