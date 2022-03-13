using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz dizini
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //          Metot komutları
            //      }    
            // }

            // Erişim belirleyiciler
            // * Public         Her yerde erişilebilir.
            // * Private        Sadece tanımlandığı sınıf içerinde erişilebilir.
            // * Internal       Sadece bulunduğu proje içerisinde (yani ...cs içerisinde) erişilebilir.
            // * Protected      Sadece tanımlandığı sınıfta veya o sınıftan miras alan diğer sınıflarda kullanılabilir.

            Calisan calisan1= new Calisan();
            calisan1.Ad ="Huseyin";
            calisan1.Soyad="DAYANIR";
            calisan1.no=123;
            calisan1.Departman="Backend";
            calisan1.CalisanBilgileri();

            System.Console.WriteLine("*****");
            
            Calisan calisan2= new Calisan();
            calisan2.Ad ="Ali";
            calisan2.Soyad="VELİ";
            calisan2.no=456;
            calisan2.Departman="Frontend";
            calisan2.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int no;
        public string Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı        : " + Ad);
            System.Console.WriteLine("Çalışan Soyadı     : " + Soyad);
            System.Console.WriteLine("Çalışan Numarası   : " + no);
            System.Console.WriteLine("Çalışan Departmanı : " + Departman);
        }

    }
}
