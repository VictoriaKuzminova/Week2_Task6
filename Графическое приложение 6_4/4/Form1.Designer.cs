
namespace _4
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
            this.res_textBox = new System.Windows.Forms.RichTextBox();
            this.res_button = new System.Windows.Forms.Button();
            this.mas_textBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finish_textBox = new System.Windows.Forms.TextBox();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // res_textBox
            // 
            this.res_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textBox.Location = new System.Drawing.Point(412, 299);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.Size = new System.Drawing.Size(373, 96);
            this.res_textBox.TabIndex = 36;
            this.res_textBox.Text = "";
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_button.Location = new System.Drawing.Point(533, 205);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(161, 40);
            this.res_button.TabIndex = 35;
            this.res_button.Text = "Вычеслить";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // mas_textBox
            // 
            this.mas_textBox.Location = new System.Drawing.Point(412, 83);
            this.mas_textBox.Name = "mas_textBox";
            this.mas_textBox.Size = new System.Drawing.Size(373, 103);
            this.mas_textBox.TabIndex = 34;
            this.mas_textBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(366, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Массив: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Конец: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Начало:";
            // 
            // finish_textBox
            // 
            this.finish_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finish_textBox.Location = new System.Drawing.Point(167, 348);
            this.finish_textBox.Name = "finish_textBox";
            this.finish_textBox.Size = new System.Drawing.Size(147, 30);
            this.finish_textBox.TabIndex = 30;
            // 
            // start_textBox
            // 
            this.start_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_textBox.Location = new System.Drawing.Point(167, 283);
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(147, 30);
            this.start_textBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(72, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 75);
            this.label5.TabIndex = 28;
            this.label5.Text = "Введите значения\r\n для рандомного \r\nзаполнения массива:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "n = ";
            // 
            // n_textBox
            // 
            this.n_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_textBox.Location = new System.Drawing.Point(179, 109);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(147, 30);
            this.n_textBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите разрядность массива: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.res_button);
            this.Controls.Add(this.mas_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.finish_textBox);
            this.Controls.Add(this.start_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Сумма отрицательных значений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox res_textBox;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.RichTextBox mas_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox finish_textBox;
        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.Label label2;
    }
}

