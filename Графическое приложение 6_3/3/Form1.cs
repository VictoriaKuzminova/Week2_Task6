using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int[,] Input(int n, string[,] sNums)
        {
            int[,] mas = new int[n, n];
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = int.Parse(sNums[i, j]);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных. Попробуйте снова");
                textBox1.Text = "";
            }
            return mas;
        }
        void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    textBox1.Text += $"\t {mas[i, j]} ";
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        static void Rezalt(int[,] mas)
        {
            int row1;
            int row2;
            if (mas.GetLength(0) % 2 == 0)
            {
                row1 = mas.GetLength(0) / 2;
                row2 = row1 - 1;
            }
            else
            {
                row1 = mas.GetLength(0) / 2;
                row2 = 0;
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                int tmp = mas[row1, i];
                mas[row1, i] = mas[row2, i];
                mas[row2, i] = tmp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if (n_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
                return;
            }
            else
            {
                textBox1.Text = "";
                if (!int.TryParse(n_textBox.Text, out int n) || n <= 1)
                {
                    MessageBox.Show("Некорректный ввод данных. Попробуйте снова\nМинимальное число 2, поскольку массив двухмерный и если число меньше 2 т " +
                        " программа не имеет смысла");
                    return;
                }
                try
                {
                    var sNums = new string[n, n];
                    var arr1 = textBox2.Text.Split('\n');
                    if (arr1.Length != n)
                    {
                        MessageBox.Show("Длина массива не соответствует введенному!",
                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        var arr2 = arr1[i].Split(' ');
                        
                        for (int j = 0; j < n; j++)
                        {

                            sNums[i, j] = arr2[j];
                        }
                    }
                    //Проперка на количество знаков
                    if (sNums.Length > n * n)
                    {
                        MessageBox.Show("Длина массива не соответствует введенному!");
                        return;
                    }
                    int[,] myArray = Input(n, sNums);
                    textBox1.Text += "Исходный массив:" + Environment.NewLine;
                    Print(myArray);
                    Rezalt(myArray);
                    Console.WriteLine();
                    textBox1.Text += "Изменённый массив" + Environment.NewLine;
                    Print(myArray);
                }
                catch (Exception)
                {
                    MessageBox.Show("Длина массива не соответствует введенному!");
                    return;
                }

            }

        }
    }
}
