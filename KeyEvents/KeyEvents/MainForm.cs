using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace KeyEvents
{
    public partial class MainForm : Form
    {
        Queue<string> lines;
        int buffer;

        public MainForm()
        {
            InitializeComponent();

            lines = new Queue<string>();
            buffer = 25;
            
        }

        void UpdateReport(string message)
        {
            lines.Enqueue(message);

            if(lines.Count > buffer )
                lines.Dequeue();

            var text = string.Empty;
            
            foreach( var line in lines )
                text += line + "\n";

            reportLabel.Text = text;
        }

        private void MainForm_PreviewKeyDown(
            object sender, PreviewKeyDownEventArgs e) =>
            UpdateReport("PreviwKeyDown: " + e.KeyCode);

        private void MainForm_KeyDown(object sender, KeyEventArgs e) =>
            UpdateReport("KeyDown: " + e.KeyCode);

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e) =>
            UpdateReport($"KeyPress: {e.KeyChar} {(int)e.KeyChar}");

        private void MainForm_KeyUp(object sender, KeyEventArgs e) =>
            UpdateReport("KeyUp: " + e.KeyCode);
    }
}
