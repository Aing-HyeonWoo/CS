﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_Array_Flex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrNum = new int[3][];

            arrNum[0] = new int[2] { 0, 1 };
            arrNum[1] = new int[4] { 0, 1, 2, 3 };
            arrNum[2] = new int[] { 0, 1, 2 };

            Console.WriteLine("=== arrNum ===");

            foreach(int[] arr in arrNum)
            {
                foreach (int data in arr)
                {
                    Console.Write("  {0}  ", data);
                }
                Console.WriteLine("\n-------------------");
            }
        }
    }
}
