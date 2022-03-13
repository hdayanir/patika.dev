using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int,string>();  //Key integer olsun, value si ise string olsun. 
            kullanicilar.Add(10,"Huseyin DAYANIR"); // ilk deger key, ikinci deger ise value
            kullanicilar.Add(12,"a B");
            kullanicilar.Add(14,"c D");
            kullanicilar.Add(16,"e F");

            //Dizinin elemalarına erişim
            System.Console.WriteLine("***** Dizinin elemanlarına erişim *****");
            System.Console.WriteLine(kullanicilar[12]);//12 key'ine sahip değeri getir.
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Count
            System.Console.WriteLine("***** Count *****");
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine("***** Contains *****");
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("a B"));

            //Remove
            System.Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(16);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Keys
            System.Console.WriteLine("***** Keys *****");
            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }

            //Values
            System.Console.WriteLine("***** Values *****");
            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}