using System;

namespace generic_list
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object turundedir

            List<int> sayiListesi = new  List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new  List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //ForEach ve List.ForEach ile elemanlara erisim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);         
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);         
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman cikarma - degere gore cikarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman cikarma - indekse gore cikarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste icerisinde arama yapma
            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 Liste icerisnde bulundu");
            } 

            //Eleman ile index'e erisme
            System.Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List tipinde bir List' e cevirme
            string[] hayvanlar = {"kedi", "kopek", "kus"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasil temizleriz
            hayvanListesi.Clear();

            //List icerisinde nesne tutmak
            List<kullanicilar> kullaniciListesi = new List<kullanicilar>();
            kullanicilar kullanici1 =  new kullanicilar();
            kullanici1.Isim="Huseyin";
            kullanici1.Soyisim="Dayanir";
            kullanici1.Yas=25;

            kullanicilar kullanici2 =  new kullanicilar();
            kullanici2.Isim="Kodluyoruz";
            kullanici2.Soyisim="Patika";
            kullanici2.Yas=25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);   

            List<kullanicilar> yeniListe =  new List<kullanicilar>();
            yeniListe.Add( new kullanicilar(){
                Isim = "Ali",
                Soyisim = "Veli",
                Yas = 25
            });

            foreach (var kullanici in kullaniciListesi)
            {
                System.Console.WriteLine("Kullanici adi : " + kullanici.Isim);
                System.Console.WriteLine("Kullanici soyadi : " + kullanici.Soyisim);
                System.Console.WriteLine("Kullanici yasi : " + kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}