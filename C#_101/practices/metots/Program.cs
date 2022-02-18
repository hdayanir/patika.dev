using System;

namespace metots
{
    class Program
    {
        public static void Main(string[] args)
        {
            //erisim belirteci    geri donosom tipi    metot adi(paramatreListesi/arguman)
            //{
                //komutlar;
                //return;
            //}

            //iki sayiyi toplayan komut
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2= ornek.ArttirveTopla(ref a,ref b);// a ile b nin referansi verildi. Referans vermek ne demek ?
            //bu fonksiyona a ile b nin degerlerini degil de bellekteki karsiliklarini vermektir.
            //degerlerde kalici olarak degisiklik yapmak istedigimiz zaman degiskenlerin referansi verilir. 
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir((a+b).ToString());
        }
        static int Topla(int deger1, int deger2){
            return (deger1+deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);    
        }

        public int ArttirveTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}