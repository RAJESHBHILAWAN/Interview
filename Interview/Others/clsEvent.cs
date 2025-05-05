using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class clsEvent
    {

        public clsEvent()
        {
            AccountMgt a = new AccountMgt();
            Person p = new Person(a) { Name = "Shesh", Amount = 5000 };
            a.DeductAmount(p);

            AccountMgt a1 = new AccountMgt();
            Person p1 = new Person(a1) { Name = "Anurag", Amount = 50020 };
            a1.DeductAmount(p1);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public double Amount { get; set; }

        private AccountMgt _accnt;

        public Person(AccountMgt accnt)
        {
            _accnt = accnt;
            _accnt.WithrawlEvent += accnt.Withraw;
        }

    }

    public class AccountMgt
    {
        public delegate void WithdrawHandler(object sender, string EventArgs);
        public event WithdrawHandler WithrawlEvent;

        public void Withraw(object sender, string EventArgs)
        {
            Console.WriteLine($"Withdrawl initiated by { EventArgs }");
        }

        public void DeductAmount(Person person)
        {
            Console.WriteLine($"An amount of { person.Amount  } was deducted from account of { person.Name }");
            WithrawlEvent(this, person.Name);
        }

    }

}
