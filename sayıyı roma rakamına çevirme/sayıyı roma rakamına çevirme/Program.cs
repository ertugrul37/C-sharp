using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıyı_roma_rakamına_çevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz");
            int sayi = Int32.Parse(Console.ReadLine());

            int birler = 0, onlar = 0, yuzler = 0, binler = 0;

            if (sayi < 10)
                birler = sayi;

            if (sayi > 9 && sayi < 100)
            {
                onlar = sayi / 10;
                birler = sayi - (onlar * 10);
            }

            if (sayi > 99 && sayi < 1000)
            {
                yuzler = sayi / 100;
                onlar = (sayi - (yuzler * 100)) / 10;
                birler = sayi - ((yuzler * 100) + (onlar * 10));
            }

            if (sayi > 999 && sayi < 10000)
            {

                binler = sayi / 1000;
                yuzler = (sayi - (binler * 1000)) / 100;
                onlar = (sayi - ((binler * 1000) + (yuzler * 100))) / 10;
                birler = sayi % 10;

            }
            string[] dbirler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string[] donlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            string[] dyuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

            string[] dbinler = { "", "M", "MM", "MMM" };
            Console.Write("roma rakamı ile : " + dbinler[binler]);
            Console.Write("" + dyuzler[yuzler]);
            Console.Write("" + donlar[onlar]);
            Console.Write("" + dbirler[birler]);



            Console.ReadKey();
        }
    }
}
