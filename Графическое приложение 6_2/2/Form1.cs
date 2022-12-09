using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private int n;
        private double[] arr;
        public Form1()
        {
            InitializeComponent();
        }
        static double Min(double[] mas)
        {
            double min = mas[0], mi = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                    mi = i;
                }
            }
            return mi;
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
                res_textBox.Text = "";
                if (!int.TryParse(n_textBox.Text, out n) || n <= 0)
                {
                    MessageBox.Show("В поле N введены недопустимые данные! Введите целое число больше 0!");
                    return;
                }
                arr = new double[n];
                try
                {
                    var digits = mas_textBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (digits.Length > n)
                    {
                        MessageBox.Show("Число введенных элементов больше, чем количество элементов массива!");
                        return;
                    }
                    else if (digits.Length < n)
                    {
                       MessageBox.Show("Число введенных элементов меньше, чем количество элементов массива!");
                        return;
                    }

                    res_textBox.Text += "Изначальный массив: ";
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = double.Parse(digits[i]);
                        res_textBox.Text += arr[i] + " ";
                    }
                }
                catch
                {
                    MessageBox.Show("В поле элементов массива введены неверные значения! Введите заново, используя только цифры, точку и знак \"минус\"");
                    return;
                }
                res_textBox.Text += "\nНомер первого минимального элемента: ";
                double min = arr[0], mi = 0;
                for (int i = 1; i <arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                        mi = i;
                    }
                }
                res_textBox.Text += Math.Round(mi, 1);
            }
        }
    }
}
