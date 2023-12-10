using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Fibonacci serisi için derinlik (bir pozitif tam sayı) girin: ");
                int derinlik = int.Parse(Console.ReadLine());

                if (derinlik <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
                    return;
                }

                int[] fibSeries = Fibonacci(derinlik);
                Console.WriteLine($"Fibonacci serisi: {string.Join(", ", fibSeries)}");

                double ortalama = CalculateAverage(fibSeries);
                Console.WriteLine($"Fibonacci serisi terimlerinin ortalaması: {ortalama}");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz bir giriş. Lütfen bir tam sayı girin.");
            }
        }

        static int[] Fibonacci(int n)
        {
            int[] fibSeries = new int[n];
            fibSeries[0] = 0;
            fibSeries[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibSeries[i] = fibSeries[i - 1] + fibSeries[i - 2];
            }

            return fibSeries;
        }

        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum / array.Length;
        }
    }
}
