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
            int[][] simple = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8 } };
            int[,][] complex = new int[2, 2][]
                  {
                     { new int[] { 1 }, new int[] { 2, 3 } },
                     { new int[] { 4, 5, 6 }, new int[] { 7,8,9,10 } }
                  };


        }



    }
}
