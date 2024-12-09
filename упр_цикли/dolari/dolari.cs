using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolari
{
    internal class dolari
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n= int.Parse(Console.ReadLine());
            for (var r = n; r >= 1; r--)
            {
                Console.Write("$");
                for (var c = r; c > 1; c--)

                { 
                    Console.Write(" $");
                }
                Console.WriteLine();
            }


        }
    }
}
