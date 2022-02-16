using System;

namespace operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Atama ve İslemli atama
            int x = 3;
            int y = 3;
            Console.WriteLine("y :"+ y);
            y = y + 2;
            Console.WriteLine("y :"+ y);
            y += 2;
            Console.WriteLine("y :"+ y);
            y /=2;
            Console.WriteLine("y :"+ y);
            x *=2;
            Console.WriteLine("x :"+ x);

            //Mantiksal Operatorler
            // ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
            Console.WriteLine("Great");
           
            if(isSuccess && !isCompleted)
            Console.WriteLine("Fine");
        
            //İliskisel operatorler
            // <, >, <=, >=, ==, !=,
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine("a<b :"+sonuc);
            sonuc = a>b;
            Console.WriteLine("a>b :"+sonuc);
            sonuc = a>=b;
            Console.WriteLine("a>=b :"+sonuc);
            sonuc = a<=b;
            Console.WriteLine("a<=b :"+sonuc);
            sonuc = a==b;
            Console.WriteLine("a==b :"+sonuc);
            sonuc = a!=b;
            Console.WriteLine("a!=b :"+sonuc);
        
            //Aritmetik operatorler
            // /, *, +, -
            int sayi1 = 3;
            int sayi2 = 4;
            int sonuc2 = sayi1*sayi2;
            Console.WriteLine("sayi1*sayi2 :"+sonuc2);
            sonuc2 = sayi1/sayi2;
            Console.WriteLine("sayi1/sayi2 :"+sonuc2);
            sonuc2 = sayi1+sayi2;
            Console.WriteLine("sayi1+sayi2:"+sonuc2);
            sonuc2 = sayi1-sayi2;
            Console.WriteLine("sayi1-sayi2 :"+sonuc2);
            sonuc2 = sayi1++;
            Console.WriteLine("sayi1++ :"+sonuc2);
        }
    }
}