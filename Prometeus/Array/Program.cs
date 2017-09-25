using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new [,]
            {
                {5, 10, 13, -4, 10},
                {20, 2, 9, 9, -1},
                {5, 10, 4, 8, 14},
                {6, 1, 2, 6, 10},
                {95, 5, 10, 10, 2}
            };
            var b = new [,]
            {
                {5, 10, 8, -4, 62},
                {20, 2, 9, 9, -1},
                {5, 10, 1, 8, 1},
                {6, 1, 2, 6, -5},
                {95, 5, 1, 3, 2}
            };

            int [,] c = new int [5,5];

            int n = 5;         
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}|", c[i, j]);
                }
                Console.WriteLine();
            }
        
        }
    }
}
