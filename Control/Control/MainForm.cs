using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Control
{
    public partial class MainForm : Form
    {
        int pictureNumber = 0;

        public MainForm()
        {
            InitializeComponent();

            titleListBox.Items.Add("Глава");
            titleListBox.Items.Add("Параграф");
            titleListBox.Items.Add("Раздел");

            fontFamilyComboBox.Items.Add("Microsoft San Serif");
            fontFamilyComboBox.Items.Add("Times New Roman");
            fontFamilyComboBox.Items.Add("Courier New");
            fontFamilyComboBox.Items.Add("Tahoma");
            //fontFamilyComboBox.SelectedIndex = 0;
            fontFamilyComboBox.SelectedItem = "Microsoft San Serif";

            openPictureDialog.Filter = 
                "JPEG|*.jpg|PNG|*.png|TIFF|*.tif|GIF|*.gif";

            openTextDialog.Filter = "Простой текст|*.txt|Форматированный текст|*.rtf";
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

        private void titleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            titleLabel.Text = listBox.SelectedItem.ToString();
        }

        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;

            titleLabel.Font = new Font(
                comboBox.SelectedItem.ToString(), 
                titleLabel.Font.Size, 
                titleLabel.Font.Style);
        }

        private void ChangePicture(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.Text == ">")
                pictureNumber++;
            else
                pictureNumber--;

            if (pictureNumber == 8)
                pictureNumber = 1;
            
            if (pictureNumber == 0)
                pictureNumber = 7;

            pictureBox1.Image = Properties.Resources.ResourceManager.GetObject(
                "pic" + pictureNumber) as Image;
        }

        private void slideshowTimer_Tick(object sender, EventArgs e)
        {
            slideshowProgressBar.PerformStep();

            if (slideshowProgressBar.Value % 50 == 0)
                ChangePicture(button2, new EventArgs());

            if (slideshowProgressBar.Value == slideshowProgressBar.Maximum)
            {
                slideshowButton.Text = "Старт";
                slideshowTimer.Stop();
                slideshowProgressBar.Value = 0;
                openPictureButton.Enabled = true;
            }
        }

        private void slideshowButton_Click(object sender, EventArgs e)
        {
            if (slideshowButton.Text == "Старт")
            {
                if (slideshowProgressBar.Value == 0)
                {
                    pictureNumber = 0;
                    ChangePicture(button2, new EventArgs());
                    openPictureButton.Enabled = false;
                }

                slideshowButton.Text = "Стоп";
                slideshowTimer.Start();
            }
            else
            {
                slideshowButton.Text = "Старт";
                slideshowTimer.Stop();
            }
        }

        private void openPictureButton_Click(object sender, EventArgs e)
        {
            var result = openPictureDialog.ShowDialog();

            if (result == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openPictureDialog.FileName);
        }

        private void titleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                enterButton_Click(sender, e);
        }

        private void openTextButton_Click(object sender, EventArgs e)
        {
            var result = openTextDialog.ShowDialog();

            if(result == DialogResult.OK)
                if(openTextDialog.FilterIndex == 1)
                    richTextBox1.Text = File.ReadAllText(openTextDialog.FileName,
                        Encoding.Default);
            else
                richTextBox1.LoadFile(openTextDialog.FileName);
        }
    }
}
