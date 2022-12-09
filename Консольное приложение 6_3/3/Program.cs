    using System;

namespace _3
{
    class Program
    {
        static int[,] Input(out int n)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите количество элементов в массиве: ");
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
            int[,] mas = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Элемент №[{0},{1}]= ", i, j);
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

        static void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < mas.GetLength(1); ++j)
                    Console.Write("{0,5} ", mas[i, j]);
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

        static void Main(string[] args)
        {
            int n;
            int[,] myArray = Input(out n);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            Console.WriteLine("Полученный массив:");
            Rezalt(myArray);
            Print(myArray);
            Console.ReadKey();
        }
    }
}
