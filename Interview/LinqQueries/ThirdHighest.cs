using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.LinqQueries
{
    public class ThirdHighest
    {
      public  ThirdHighest() {
            ThirdHighestNumber();
        }

        private void ThirdHighestNumber()
        {
            int[] arrayint = { 1, 2, 3, 4, 6,6,7,7,7, 8 };
            //var res = from x in arrayint group x by x into grpx orderby grpx.Key descending select grpx;
            //Console.WriteLine(res.ElementAt(2).FirstOrDefault());

            Console.WriteLine (arrayint.GroupBy(s=>s)
               .OrderByDescending(x=>x.Key).ElementAt(2).FirstOrDefault());
            



        }

    }
}
