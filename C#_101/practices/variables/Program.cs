using System;

namespace variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*int deger =2;
            string degisken =null;
            string Degisken = null;
            string degisken_V1 = "null";
            string degisken+V1 = "null";
            String degisken1 ="";
            */
            
            byte    a = 5; //1 byte
            sbyte   b = 4; //1 byte

            short   c = 5; //2 byte
            ushort  d = 4; //2 byte
            
            Int16   e = 2; //2 byte
            int     f = 3; //4 byte
            Int32   g = 4; //4 byte
            Int64   h = 5; //8 byte
            uint    i = 2; //4 byte
            long    j = 4; //8 byte
            ulong   k = 5; //8 byte
            
            float   l = 4; //4 byte
            double  m = 5; //8 byte
            decimal n = 4; //16 byte            
            
            char    o ='c';//2 byte
            string  p="st";//sinirsiz

            bool    r=true;

            DateTime s= DateTime.Now;

            object  o1="x";
            object  o2='x';
            object  o3=4;
            object  o4=4.3;

            string str1 = "";
            string str2 = string.Empty;
            string str3 = null;
            string str4 = "4";
            string str5 = "5";
            string str6 = str4 + " " + str5;

            int i1 = 5;
            int i2 = 3;
            int i3 = i1 * i2;

            bool b1 = 10>2;

            string str7= "20";
            int     i7 = 20;
            string yeniDeger1 = str7 +i7.ToString();

            string str8= "20";
            int     i8 = 20;
            int yeniDeger2 = i8 + Convert.ToInt32(str8);

            string str9= "20";
            int     i9 = 20;
            int yeniDeger3 = i9 + int.Parse(str9);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string datetime3 = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(s);

        }
    }
}