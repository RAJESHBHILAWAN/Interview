using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class YeildMethods
    {


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
            IEnumerable<int> ie = GetYeildInts(2, 10);
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
