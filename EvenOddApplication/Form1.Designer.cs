
namespace EvenOddApplication
{
    partial class Form1
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.UserInputTB = new System.Windows.Forms.TextBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ResultLabel.Location = new System.Drawing.Point(12, 58);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(185, 65);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Результат";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInputTB
            // 
            this.UserInputTB.Location = new System.Drawing.Point(15, 174);
            this.UserInputTB.Name = "UserInputTB";
            this.UserInputTB.Size = new System.Drawing.Size(182, 20);
            this.UserInputTB.TabIndex = 1;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.CheckBtn.Location = new System.Drawing.Point(2, 287);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(205, 161);
            this.CheckBtn.TabIndex = 2;
            this.CheckBtn.Text = "Проверка";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 450);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.UserInputTB);
            this.Controls.Add(this.ResultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox UserInputTB;
        private System.Windows.Forms.Button CheckBtn;
    }
}

