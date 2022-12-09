using System;

namespace _1
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
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
            while (true)
            {
                try
                {
                    Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    if (m <= 0)
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

            int[,] mas = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Элемент №[{0},{1}]= ", i + 1,j+1);
                            mas[i, j] = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Неверный ввод");
                        }
                    }
                }
            }
            
            return mas;
        }

        static void Print(int[,]mas)
        {
            for (int i = 0; i < mas.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < mas.GetLength(1); ++j)
                    Console.Write("{0,5} ", mas[i, j]);
        }

        static double Change(int[,] mas)
        {
            double arifm = 0, count = 0, sum = 0;
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    if (mas[i, j] < 0)
                    {
                        sum += mas[i, j];
                        count++;
                        arifm = sum / count;
                    }
                }
            }
            return arifm;
        }

        static void Main()
        {
            int n, m;
            int[,] myArray = Input(out n, out m);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            Console.WriteLine("Среднее арифметическое отрицательных элементов   :{0}", Math.Round(Change(myArray), 4));
        }
    }

}

