using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace смятане
{
    internal class смятане
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно трицифрено число");
            int a = int.Parse(Console.ReadLine());
            int s, d, e;
            s = a / 1000;
            d = a % 1000 / 100;
            e = a % 1000 % 100 /10;

            Console.WriteLine($"s={s} , d={d} , e={e}");
        }
    }
}
