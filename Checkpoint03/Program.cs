using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Checkpoint03
{
    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 25;
        const int DELAY_TIME = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                }

                Console.WriteLine("");
            }
        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void Main(string[] args)
        {
            char[] tile = {' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[7, 25]
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 },
                {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1 },
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };

            while (true)
            {
                for(int i = 0; i < arrIndexX.Length; i++) {
                    int indexMapX = i + 1;
                    int indexY = arrIndexX[i];

                    int temp = map[indexMapX, indexY];
                    map[indexMapX, indexY + 1] = temp;
                    map[indexMapX, indexY] = 0;

                    if(arrIndexX[i] < 24)
                        arrIndexX[i]++;
                }
                arrIndexX[0]++;
                arrIndexX[1]++;
                arrIndexX[2]++;
                arrIndexX[3]++;
                arrIndexX[4]++;

                map[1, arrIndexX[0]] = 3;
                map[2, arrIndexX[0]] = 4;
                map[3, arrIndexX[0]] = 5;
                map[4, arrIndexX[0]] = 6;
                map[5, arrIndexX[0]] = 7;
                UpdateView(tile, map);
                
                ClearView();
            }
            
            
        }
    }
}
