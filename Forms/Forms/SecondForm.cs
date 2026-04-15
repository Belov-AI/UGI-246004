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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            var answer = new DialogForm();
            var result = answer.ShowDialog();

            if (result == DialogResult.Yes)
                MessageBox.Show("Они такие милые");
            else if(result == DialogResult.No)
                MessageBox.Show("Подумай еще раз");
        }

        private void ownedFormButton_Click(object sender, EventArgs e)
        {
            var ownedForm = new ThirdForm();
            ownedForm.Owner = this;
            //AddOwnedForm(ownedForm);
            ownedForm.Show();
        }
    }
}
