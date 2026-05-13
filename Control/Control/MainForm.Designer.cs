namespace Control
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.uderlineCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.titleListBox = new System.Windows.Forms.ListBox();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.slideshowProgressBar = new System.Windows.Forms.ProgressBar();
            this.slideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.slideshowButton = new System.Windows.Forms.Button();
            this.openPictureButton = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTextButton = new System.Windows.Forms.Button();
            this.openTextDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(25, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(374, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "текст";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseLeave += new System.EventHandler(this.titleLabel_MouseLeave);
            this.titleLabel.MouseHover += new System.EventHandler(this.titleLabel_MouseHover);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(30, 88);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(369, 26);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titleTextBox_KeyDown);
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(30, 137);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 38);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Ввод";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(439, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 649);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldCheckBox.Location = new System.Drawing.Point(30, 199);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(133, 24);
            this.boldCheckBox.TabIndex = 4;
            this.boldCheckBox.Text = "полужирный";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontSyle);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicCheckBox.Location = new System.Drawing.Point(30, 229);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(87, 24);
            this.italicCheckBox.TabIndex = 5;
            this.italicCheckBox.Text = "курсив";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontSyle);
            // 
            // uderlineCheckBox
            // 
            this.uderlineCheckBox.AutoSize = true;
            this.uderlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uderlineCheckBox.Location = new System.Drawing.Point(30, 259);
            this.uderlineCheckBox.Name = "uderlineCheckBox";
            this.uderlineCheckBox.Size = new System.Drawing.Size(152, 24);
            this.uderlineCheckBox.TabIndex = 6;
            this.uderlineCheckBox.Text = "подчеркнутый";
            this.uderlineCheckBox.UseVisualStyleBackColor = true;
            this.uderlineCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontSyle);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(234, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "8 пт";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(234, 229);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "12 пт";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(234, 259);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "16 пт";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // titleListBox
            // 
            this.titleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleListBox.FormattingEnabled = true;
            this.titleListBox.ItemHeight = 20;
            this.titleListBox.Location = new System.Drawing.Point(30, 306);
            this.titleListBox.Name = "titleListBox";
            this.titleListBox.Size = new System.Drawing.Size(369, 124);
            this.titleListBox.TabIndex = 8;
            this.titleListBox.SelectedIndexChanged += new System.EventHandler(this.titleListBox_SelectedIndexChanged);
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontFamilyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(144, 143);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(255, 28);
            this.fontFamilyComboBox.Sorted = true;
            this.fontFamilyComboBox.TabIndex = 3;
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangePicture);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(353, 693);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangePicture);
            // 
            // slideshowProgressBar
            // 
            this.slideshowProgressBar.Location = new System.Drawing.Point(30, 762);
            this.slideshowProgressBar.Maximum = 300;
            this.slideshowProgressBar.Name = "slideshowProgressBar";
            this.slideshowProgressBar.Size = new System.Drawing.Size(375, 46);
            this.slideshowProgressBar.Step = 1;
            this.slideshowProgressBar.TabIndex = 10;
            // 
            // slideshowTimer
            // 
            this.slideshowTimer.Interval = 40;
            this.slideshowTimer.Tick += new System.EventHandler(this.slideshowTimer_Tick);
            // 
            // slideshowButton
            // 
            this.slideshowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slideshowButton.Location = new System.Drawing.Point(180, 695);
            this.slideshowButton.Name = "slideshowButton";
            this.slideshowButton.Size = new System.Drawing.Size(75, 46);
            this.slideshowButton.TabIndex = 11;
            this.slideshowButton.Text = "Старт";
            this.slideshowButton.UseVisualStyleBackColor = true;
            this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
            // 
            // openPictureButton
            // 
            this.openPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openPictureButton.Location = new System.Drawing.Point(439, 762);
            this.openPictureButton.Name = "openPictureButton";
            this.openPictureButton.Size = new System.Drawing.Size(227, 46);
            this.openPictureButton.TabIndex = 12;
            this.openPictureButton.Text = "Открыть изображение ";
            this.openPictureButton.UseVisualStyleBackColor = true;
            this.openPictureButton.Click += new System.EventHandler(this.openPictureButton_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // openTextButton
            // 
            this.openTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openTextButton.Location = new System.Drawing.Point(439, 695);
            this.openTextButton.Name = "openTextButton";
            this.openTextButton.Size = new System.Drawing.Size(227, 44);
            this.openTextButton.TabIndex = 13;
            this.openTextButton.Text = "Открыть текст";
            this.openTextButton.UseVisualStyleBackColor = true;
            this.openTextButton.Click += new System.EventHandler(this.openTextButton_Click);
            // 
            // openTextDialog
            // 
            this.openTextDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 834);
            this.Controls.Add(this.openTextButton);
            this.Controls.Add(this.openPictureButton);
            this.Controls.Add(this.slideshowButton);
            this.Controls.Add(this.slideshowProgressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fontFamilyComboBox);
            this.Controls.Add(this.titleListBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.uderlineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "Элементы управления";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox uderlineCheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox titleListBox;
        private System.Windows.Forms.ComboBox fontFamilyComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar slideshowProgressBar;
        private System.Windows.Forms.Timer slideshowTimer;
        private System.Windows.Forms.Button slideshowButton;
        private System.Windows.Forms.Button openPictureButton;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button openTextButton;
        private System.Windows.Forms.OpenFileDialog openTextDialog;
    }
}

