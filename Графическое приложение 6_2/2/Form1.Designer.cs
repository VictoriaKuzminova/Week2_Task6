
namespace _2
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
            this.label2 = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mas_textBox = new System.Windows.Forms.RichTextBox();
            this.res_textBox = new System.Windows.Forms.RichTextBox();
            this.res_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите разрядность массива: ";
            // 
            // n_textBox
            // 
            this.n_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_textBox.Location = new System.Drawing.Point(357, 28);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(147, 30);
            this.n_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Массив: ";
            // 
            // mas_textBox
            // 
            this.mas_textBox.Location = new System.Drawing.Point(131, 86);
            this.mas_textBox.Name = "mas_textBox";
            this.mas_textBox.Size = new System.Drawing.Size(373, 103);
            this.mas_textBox.TabIndex = 7;
            this.mas_textBox.Text = "";
            // 
            // res_textBox
            // 
            this.res_textBox.Location = new System.Drawing.Point(24, 282);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.Size = new System.Drawing.Size(505, 136);
            this.res_textBox.TabIndex = 13;
            this.res_textBox.Text = "";
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_button.Location = new System.Drawing.Point(192, 207);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(161, 40);
            this.res_button.TabIndex = 12;
            this.res_button.Text = "Вычислить";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.mas_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Поиск минимального";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mas_textBox;
        private System.Windows.Forms.RichTextBox res_textBox;
        private System.Windows.Forms.Button res_button;
    }
}

