using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class AsyncAwait
    {
        public   AsyncAwait() {

            MainMethod();
        }
        private async void MainMethod()
        {
            string retstr = await RunAsync("Hi Rajesh Kumar Verma");
            Console.ReadLine();
            Console.WriteLine(retstr);
            Console.ReadLine();
        }

        private Task<string> RunAsync(string message) {
          return Task.Run<string>(() =>  LongRunningThread(message));
        
        }
        private string LongRunningThread(string message)
        {
            Thread.Sleep(1000);
            return "Hello: " + message;
        }

    }
}
