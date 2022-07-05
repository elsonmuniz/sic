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
    public partial class DialogViewer : Form
    {
        public DialogViewer()
        {
            InitializeComponent();
        }

        //Para conseguir movimentar a tela clicando e arrastando
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public virtual void FecharJanela()
        {
            this.Close();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }

        public virtual void NomeDaJanela(string sNomeJanela)
        {
            this.lbNomeJanela.Text = sNomeJanela;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.FecharJanela();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
