using System;

namespace recursive_extension_metots
{
    class Program
    {
        public static void Main(string[] args)
        {
            //recursive - oz yinelemeli
            //3^4 ün hesaplanmasini yapalim. Önce for döngüsü ile, daha sonra recursive fonksiyon ile yapalım.
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //extension Metotlar
            string ifade = "Huseyin Dayanir";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi ={9,3,6,2,1,5,0}; 
            dizi.SortArray();
            dizi.EkranaYazdir();
            
            int sayi=5;
            Console.WriteLine(sayi.isEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2){
                return sayi;
            }
            return Expo(sayi,üs-1)*sayi;
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces( this string param) // this ifadesini ekledigimiz an bu bir extension metot olmus oluyor.
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces( this string param) // this ifadesini ekledigimiz an bu bir extension metot olmus oluyor.
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase( this string param) // this ifadesini ekledigimiz an bu bir extension metot olmus oluyor.
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase( this string param) // this ifadesini ekledigimiz an bu bir extension metot olmus oluyor.
        {
            return param.ToLower();
        }
        public static int[] SortArray( this int[] param) // this ifadesini ekledigimiz an bu bir extension metot olmus oluyor.
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param){
            foreach (int item in param)
            {
                Console.WriteLine(item);       
            }
        }
        public static bool isEvenNumber(this int param){   
            return param%2 ==0;          
        }

        //verilen stringin ilk karakterini veren program
         public static string GetFirstCharacter(this string param){ 
            return param.Substring(0,1);         
        }
    }
}