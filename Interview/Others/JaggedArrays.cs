using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class JaggedArrays
    {
        public JaggedArrays() {
            Example2();
        }
        private void Example1()

        {
            int[][] simple = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8 } };
            int[,][] complex = new int[2, 2][]
                  {
                     { new int[] { 1 }, new int[] { 2, 3 } },
                     { new int[] { 4, 5, 6 }, new int[] { 7,8,9,10 } }
                  };

            Console.WriteLine("simple[1][0]: " + simple[1][0]);
            Console.WriteLine("simple[1][1]: " + simple[1][1]);
            Console.WriteLine("simple[0][2]: " + simple[0][2]);

        }
        private void Example2()
        {
            int[][,] jaggedArray = new int[3][,]  {
                new int[ , ] { {1, 8}, {6, 7} },
                new int[ , ] { {0, 3}, {5, 6}, {9, 10} },
                new int[ , ] { {11, 23}, {100, 88}, {0, 10} }
             };

            Console.WriteLine(jaggedArray[0][0, 1]);
            Console.WriteLine(jaggedArray[1][2, 1]);
            Console.WriteLine(jaggedArray[2][1, 0]);

            Console.ReadLine();
        }


    }
}
