using System;

namespace error_handling
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Bir sayı giriniz ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi : " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : "+ ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            */
            /*
            try
            {
                //int a= int.Parse(null);
            
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            */
            /*
            try
            {
                int a= int.Parse("test");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değildir.");
                Console.WriteLine(ex);
            }
            */

            try
            {
                int a= int.Parse("-20000000000");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }      
    }
}