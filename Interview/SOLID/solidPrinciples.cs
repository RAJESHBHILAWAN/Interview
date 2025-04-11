using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.SOLID
{
    internal class solidPrinciples
    {
    }



    #region "S for SOLID"
    // Single responsibility Principle
    public class ClassX
    {
        public ClassX() { }

        private void DoSometing()
        {
            clsExceptionHandler obj = new clsExceptionHandler();
            try
            {
                //Do Something
            }
            catch (Exception ex) {
                obj.ExceptionHandling(ex);
            }
        }

    }
    public class clsExceptionHandler
    {

        public void ExceptionHandling(Exception ex) {
            string file = "Exception.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = Path.Combine(path, @"Interview");

            // Validation Code should you need it.

            var log = Path.Combine(fullPath, file);
            using (StreamWriter writer = new StreamWriter(log))
            {
                // Data
            }
        }

    }
    #endregion

    #region "O for SOLID"
    // Open Closed pronciple open for extension closed for changes
    public class Customers
    {
        public int GetDiscount(int discount)
        {
            return discount;
        }
    }

    public class GoldCustomers : Customers
    {
        private void DoSometing() {

            int discount = base.GetDiscount(200) - 4000;
        }

    }

    public class SilverCustomers : Customers
    {
        private void DoSometing()
        {

            int discount = base.GetDiscount(200) - 2000;
        }

    }
    public class CopperCustomers : Customers
    {
        private void DoSometing()
        {

            int discount = base.GetDiscount(200) - 1000;
        }

    }
    #endregion

    #region "L for SOLID"

    public interface IDiscount
    {
        public void GetDiscount();
    }
    public interface IBuying
    {
        public void DatabaseEntry();
    }

    public class Enquiry : IDiscount
    {
        public void GetDiscount()
        {
            Console.WriteLine("Get Discount");
        }
    }

    public class Customer : IDiscount, IBuying
    {
        public void DatabaseEntry()
        {
            Console.WriteLine("Purchase and Set entry in Database");
        }

        public void GetDiscount()
        {
            Console.WriteLine("Get Discount");
        }
    }


    public class ApplicationClass
    {

        private void DoSometing()
        {
            List<IBuying> list = new List<IBuying>();
            list.Add(new Customer());
            //list.Add(new Enquiry()); 
            List<IDiscount> reads = new List<IDiscount>();
            reads.Add(new Customer());
            reads.Add(new Enquiry());
        }
    }

    #endregion


    #region "I for SOLID"
    // Interface segregation principle
    interface IDatabase: IRead
    {
        public void DatabaseEntry();
    }
    interface IRead
    {
        public void ReadBook();
    }

    public class CustomerWithReadOnly : IRead
    {
        public void ReadBook()
        {
            Console.WriteLine("Read books");
        }
    }
    public class NormalCustomer : IDatabase
    {

        public void DatabaseEntry()
        {
            Console.WriteLine("Read books and purchase");
        }

        public void ReadBook()
        {
            Console.WriteLine("Read books");
        }
        
    }

    #endregion

}
