using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kisi = { "ali", "can" };
            int[] can = { 1, 2, 3, 4, 5 };
            char[] karakter = { 'a', 'b' };

            Console.Write(kisi[1] + "-" + can[3] + "-" + karakter[0]);


            Console.ReadKey();
        }
    }
}
