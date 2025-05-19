using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InterviewPrep.DesignPatterns
{
    public class SingletonInstance
    {
        public SingletonInstance()
        {

            Parallel.Invoke(() => WriteInstanceEmployee(), () => WriteInstanceManager());

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
        private static Singleton? instance;

        private static readonly object instanceLock = new object();
        private Singleton()
        {
            instanceCounter++;
            Console.WriteLine($"No of instances created are : {instanceCounter}");
        }
        public static Singleton GetInstance()
        {


            //This is called Double checked locking mechanism, 
            //first, we will check whether the instance is created or not.
            //If not then only we will synchronize the method and create the instance. 
            //It will drastically improve the performance of the application.Performing lock is 
            //heavy.So to avoid the lock first we need to check the null value.This is also 
            //thread safe and it is the best way to achieve the best performance. Please have 
            //a look at the following code.
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine($"Message from singleton: {message} at instance: {instanceCounter}");
        }



    }
}
