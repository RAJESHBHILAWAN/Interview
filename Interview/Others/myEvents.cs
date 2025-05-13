using InterviewPrep.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class myEvents
    {
        public myEvents() {
            MyEvent();
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
        public event DepositHandler Deposithandler;

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
