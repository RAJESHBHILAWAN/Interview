using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class AnonymousMethods
    {


        public AnonymousMethods()
        {
            //AnonymousMethod();
            //AnonFunc();
            //AnonAction();
            //AnonSelect();
            //MyPredicate1();
            //MyEvent();
            MyClosure();
        }

        delegate void CalculateResult(int x);

        private void AnonymousMethod()
        {
            int x = 0;
            CalculateResult calculateResult = delegate (int x) { Console.WriteLine(x); };
            x = 1;
            calculateResult(x);

        }

        private void AnonFunc()
        {
            Func<int, int> func = x => x * x;
            Console.WriteLine(func(2));
        }
        private void AnonAction()
        {
            Action<int> action = x => { Console.WriteLine(x * x); };
            action(4);
            Action<int, int> action1 = (x, y) => { Console.WriteLine(x * y); };
            action1(2, 3);

        }
        private void AnonSelect()
        {
            int[] ints = { 1, 2, 3 };
            var squarednumbers = ints.Select(x => x * x);
            Console.WriteLine(string.Join(" , ", squarednumbers));
        }
        delegate void Action();
        private void MyClosure()
        {
            int x = 0;
            Action a = delegate { Console.WriteLine(x); };
            x = 1;
            a();
        }
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        private void MyPredicate()
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);

        }
        private void MyPredicate1()
        {
            int number = 4;
            Predicate<int> isEven = (int a) => number % 2 == 0;
            Console.WriteLine($"Is {number} even: {isEven(number)}" );

        }

        private void MyEvent()
        {
            var account1 = new AccountManagement();
            var person = new Person(account1) { Name = "John Doe" };
            account1.Winthdraw(person);
            var account2 = new AccountManagement();
            var person2 = new Person(account2) { Name = "Justin Phillip" };
            account2.Winthdraw(person2);
            Console.ReadLine();

        }



    }




    public class Person
    {
        public string Name { get; set; }
        private AccountManagement _account;
        public Person(AccountManagement account)
        {
            _account = account;
            account.Deposithandler += account.DeductMoney; //Subscribe to Deduct Money Event
        }
    }

    public class AccountManagement
    {
        public delegate void DepositHandler(object sender, string eventArgs);
        public event DepositHandler Deposithandler ;

        public void DeductMoney(object sender, string eventArgs)
        {
            Console.WriteLine(eventArgs + ": Money has been deducted from your account\n");
        }

        public void Winthdraw(Person person)
        {
            Console.WriteLine(person.Name + ": You withdraw money");
            Deposithandler(this, person.Name);
        }
    }

}
