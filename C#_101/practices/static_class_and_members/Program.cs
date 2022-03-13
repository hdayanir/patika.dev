using System;

namespace static_class_and_members
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan sayısı : " + Calisan.CalisanSayisi);

            Calisan calisan1= new Calisan("Hüseyin","DAYANIR","Backend");
            System.Console.WriteLine("Çalışan sayısı : " + Calisan.CalisanSayisi);

            Calisan calisan2= new Calisan("a","B","Frontend");
            Calisan calisan3= new Calisan("c","D","Full Stack");
            System.Console.WriteLine("Çalışan sayısı : " + Calisan.CalisanSayisi);
           


           System.Console.WriteLine("Toplam sonucu  : " + Islemler.Topla(100,200));
           System.Console.WriteLine("Çıkarma sonucu : " + Islemler.Cikar(500,200));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){  //static consructor
            calisanSayisi=0;
        } 
        public Calisan(string isim = null, string soyisim = null, string departman = null)
        {
            this.Isim= isim;
            this.Soyisim = soyisim;
            this.Departman= departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}
