using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[][] Input(int n,int s, int f )
        {
            int[][]mas = new int[n][];
            Random random = new Random();
            for (int j = 0; j < n; j++)
            {
                mas[j] = new int[n];
                for (int i = 0; i < n; i++)
                {
                    mas[j][i] = random.Next(s, f);
                }
            }

            return mas;
        }

        void Print1(int[] mas)
        {
            for (int i = 0; i < mas.Length; ++i)
            {
                res_textBox.Text += mas[i] + "\t";
            }
           res_textBox.Text += Environment.NewLine;

        }
        void Print(int[][] mas)
        {
            for (int j = 0; j < mas.Length; j++)
            {
                for (int i = 0; i < mas[j].Length; i++)
                {
                    mas_textBox.Text += mas[j][i] + "\t";
                }
                mas_textBox.Text += Environment.NewLine;
            }
        }

            static int[] Sum(int[][] array, int n)
        {
            int[] sum = new int[n];
            for (int j = 0; j < array.Length; j++)
            {
                int res = 0;
                for (int i = 0; i < array[j].Length; i++)
                {
                    if (array[i][j] < 0)
                    {
                        res += array[i][j];
                    }

                }
                sum[j] = res;

            }
            return sum;
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if (n_textBox.Text == "" || start_textBox.Text == "" || finish_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
                return;
            }
            else
            {
                mas_textBox.Text = "";
                res_textBox.Text = "";
                int n, s, f;
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
                int[][] newArray = Input(n, s, f);
                Print(newArray);
                int[] sum = Sum(newArray, n);
                Print1(sum);
            }
        }
    }
}
