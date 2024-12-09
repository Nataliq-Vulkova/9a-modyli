using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр_6_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("изход 1");
            Console.WriteLine(n--);
            Console.WriteLine("изход 2");
            Console.WriteLine(n);
            Console.WriteLine("изход 3");
            Console.WriteLine(--n);
            Console.WriteLine("изход 4");
            Console.WriteLine(n);
            Console.WriteLine("изход 5");
            Console.WriteLine(n++);
            Console.WriteLine("изход 6");
            Console.WriteLine(n);
            Console.WriteLine("изход 7");
            Console.WriteLine(++n);
            Console.WriteLine("изход 8");
            Console.WriteLine(n);
        }
    }
}
