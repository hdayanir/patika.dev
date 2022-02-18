using System;

namespace algoritmaSorusu_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. pozitif sayıyı giriniz : ",i+1);
                int m = int.Parse(Console.ReadLine());
                dizi[i] = m;
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
            
        }
    }

}