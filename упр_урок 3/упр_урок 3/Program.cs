using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упр_урок_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как се казваш бре: ");
            var name = Console.ReadLine();
            Console.Write("Каква оценка искаш: ");
            var оценка = Console.ReadLine();
            Console.WriteLine("Ти успя, {0} днес ти направи своето постижение! Днес ти ще имаш {1} само ако си изпълнил правилно кода", name, оценка);


        }
    }
}
