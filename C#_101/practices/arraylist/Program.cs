using System;
using System.Collections;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Huseyin");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //List içerisindeki verilere erişme 
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("***** Add Range *****");
            string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int> {1,8,3,7,89};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Sort
            System.Console.WriteLine("***** Sort *****");
           
            ArrayList liste1 = new ArrayList();
            List<int> sayilar1 = new List<int> {1,8,3,7,89};
            liste1.AddRange(sayilar1); 
            liste1.Sort();

            foreach (var item in liste1)
            {
                System.Console.WriteLine(item);
            }

            // Binary Search
            System.Console.WriteLine("***** Binary Search *****");
            System.Console.WriteLine(liste1.BinarySearch(9));

            // Reverse
            System.Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Clear
            liste.Clear();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}