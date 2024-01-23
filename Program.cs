using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m:");
                int m = int.Parse(Console.ReadLine());
                int[,] a = new int[n, m];
                Random rnd = new Random();
                int count = 0;
                int count1 = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = rnd.Next(0, 10);
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Количество нулей над главной диагональю: {count}");
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (a[i, j] % 2 != 0)
                        {
                            count1++;
                        }
                    }
                }

                Console.WriteLine($"Число нечетных элементов, расположеных под побочной диагональю: {count1}");
            }
            catch
            {
                Console.WriteLine("Bведен символ");
            }
            Console.ReadKey();

            //19
            /*try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m:");
                int m = int.Parse(Console.ReadLine());
                int[,] c = new int[n, m];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        c[i, j] = rnd.Next(-10, 10);
                        Console.Write($"{c[i, j],4}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Введите a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                int count1 = 0;
                if (m > 0 || n > 0)
                {
                    if (a > 0 || b > 0)
                    {
                        for (int i = 0; i < c.GetLength(0); i++)
                        {
                            for (int j = 0; j < c.GetLength(1); j++)
                            {
                                if (c[i, j] % a == 0)
                                {
                                    count++;
                                }
                                if (c[i, j] % b == 0)
                                {
                                    count1++;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"{i + 1} кратные {a}={count} и b={count1}");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Введите k1");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите k2");
                int k2 = Convert.ToInt32(Console.ReadLine());
                double count2 = 1;
                for (int i = k1 - 1; i < k2; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (c[i, j] < 0)
                        {
                            Console.Write($"{c[i, j]} ");
                            count2 *= c[i, j];
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Произведение=" + Math.Round(count2, 2));
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Bведен символ");
            }
            Console.ReadKey();*/

        }
    }
}
