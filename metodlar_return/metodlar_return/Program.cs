using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_return
{
    class Program
    {
        static void Main(string[] args)
        {
            string oku = Program.degeroku();
            // int can = sayıiste();               (sayı için böyle yazılır)
            Console.WriteLine(oku);
            Console.ReadLine();

        }
        private static string degeroku()
        {
            return Console.ReadLine();
          //  return Convert.ToInt32(Console.ReadLine());    (sayı için böyle yazılır)
        }
    }
}
