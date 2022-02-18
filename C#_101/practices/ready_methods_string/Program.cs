using System;

namespace ready_methods_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Length
            string degisken = "Dersimiz C sharp, Hos geldiniz.. ";
            string degisken2 = "Dersimiz C sharp";
            string degisken3 = "dersimiz C sharp, Hos geldiniz.. ";

            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba "));

            //CompareTo : 1. degisken 2. degiskene esit ise "0" doner,
            //            1. degisken 2.degiskenden daha fazla karaktere sahip ise "1" doner,
            //            1. degisken 2.degiskenden daha az karaktere sahip ise "-1" doner,
            Console.WriteLine(degisken.CompareTo(degisken2));

            //Compare   : 1. degisken 2. degiskene esit ise "0" doner,
            //            1. degisken 2.degiskenden daha fazla karaktere sahip ise "1" doner,
            //            1. degisken 2.degiskenden daha az karaktere sahip ise "-1" doner,
            Console.WriteLine(string.Compare(degisken,degisken3,true)); //ignoreCase : buyuk kucuk durumu duyarsiz hale gelir.
            Console.WriteLine(string.Compare(degisken,degisken3,false));//ignoreCase : buyuk kucuk durumu duyarli hale gelir.

            //Contains 
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hos geldiniz.. "));
            Console.WriteLine(degisken.StartsWith("Mer haba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("C s"));
            Console.WriteLine(degisken.IndexOf("Huseyin"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            
            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));

            //PadFelt, PadRight
            Console.WriteLine(degisken.PadLeft(35,'-') + degisken3.PadLeft(35,'*'));

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. karakterden basla ve devamini sil
            Console.WriteLine(degisken.Remove(5,3)); //5. karakterden basla ve 3 karakter sil

            //Replace
            Console.WriteLine(degisken.Replace("C sharp", "C#"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1] );    //Bosluklara gore parcala ve diziye ata ve 1. indexteki veriyi getir

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}