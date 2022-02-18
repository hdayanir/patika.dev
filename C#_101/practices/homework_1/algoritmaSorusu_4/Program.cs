using System;

namespace algoritmaSorusu_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz : ");
            string n = Console.ReadLine();
            string[] words = n.Split(" ");
            char[] characters = n.ToCharArray();
            Console.WriteLine(words.Length);
            Console.WriteLine(characters.Length-words.Length+1);
        }
    }

}