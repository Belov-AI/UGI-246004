namespace Forms
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
            this.openFormButton = new System.Windows.Forms.Button();
            this.containerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFormButton
            // 
            this.openFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFormButton.Location = new System.Drawing.Point(92, 63);
            this.openFormButton.Name = "openFormButton";
            this.openFormButton.Size = new System.Drawing.Size(219, 105);
            this.openFormButton.TabIndex = 0;
            this.openFormButton.Text = "Открыть дополнительную форму";
            this.openFormButton.UseVisualStyleBackColor = true;
            this.openFormButton.Click += new System.EventHandler(this.openFormButton_Click);
            // 
            // containerButton
            // 
            this.containerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.containerButton.Location = new System.Drawing.Point(101, 212);
            this.containerButton.Name = "containerButton";
            this.containerButton.Size = new System.Drawing.Size(210, 102);
            this.containerButton.TabIndex = 1;
            this.containerButton.Text = "Открыть контейнер";
            this.containerButton.UseVisualStyleBackColor = true;
            this.containerButton.Click += new System.EventHandler(this.containerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.containerButton);
            this.Controls.Add(this.openFormButton);
            this.Name = "MainForm";
            this.Text = "Главная формая";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFormButton;
        private System.Windows.Forms.Button containerButton;
    }
}

