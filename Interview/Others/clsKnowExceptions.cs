using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class clsKnowExceptions
    {
        public clsKnowExceptions() {
            //  InsideFinally();
            //ApplcatchesException();
           // methodA();
        }
        public void methodA()
        {
            try
            {

                B test = new B();
                test.methodB();
            }
            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine("Exception from class A");
            }
            finally {
                Console.WriteLine("Inside Class A finally");
            
            }
        }
        private void ApplcatchesException()
        {
            try
            {
                throw new SystemException("This is wrong");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               Console.WriteLine("I am inside finally");
                Console.ReadLine();
            }
        }


        private void ReturnInFinally()
        {
            try
            {

            }
            catch
            {
                return;
            }
            finally
            {
                //return;
            }
        }


        private void PreviousCatchAlreadyCatches()
        {
            try
            {
                throw new SystemException();
            }
            catch(System.Exception ex) 
            {
                 
            }
            //catch (ArgumentException ex)
            //{

            //}
            finally
            {
                //return;
            }
        }

        private void InsideFinally()
        {
            try
            {
                throw new SystemException("This is wrong");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
          
            finally
            {
                Console.WriteLine("Im inside finally");
            }
        }




    }


    public class B
    {
        public void methodB()
        {
            try
            {
                throw new Exception("Exception from class B");
            }
            catch (Exception ex)
            {
                throw;
                Console.WriteLine("Exception from class A");
            }
            finally {
                Console.WriteLine("Inside class B finally");
            }
        }
    }


    public class MyApplException : ApplicationException
    {
        public MyApplException()
        {
        }

        public MyApplException(string message)
            : base(message)
        {
        }

        public MyApplException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class EmployeeListNotFoundException : Exception
    {
        public EmployeeListNotFoundException()
        {
        }

        public EmployeeListNotFoundException(string message)
            : base(message)
        {
        }

        public EmployeeListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
