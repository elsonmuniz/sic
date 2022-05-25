using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIC.BLL;
using SIC.Modelo;
using System.Net.Http;
using System.Net.Mail;

namespace SIC
{
    public partial class ConsultarLojaGetNet : Forms.FormEdit
    {
        //DataTable
        DataTable dtLojistaAdquirente;

        //BLL
        LojistaAdquirenteBLL lojistaAdquirenteBLL;

        //Modelo
        LojistaAdquirenteModelo lojistaAdquirenteModelo;
        ConsultarLojaGetnetModelo consultarLojaGetnetModelo;

        //Frm
        FrmApp frmApp;

        //List
        List<String> listCNPJ = new List<string>();
        List<LojistaAdquirenteModelo> lojistaAdquirenteModeloList;

        public ConsultarLojaGetNet(FrmApp frmApp)
        {
            InitializeComponent();
            this.frmApp = frmApp;
            this.MdiParent = frmApp;

            this.rbCNPJ.Checked = true;

        }

        public void ListarGrid()
        {
            dtLojistaAdquirente = new DataTable();

            DataColumn dcNro = new DataColumn("Nro", typeof(string));
            DataColumn dcIdLogista = new DataColumn("Id Lojista", typeof(int));
            DataColumn dcNomeFantasia = new DataColumn("Nome Fantasia", typeof(string));
            DataColumn dcCNPJ = new DataColumn("CNPJ", typeof(string));
            
            DataColumn dcSsiteExtra = new DataColumn("Site Extra", typeof(string));
            DataColumn dcStatusCarteiraExtra = new DataColumn("Status Extra", typeof(string));

            DataColumn dcSsiteCB = new DataColumn("Site C.Bahia", typeof(string));
            DataColumn dcStatusCarteiraCB = new DataColumn("Status C. Bahia", typeof(string));

            DataColumn dcSsitePontoFrio = new DataColumn("Site P. Frio", typeof(string));
            DataColumn dcStatusCarteiraPonto = new DataColumn("Status P. Frio", typeof(string));

            DataColumn dcStatusCarteiraGetNetExtra = new DataColumn("Status Getnet Extra", typeof(string));
            DataColumn dcStatusCarteiraGetNetCB = new DataColumn("Status Getnet C. Bahia", typeof(string));
            DataColumn dcStatusCarteiraGetNetPonto = new DataColumn("Status Getnet P. Frio", typeof(string));

            //DataColumn dcStatus = new DataColumn("Carteira P. Frio", typeof(string));
            DataColumn dcCarteiraDataModificacao = new DataColumn("Data Modificação", typeof(string));
            
            dtLojistaAdquirente.Columns.AddRange(new DataColumn[] {dcNro,dcIdLogista, dcNomeFantasia, dcCNPJ, dcSsiteExtra
                                                    , dcStatusCarteiraExtra, dcSsiteCB, dcStatusCarteiraCB,dcSsitePontoFrio,dcStatusCarteiraPonto
                                                    , dcStatusCarteiraGetNetExtra, dcStatusCarteiraGetNetCB, dcStatusCarteiraGetNetPonto, dcCarteiraDataModificacao}
                                                    );

            this.gridLojistaAdquirente.DataSource = dtLojistaAdquirente;

            this.gridLojistaAdquirente.Columns[0].Width = 60;
            this.gridLojistaAdquirente.Columns[1].Width = 60;
            this.gridLojistaAdquirente.Columns[2].Width = 100;
            this.gridLojistaAdquirente.Columns[3].Width = 100;
            this.gridLojistaAdquirente.Columns[4].Width = 40;
            this.gridLojistaAdquirente.Columns[5].Width = 80;
            this.gridLojistaAdquirente.Columns[6].Width = 40;
            this.gridLojistaAdquirente.Columns[7].Width = 80;
            this.gridLojistaAdquirente.Columns[8].Width = 40;
            this.gridLojistaAdquirente.Columns[9].Width = 80;
            this.gridLojistaAdquirente.Columns[10].Width = 60;
            this.gridLojistaAdquirente.Columns[11].Width = 60;
            this.gridLojistaAdquirente.Columns[12].Width = 60;
            this.gridLojistaAdquirente.Columns[13].Width = 115;

        }

        private void ConsultarLojaGetNet_Load(object sender, EventArgs e)
        {
            this.ListarGrid();
        }

        private void btPesquisarLojista_Click(object sender, EventArgs e)
        {
            this.PesquisarLojista(listCNPJ);
        }

