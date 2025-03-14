using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.DesignPatterns
{
    public class SingletonInstance 
    {
        public SingletonInstance()
        {

            Parallel.Invoke(() => WriteInstanceEmployee(),()=> WriteInstanceManager());

        }

        public void WriteInstanceManager()
        {

            InterviewPrep.DesignPatterns.Singleton singleton = InterviewPrep.DesignPatterns.Singleton.GetInstance();
            singleton.WriteMessage("Invoked from Manager");
        }

        public void WriteInstanceEmployee()
        {

            InterviewPrep.DesignPatterns.Singleton singleton = InterviewPrep.DesignPatterns.Singleton.GetInstance();
            singleton.WriteMessage("Invoked from Employee");
        }


    }

    public class Singleton
    {
        private static int instanceCounter = 0;
        private static Singleton? instance  ;
        
        private static readonly object instanceLock = new object();
        private Singleton() {
            instanceCounter++;
            Console.WriteLine($"No of instances created are : {instanceCounter}");
        }

        public static Singleton GetInstance() {

            lock (instanceLock) { 
               
              if (instance == null)
                {
                    instance = new Singleton();
                   
                }
            }


         return instance;
        }

        public void WriteMessage(string message) { 
            Console.WriteLine($"Message from singleton: {message} at instance: { instanceCounter }" );
        }
    
    
    
    }
}
