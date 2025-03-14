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
            int thirdhighestvalu = arrayint.Where( 
                i => i != ( 
                arrayint.Where(i=> i !=(
                arrayint.Where(i=>i != 
                arrayint.Max()).First())).First())).First();
           // Console.WriteLine(thirdhighestvalu);
          // Console.WriteLine(arrayint.OrderByDescending(x => x).Take(3).Last());

           Console.WriteLine (arrayint.GroupBy(s=>s).OrderByDescending(x=>x.Key).ElementAt(2).FirstOrDefault());
            



        }

    }
}
