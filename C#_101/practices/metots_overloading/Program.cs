using System;

namespace metots_overloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            //out parametreler
            string sayi ="999";
            bool sonuc = int.TryParse(sayi, out int outsayi);
            if(sonuc){
                Console.WriteLine("Başarili");
                Console.WriteLine(outsayi);
            }
            else{
                Console.WriteLine("Basarisiz");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading 
            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Hüseyin","Dayanir");

            //Metot imzasi nedir?
            // metotAdi + parametre sayisi + parametre 
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri, string veri2)
        {
            Console.WriteLine(veri + " " + veri2);
        }
    }
}