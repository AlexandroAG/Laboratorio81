using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lboratorio83
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Suma(1.0, 2.2));
        }

        static int Suma(int x, int y)
        {
            return x + y;
        }
        static double Suma(double x, double y)
        {
            return x + y;
        }
        static long Suma(long x, long y)
        {
            return x + y;
        }
    }
}
