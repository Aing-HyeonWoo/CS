using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_Func_params
{
    class Program
    {
        static int Total(params int[] values)
        {
            int total = 0;

            for(int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Total : " + Total(200, 5, 3, 1, 100));
        }
    }
}
