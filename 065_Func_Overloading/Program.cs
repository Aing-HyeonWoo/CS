using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_Func_Overloading
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = Add(1, 2);
            double b = Add(1.1, 1.2);
            Console.WriteLine(a.ToString(), b.ToString());
        }
    }
}
