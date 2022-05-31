using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;

namespace SIC.DAO
{
    public class UsuarioExternoDAO
    {
        //Datatable
        DataTable dtusuario;

        List<UsuarioExternoModelo> listUsuarioModelo = new List<UsuarioExternoModelo>();

        public UsuarioExternoModelo PesquisarUsuarioExterno(UsuarioExternoModelo usuarioExternoModelo)
        {
            dtusuario = new DataTable();

            try
            {
                //string con =                    "mongodb://usr_dev:asdf%40ghjk@10.128.46.109:27017,10.128.46.110:27017,10.128.46.111:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=dinheiro+-+leitura+-+imported+on+30+de+nov+de+2021+%281%29&3t.defaultColor=0,120,215&3t.databases=admin,mp-dinheiro&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true";
                var dbClient = new MongoClient("mongodb://usr_dev:asdf%40ghjk@10.106.28.32:27017,10.106.28.33:27017,10.106.28.34:27017/admin?readPreference=nearest&connectTimeoutMS=10000&authSource=admin&authMechanism=SCRAM-SHA-1&3t.uriVersion=3&3t.connection.name=MP-Plataforma&3t.defaultColor=0,120,215&3t.databases=admin,mp-alf&3t.alwaysShowAuthDB=true&3t.alwaysShowDBFromUserRole=true");
                IMongoDatabase db = dbClient.GetDatabase("mp-alf");

                // *************************** MP- Plataforma ***************************
                var mpAlfCollection = db.GetCollection<BsonDocument>("usuariosExternos");
                var filterUsuarioExterno = Builders<BsonDocument>.Filter.Eq("email", usuarioExternoModelo.email);
                var resultUsuarioExterno = mpAlfCollection.Find(filterUsuarioExterno).ToList();

                if(resultUsuarioExterno.Count > 0)
                {
                    foreach(var itemUsuario in resultUsuarioExterno.ToArray())
                    {
                        //UsuarioExternoModelo usuarioExternoModelo = new UsuarioExternoModelo();
                        usuarioExternoModelo.usuario = itemUsuario["usuario"].AsBsonValue.ToString();
                        usuarioExternoModelo.cpf = itemUsuario["cpf"].AsBsonValue.ToString();
                        usuarioExternoModelo.nome = itemUsuario["nome"].AsBsonValue.ToString();
                        usuarioExternoModelo.sobrenome = itemUsuario["sobrenome"].AsBsonValue.ToString();
                        //usuarioExternoModelo.inativo = Convert.ToBoolean(itemUsuario.GetElement("inativo").ToString());
                        //usuarioExternoModelo.dataAtualizacao = Convert.ToDateTime(itemUsuario.GetElement("dataAtualizacao"));
                        usuarioExternoModelo.modificadoPor = itemUsuario["modificadoPor"].AsBsonValue.ToString();

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioExternoModelo;
        }
    }
}
