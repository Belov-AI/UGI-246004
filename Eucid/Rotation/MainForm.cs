using Eucid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            var a = new Eucid.Point(double.Parse(aXTextBox.Text), 
                double.Parse(aYTextBox.Text));

            var b = new Eucid.Point(double.Parse(bXTextBox.Text),
                double.Parse(bYTextBox.Text));

            var c = new Eucid.Point(double.Parse(cXTextBox.Text),
                double.Parse(cYTextBox.Text));

            var t = new Triangle(a, b, c);
            
            var center = new Eucid.Point(double.Parse(centerXTextBox.Text),
                double.Parse(centerYTextBox.Text));

            var angle = double.Parse(angleTextBox.Text);

            var rt = t.Clone() as Triangle;
            rt.Rotate(center, angle);

            var picture = new PictureForm(center, t, rt, 100);

            picture.Show();

        }
    }
}
