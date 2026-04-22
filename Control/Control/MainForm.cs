using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void titleLabel_MouseHover(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.Red;
        }

        private void titleLabel_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = SystemColors.ControlText;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            titleLabel.Text = titleTextBox.Text;
            titleTextBox.Text = string.Empty;
            titleTextBox.Focus();
        }

        private void ChangeFontSyle(object sender, EventArgs e)
        {
            var fontStyle = FontStyle.Regular;
            
            if (boldCheckBox.Checked)
                fontStyle |= FontStyle.Bold;

            if (italicCheckBox.Checked)
                fontStyle |= FontStyle.Italic;

            if (uderlineCheckBox.Checked)
                fontStyle |= FontStyle.Underline;

            titleLabel.Font = new Font(titleLabel.Font, fontStyle);
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            var size = int.Parse(radioButton.Text.Split()[0]);

            titleLabel.Font = new Font(
                titleLabel.Font.FontFamily, 
                size, 
                titleLabel.Font.Style);
        }
    }
}
