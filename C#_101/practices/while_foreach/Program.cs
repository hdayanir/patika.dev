﻿using System;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            //While
            // 1 den baslayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console a yazdiran program
            Console.WriteLine("Lütfen bir sayi giriniz. : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            

            //a dan z ye kadar tüm harfleri console a yazdiram program
            char character ='a';
            while (character<'z')
            {
                Console.Write(character);
                character ++;
            }
            

            //Foreach
            string[] arabalar ={"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}