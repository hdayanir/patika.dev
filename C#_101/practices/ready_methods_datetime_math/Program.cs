using System;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));     //integer //24
            Console.WriteLine(DateTime.Now.ToString("ddd"));    //saturday yerine sat yazar //sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));   //saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));     //integer //24
            Console.WriteLine(DateTime.Now.ToString("MMM"));    //february yerine sat yazar //feb
            Console.WriteLine(DateTime.Now.ToString("MMMM"));   //february      

            Console.WriteLine(DateTime.Now.ToString("yy"));     //integer //22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));   //2022    

            //Math Kutuphanesi
            Console.WriteLine(Math.Abs(-25)); //Mutlak deger
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(10.3));  //11
            Console.WriteLine(Math.Round(10.3));    //10
            Console.WriteLine(Math.Round(10.7));    //11
            Console.WriteLine(Math.Floor(10.7));    //10
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Pow(2,6));       //2 uzeri 6
            Console.WriteLine(Math.Sqrt(2));        //karekok
            Console.WriteLine(Math.Log(9));         //9 un e tabanindaki karsiligi
            Console.WriteLine(Math.Exp(3));         //e uzeri 3
            Console.WriteLine(Math.Log10(10));      //10 sayisinin log 10 tabanindaki karsiligi
            











            
        }
    }
}