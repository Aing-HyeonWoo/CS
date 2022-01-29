using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CheckPoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const string LINE = "-------------------------";
            const int END_LINE = 21;

                int runA = 0;
                int runB = 0;
                int runC = 0;
                int runD = 0;



            while (true)
            {
                Thread.Sleep(300);
                Console.Clear();

                ++runA;
                ++runB;
                ++runC;
                ++runD;

                int rndNum = rnd.Next(0, 4);

                switch(rndNum)
                {
                    case 0:
                        ++runA;
                        break;
                    case 1:
                        ++runB;
                        break;
                    case 2:
                        ++runC;
                        break;
                    case 3:
                        ++runD;
                        break;
                }

                Console.WriteLine(LINE);

                for(int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");
                for (int i = END_LINE -1 - runA; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.Write("2");
                for (int i = END_LINE - 1 - runB; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.Write("3");
                for (int i = END_LINE - 1 - runC; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.Write("4");
                for (int i = END_LINE - 1 - runD; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(LINE);

                if(runA > END_LINE || runB > END_LINE || runC > END_LINE || runD > END_LINE)
                {
                    int runNum = 0;

                    

                    if (runA >= END_LINE)
                        runNum = 1;
                    else if (runB >= END_LINE)
                        runNum = 2;
                    else if (runC >= END_LINE)
                        runNum = 3;
                    else
                        runNum = 4;

                    Console.WriteLine("결과 : {0} 선수 우승", runNum);
                    break;
                }
            }

            
        }
    }
}