        public void PesquisarLojista(List<String> listCNPJ)
        {
            //Já entra limpando a listagem
            this.dtLojistaAdquirente.Clear();

            lojistaAdquirenteModelo = new LojistaAdquirenteModelo();
            lojistaAdquirenteBLL = new LojistaAdquirenteBLL();
            consultarLojaGetnetModelo = new ConsultarLojaGetnetModelo();
            lojistaAdquirenteModeloList = new List<LojistaAdquirenteModelo>();

            try
            {
                //listCNPJ = new List<string>();

                if(this.txIdLojista.Text.Length != 0)
                {
                    listCNPJ.Add(this.txIdLojista.Text);
                }
                

                //listCNPJ.Add("34197974000129");
                //listCNPJ.Add("42401930000105");
                //listCNPJ.Add("44879216000144");
                //listCNPJ.Add("39948196000186");
                //listCNPJ.Add("10428528000110");
                //listCNPJ.Add("34404048000187");
                //listCNPJ.Add("44980207000145");
                //listCNPJ.Add("43974590000166");
                //listCNPJ.Add("28669807000130");
                //listCNPJ.Add("45838862000126");
                //listCNPJ.Add("45486904000107");
                //listCNPJ.Add("21642808000142");


                lojistaAdquirenteModeloList = lojistaAdquirenteBLL.PesquisarAsync(listCNPJ);

                for(int i = 0; i < lojistaAdquirenteModeloList.Count; i++)
                {
                    DataRow drLojista;// = new DataRow();
                    drLojista = dtLojistaAdquirente.NewRow();
                    
                    if (lojistaAdquirenteModeloList[i] != null)
                    {
                        drLojista[0] = i+1;
                        drLojista[1] = lojistaAdquirenteModeloList[i]._id;
                        drLojista[2] = lojistaAdquirenteModeloList[i].nomeFantasia;
                        drLojista[3] = lojistaAdquirenteModeloList[i].numeroDocumento;
                        drLojista[4] = lojistaAdquirenteModeloList[i].carteiras[0].site.ToString();
                        drLojista[5] = lojistaAdquirenteModeloList[i].carteiras[0].status.ToString();
                        drLojista[6] = lojistaAdquirenteModeloList[i].carteiras[1].site.ToString();
                        drLojista[7] = lojistaAdquirenteModeloList[i].carteiras[1].status.ToString();
                        drLojista[8] = lojistaAdquirenteModeloList[i].carteiras[2].site.ToString();
                        drLojista[9] = lojistaAdquirenteModeloList[i].carteiras[2].status.ToString();

                        drLojista[10] =  lojistaAdquirenteModeloList[i].carteiras[0].statusGetnet.ToString();
                        drLojista[11] = lojistaAdquirenteModeloList[i].carteiras[1].statusGetnet.ToString();
                        drLojista[12] = lojistaAdquirenteModeloList[i].carteiras[2].statusGetnet.ToString();
                        drLojista[13] = lojistaAdquirenteModeloList[i].dataModificacao;

                        dtLojistaAdquirente.Rows.Add(drLojista);
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro nas TAGs do cadastro do lojista" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txIdLojista_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(this.txIdLojista.Text.Length !=0)
                {
                    this.PesquisarLojista(listCNPJ);
                }
                else
                {
                    MessageBox.Show("Informe o id do lojista","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ativarLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SincronizarCadastroLojaGetnet(this.gridLojistaAdquirente[1, gridLojistaAdquirente.CurrentRow.Index].Value.ToString());
        }
        
        public async void SincronizarCadastroLojaGetnet(string idLojista)
        {
            try
            {
                this.listCNPJ.Clear();

                foreach (DataRow dr in dtLojistaAdquirente.Rows)
                //for(int i = 0; i < this.gridLojistaAdquirente.Rows.Count; i++)
                {
                    string url = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador";
                    string urlSemFila = "http://mp-adquirente.mktplace-prd.viavarejo.com.br:80/callback/getnet/sincronizador/semfila";

                    HttpClient client = new HttpClient();
                    StringContent content = new StringContent($"[" + dr[1].ToString() + "]");
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var result = await client.PostAsync(url, content);

                    //Sem Fila
                    HttpClient clientSemFila = new HttpClient();
                    StringContent contentSemFila = new StringContent($"[" + dr[1].ToString() + "]");
                    contentSemFila.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var resultSemFila = await clientSemFila.PostAsync(urlSemFila, contentSemFila);

                   this.listCNPJ.Add(dr[3].ToString());
                    
                }

                MessageBox.Show("Consulta de cadastro efetuada na Getnet com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.PesquisarLojista(this.listCNPJ);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na consulta com a Getnet." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void EnviarEmailGetnet()
        {
            //Cria Mensagem
            MailMessage mail = new MailMessage();

            //define os endereços
            //mail.From = new MailAddress("agostinho.neto-ext@viavarejo.com.br"); //, "")
            mail.From = new MailAddress("elson.junior-ext@viavarejo.com.br"); //, "")
            //mail.To.Add("luana.oliveira-ext@viaverejo.com.br");
            mail.To.Add("agostinho.neto-ext@viavarejo.com.br");

            //define o conteúdo
            mail.Subject = "Teste no corpo do email";
            mail.Body = "Este é o corpo do email";

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.viavarejo.com.br");
            smtp.Send(mail);
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EnviarEmailGetnet();
        }

        private void btImportarCNPJLote_Click(object sender, EventArgs e)
        {
            ConsultarLojaGetNetLote consultarLojaGetNetLote = new ConsultarLojaGetNetLote(frmApp, this);
            consultarLojaGetNetLote.Show();
        }
    }
}
