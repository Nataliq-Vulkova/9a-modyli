using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Формули
{
    internal class Формули
    {
        static void Main(string[] args)
        {
            double z, x, y;
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            y = double.Parse(Console.ReadLine());
            z = 2 * x + 3 * y * y + 4 * x * y + 5 / (20 * x * y * y * y);
            Console.WriteLine("Z=" + z);
            Console.WriteLine(Math.Round(z, 4));
            Console.WriteLine(Math.Ceiling(z));
            Console.WriteLine(Math.Floor(z));
        }
    }
}
