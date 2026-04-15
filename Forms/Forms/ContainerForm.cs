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
    public partial class ContainerForm : Form
    {
        int documentNumber = 0;
        public ContainerForm()
        {
            InitializeComponent();
        }

        private void открытьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = new DocumentForm();
            document.Text = "Документ " + ++documentNumber;
            document.MdiParent = this;
            document.Show();
        }
    }
}
