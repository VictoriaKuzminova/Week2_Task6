using System;

namespace _4
{
    class Program
    {
        static int[][] Input(out int n)
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
            int[][] mas = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Элемент №[{0},{1}]= ", i, j);
                            mas[i][j] = int.Parse(Console.ReadLine());
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
        static void Print1(int[] mas) 
        {
            for (int i = 0; i < mas.Length; ++i)
                Console.Write("{0,5} ", mas[i]);

        }
        static void Print(int[][] mas)
        {
            for (int i = 0; i < mas.Length; ++i, Console.WriteLine())
            {
                for (int j = 0; j < mas[i].Length; ++j)
                {
                    Console.Write("{0,5} ", mas[i][j]);
                }
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
                    if (array[i][j] < 0 )
                    {
                        res += array[i][j];
                    }

                }
                sum[j] = res;

            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[][] newArray = Input(out int n);
            Console.WriteLine("Ступенчатый массив");
            Print(newArray);
            int[] sum = Sum(newArray, n);
            Console.WriteLine("Массив с суммами");
            Print1(sum);
            Console.ReadLine();
        }
    }
}
