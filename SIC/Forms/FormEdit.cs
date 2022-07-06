using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        //Para conseguir movimentar a tela clicando e arrastando
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public virtual void Salvar()
        {

        }

        public virtual void NomeDaJanela(string sNomeJanela)
        {
            this.lbNomeJanela.Text = sNomeJanela;
        }

        public virtual void FecharJanela()
        {
            this.Close();
        }

        public virtual void MinimizarJanela()
        {
            WindowState = FormWindowState.Minimized;
        }

        public virtual void MaximizarJanela()
        {
            WindowState = FormWindowState.Maximized;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.MinimizarJanela();
        }

        private void lbNomeJanela_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }

        private void btMaximiar_Click(object sender, EventArgs e)
        {
            //this.MaximizarJanela();
        }
    }
}
