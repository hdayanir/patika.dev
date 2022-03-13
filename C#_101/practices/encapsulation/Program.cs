using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Huseyin";
            ogrenci1.Soyisim = "DAYANIR";
            ogrenci1.OgrenciNo = 123;
            ogrenci1.Sinif = 3;

            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("x","Y",456,1);
            ogrenci2.OgrenciBilgileriniGetir();

            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif {
            get => sinif; 
            set { 
                if(value <1){
                    System.Console.WriteLine("Sınıf en az bir olabilir");
                    sinif=1;
                }
                else
                sinif = value; 
            }
        }

        public Ogrenci(string isim, string soyisim = null, int ogrenciNo = 0, int sinif = 0)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("Ogrenci Adı :      " + this.Isim);
            System.Console.WriteLine("Ogrenci Soyadı :   " + this.Soyisim);
            System.Console.WriteLine("Ogrenci No :       " + this.OgrenciNo);
            System.Console.WriteLine("Ogrenci Sınıfı :   " + this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
