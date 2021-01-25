using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayıyı_binary_çevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Dönüştürülecek sayıyı giriniz : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;

            }
            Console.Write("Binary sistemdeki karşılığı : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadKey();
        }
    }
}
