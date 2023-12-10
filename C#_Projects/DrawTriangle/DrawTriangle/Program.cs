using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Üçgenin boyutunu girin: ");
                int boyut = int.Parse(Console.ReadLine());

                DrawTriangle(boyut);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz bir giriş. Lütfen bir tam sayı girin.");
            }
        }

        static void DrawTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
