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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();

            //foreach(Control c in this.Controls)
            //{
            //    if(IsMdiContainer)
            //    {
            //        c.BackColor = SystemColors.Control; //Color.Black; 
            //    }
            //}
        }

        //Para conseguir movimentar a tela clicando e arrastando
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public virtual void Sair()
        {
            Application.Exit();
        }

        public virtual void Minimizar()
        {
            WindowState = FormWindowState.Minimized;
        }

        public virtual void SairAplicacao()
        {
            Application.Exit();
        }

        public virtual void Maximizar()
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.Minimizar();
        }

        private void btMaximiar_Click(object sender, EventArgs e)
        {
            this.Maximizar();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.SairAplicacao();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
