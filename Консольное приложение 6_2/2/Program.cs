using System;

namespace _2
{
    class Program
    {
        static double[] Input()
        {
            int n;
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
            double[] mas = new double[n];
            for (int i = 0; i < n; ++i)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Элемент №[{0}]= ", i );
                        mas[i] = double.Parse(Console.ReadLine());
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

        static void Main()
        {
            double[] myArray = Input();
            Console.WriteLine("Номер первого минимального элемента = " +Min(myArray)    );
        }

    }
}
