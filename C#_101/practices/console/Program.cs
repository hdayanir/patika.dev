﻿using System;

namespace console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("İsminizi giriniz : ");
            string name = Console.ReadLine();
            Console.WriteLine("Soy isminizi giriniz : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);

        }
    }
}