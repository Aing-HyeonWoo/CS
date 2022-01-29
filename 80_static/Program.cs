using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_static
{
    class Program
    {
        class AA
        {
            public static int a;
            public static int b;
            public static readonly int c = 200;

            public static void Print()
            {
                Console.WriteLine("a : {0}", a);
                Console.WriteLine("b : {0}", b);
            }
        }

        class BB
        {
            public int a;
            public int b;

            public void Print()
            {
                Console.WriteLine("a : {0}", a);
                Console.WriteLine("b : {0}", b);
            }

        }

        static void Main(string[] args)
        {

            AA.a = 10;
            AA.b = 100;

            AA.Print();

            BB bb = new BB();
            bb.a = 100;
            bb.b = 200;
            bb.Print();
        }
    }
}
