using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public virtual void Salvar()
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }
    }
}
