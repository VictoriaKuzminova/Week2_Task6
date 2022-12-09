using System;

namespace _1
{
    class Program
    {
        static int[] Input()
        {
            int n;
            Console.WriteLine("Введите разрядность массива: ");
            while (true)
            {
                try
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Минимальное значение 1");
                        continue;
                    }

                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            int[] mas = new int[n];
            for (int i = 0; i < n; ++i)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Элемент №[{0}]= ", i);
                        mas[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод");
                    }
                }
            }
            return mas;
        }

        static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; ++i) Console.Write("{0} ", mas[i]);
            Console.WriteLine();
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

        static void Main()
        {
            int[] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            Console.WriteLine("Среднее арифметическое отрицательных элементов: {0}", Math.Round(Change(myArray), 4));
        }
    }
}
