using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using SIC.Modelo;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace SIC.DAO
{
    public class Conexao
    {
        
        public static SqlConnection ConectarSL()
        {
            SqlConnection conexao;

            String conn = "Data Source=10.128.65.164\\db_prd_ExtracaoParceiro,2101; User Id=usr_extracaoparceiro; Password=u$r3xTr@c@0PaRc3!r0";

            conexao = new SqlConnection(conn);

            return conexao;
        }

        public static string ConexaoMongoDBMPDinheiro
            {
            get
            {
                //var conf = ConfigurationManager.ConnectionStrings..Get("MPDinheiro");

                Configuration cf;

                cf = ConfigurationManager.ConnectionStrings["MPDinheiro"].CurrentConfiguration;
                //var appSettings = ConfigurationManager.ConnectionStrings.["MPDinheiro"].ConnectionString;

                return ConfigurationManager.AppSettings["MPDinheiro"];
            }
            }

    public static OracleConnection ConectarAD(LoginModelo loginModelo)
        {
            try
            {
                OracleConnection conexao;

                String conn = "Data Source = 10.128.122.32:1521/ADPRD; User ID=" + loginModelo.Usuario + "; Password=" + loginModelo.Senha + " ";
                
                conexao = new OracleConnection(conn);

                conexao.Open();

                //SqlConnection conexaoSQLServer = ConectarSL();
                //conexaoSQLServer.Open();

                //SqlDataAdapter dr = new SqlDataAdapter();
                //dr.SelectCommand = new SqlCommand();
                //dr.SelectCommand.Connection = conexaoSQLServer;
                //dr.SelectCommand.CommandText = "SELECT * FROM #SICLogin";
                //DataTable dt = new DataTable();
                //dr.Fill(dt);


                //SqlCommand cmdLogin = new SqlCommand();
                //cmdLogin.Connection = conexaoSQLServer;
                //cmdLogin.CommandText = "INSERT INTO #SICLogin(Usuario, DataInicio, DataFim ) values('" + loginModelo.Usuario + "', '" + DateTime.Now + "', '" + DateTime.Now + "')";
                //cmdLogin.ExecuteNonQuery();


                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    loginModelo.Logado = true;

                    //return true;
                }
                else
                {
                    loginModelo.Logado = false;

                }

                return conexao;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                //MessageBox.Show("Erro" + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
