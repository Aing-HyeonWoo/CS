using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Array_Func2
{
    class Program
    {

        static int[] CreateIntArray(int size)
        {
            int[] creArray = new int[size];

            for(int i = 0; i < size; i++)
            {
                creArray[i] = 0;
            }

            return creArray;
        }

        static string[] CreateStrArray(int size)
        {
            string[] creArray = new string[size];

            for(int i = 0; i < size; i++)
            {
                creArray[i] = string.Empty;
            }

            return creArray;
        }

        static int[,] CreateIntArray()
        {
            int[,] array = new int[3, 2];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    array[i, j] = 0;
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] arrNum = CreateIntArray(3);
            string[] strName = CreateStrArray(5);
            int[,] array = CreateIntArray();

            foreach(int temp in arrNum)
            {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine("\n-------------------");

            arrNum[0] = 1000;

            foreach (string temp in strName)
            {
                Console.Write("  {0}", temp);
            }

            Console.WriteLine("\n-------------------");


            Console.WriteLine("\n-------------------");
        }
    }
}
