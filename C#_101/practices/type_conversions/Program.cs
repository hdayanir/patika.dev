using System;

namespace type_conversions
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //type conversions = Tip donusumleri
            //Implicit Conversion (Bilincsiz donusum)
            byte   a = 5;
            sbyte  b = 30;
            short  c = 10;
            int    d = a + b + c;
            Console.WriteLine("d : "+ d);
            long   e = d;
            Console.WriteLine("e : "+ e);
            long   f = e;
            Console.WriteLine("f : "+ f);

            string g = "huseyin";
            char   h = 'd';
            object i = g + h + d;
            Console.WriteLine("i : "+ i);

            //Explicit Conversion (Bilincli donusum)
            int    x = 4;
            byte   y = (byte)x;
            Console.WriteLine("y : "+ y);
            
            int    z = 100;
            byte   t = (byte)z;
            Console.WriteLine("t : "+ t);

            float   w = 10.3f;
            byte   v = (byte)w;
            Console.WriteLine("v : "+ v);

            //ToString Metodu
            int x1 = 6;
            string y1 = x1.ToString();
            Console.WriteLine("y1 : "+ y1);

            string x2 = 12.3f.ToString();
            Console.WriteLine("x2 : "+ x2);

            //System.Convert sinifi
            string s1 = "10", s2 ="20";
            int sayi1,sayi2;
            int toplam;
            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam = sayi1 +sayi2;
            Console.WriteLine("toplam : "+ toplam);
            
            //Parse Metodu 
            ParseMethod();
        }
        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 : "+ rakam1);
            Console.WriteLine("double1 : "+ double1);
            
        }
    }
}