using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр_цикли
{
    internal class упр_цикли
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse( Console.ReadLine());
            for (var r = 1; r <= n; r++)
            {
                Console.Write("*");
                for (var i = 1; i < n; i++)
                {
                    Console.WriteLine(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
