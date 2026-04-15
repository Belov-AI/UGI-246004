namespace Forms
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.answerButton = new System.Windows.Forms.Button();
            this.ownedFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerButton.Location = new System.Drawing.Point(97, 44);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(153, 54);
            this.answerButton.TabIndex = 0;
            this.answerButton.Text = "Вопрос";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // ownedFormButton
            // 
            this.ownedFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownedFormButton.Location = new System.Drawing.Point(97, 141);
            this.ownedFormButton.Name = "ownedFormButton";
            this.ownedFormButton.Size = new System.Drawing.Size(153, 92);
            this.ownedFormButton.TabIndex = 0;
            this.ownedFormButton.Text = "Открыть подчинеённую форму";
            this.ownedFormButton.UseVisualStyleBackColor = true;
            this.ownedFormButton.Click += new System.EventHandler(this.ownedFormButton_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 288);
            this.Controls.Add(this.ownedFormButton);
            this.Controls.Add(this.answerButton);
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительная формая";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button ownedFormButton;
    }
}