using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class YeildMethods
    {

        //You use the yield statement in an iterator to provide the next value or 
        // signal the end of an iteration.The yield statement has the two following forms:
        //yield return: to provide the next value in iteration 
        //yield break: to explicitly signal the end of iteration 
        // The yield keyword tells the compiler that the method in which it appears is an 
        // iterator block.An iterator block, or method, returns an IEnumerable as the 
        // result.And the yield keyword is used to return the values for the IEnumerable.

        //An interesting thing aboug IEnumerable is that it is lazily evaluted. Calling a
        // method with an iterator block doesn't run any code. It's only when 
        // the IEnumerable is iterated over, or enumerated, that we get the actual 
        // values.  
        public YeildMethods() {
            Processor();
        }

public void Processor()
        {
            int[] i = new int[10];
            i = GetInts(2,10);
            for (int u = 0; u < 10; u++) { 
            
            Console.WriteLine(i[u]);
            
            }
           // IEnumerable<int> ie = GetYeildInts(2, 10);
            foreach(int item in GetYeildInts(2,10))
              {

                Console.WriteLine(item);

            }
        }
       public int[] GetInts(int start, int cnt)
        {
            int[] ints = new int[cnt];

            for (int i = 0; i < cnt; i++) { 
                ints[i] = start + 2 * i;
            }
            return ints;

        }
        public IEnumerable<int> GetYeildInts(int start, int cnt)
        {
            
            for (int i = 0; i < cnt; i++)
            {
             yield return  start + 2 * i;
            }
             

        }

    }
}
