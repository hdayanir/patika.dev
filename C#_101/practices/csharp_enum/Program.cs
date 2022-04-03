using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if (sicaklik <=(int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Hava soğuk");    
            }
            else if(sicaklik >=(int)HavaDurumu.Sicak)
            {
                System.Console.WriteLine("Hava çok sıcak"); 
            }
            else if(sicaklik >=(int)HavaDurumu.Normal && sicaklik <(int)HavaDurumu.CokSicak)
            {
                System.Console.WriteLine("Hava sıcak"); 
            }
            
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal =20,
        Sicak=25,
        CokSicak=30
        
    }
}
