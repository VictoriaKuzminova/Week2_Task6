using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
   
    public partial class Form1 : Form
    {
        int[] Input(int n,int s, int f)
        {
            int[] mas = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
               mas[i] = random.Next(s, f);
            }

            return mas;
        }
        void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; ++i)
            {
                mas_textBox.Text += mas[i] + "\t";
            }
        }
        static double Change(int[] mas)
        {
            double arifm = 0, count = 0, sum = 0;
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                if (mas[i] < 0)
                {
                    sum += mas[i];
                    count++;
                    arifm = sum / count;
                }
            }
            return arifm;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if (n_textBox.Text == ""|| start_textBox.Text==""||finish_textBox.Text=="")
            {
                MessageBox.Show("Введены не все данные!!!");
                return;
            }
            else
            {
                mas_textBox.Text = "";
                res_textBox.Text = "";
                int n, s,f;
                try
                {
                    n = int.Parse(n_textBox.Text);
                    if (n <= 0)
                    {
                        MessageBox.Show("Минимальное значение 1");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Неверный ввод");
                    return;
                }
                try
                {
                    s = int.Parse(start_textBox.Text);
                }
                catch
                {
                    MessageBox.Show("Неверный ввод");
                    return;
                }
                try
                {
                    f = int.Parse(finish_textBox.Text);
                }
                catch
                {
                    MessageBox.Show("Неверный ввод");
                    return;
                }
                if (s > f)
                {
                    MessageBox.Show("Начальное значение не может быть больше конечного");
                    return;
                }
                int[] newArray = Input(n,s,f);
                Print(newArray);
                res_textBox.Text += "Среднее арифметическое отрицательных элементов:" + Math.Round(Change(newArray), 4);

            }
        }
    }
}
