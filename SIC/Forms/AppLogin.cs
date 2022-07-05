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
    public partial class AppLogin : Form
    {
        public AppLogin()
        {
            InitializeComponent();
        }

        //Para conseguir movimentar a tela clicando e arrastando
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public virtual void Fechar()
        {

        }

        public virtual void Maximizar()
        {

        }

        public virtual void Minimizar()
        {

        }

        public virtual void VersaoSistema(string sVersaoSistema)
        {
            this.lbVersao.Text += sVersaoSistema;
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.Minimizar();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            this.Maximizar();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Fechar();
            Application.Exit();
        }


    }
}
