using System;

namespace algoritmaSorusu_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz : ",i+1);
                string k = Console.ReadLine();
                dizi[i] = k;
            }
            Array.Reverse(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                    Console.WriteLine(dizi[i]);
            }
            
        }
    }

}