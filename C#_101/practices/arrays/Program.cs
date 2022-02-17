using System;

namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kus","maymun"};
            
            int[] dizi;
            dizi = new int[5];

            //Dizilere deger atama ve erisim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);      

            //Dongulerle dizi kullanimi
            //Klavyeden girilen n tane sayisinin ortalamasi bulan program
            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz : ");
            int diziuzunlugu= int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayiyi giriniz : ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam =0;
            foreach (var sayi in sayiDizisi)
            {   
                toplam +=sayi;

            }
            Console.WriteLine("Ortalama : " + toplam/diziuzunlugu);
        }
    }
}