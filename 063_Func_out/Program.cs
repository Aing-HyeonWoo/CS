using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_Func_out
{
    class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a;
            int b;

            InitNum(out a); // a = 100;
            Console.WriteLine("a : {0}", a);

            b = 0;
            InitRefNum(ref b);
            Console.WriteLine("b : {0}", b);
        }
    }
}
