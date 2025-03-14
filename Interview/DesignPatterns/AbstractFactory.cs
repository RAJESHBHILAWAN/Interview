using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.DesignPatterns
{
    public class AbstractFactory
    {
        
      public AbstractFactory() {
            PhoneTypeChecker phoneTypeChecker;
            phoneTypeChecker = new PhoneTypeChecker();
            phoneTypeChecker.CheckPhones(PhoneTypes.Samsung);
            phoneTypeChecker.CheckPhones(PhoneTypes.HTC);


        }

    }

    public interface ISmart
    {
        public string GetName();
    }
    public interface IDumb
    {
        public string GetName();
    }

    public interface IPhoneFactory
    {
        public IDumb DumbPhone();
        public ISmart SmartPhone();
    }

    public class Nokia : ISmart
    {
        public string GetName()
        {
            return "Nokia Smart Phone";
        }
    }

    public class Asha : IDumb
    {
        public string GetName()
        {
            return "Asha Dumb Phone";
        }
    }


    public class Titan : ISmart
    {
        public string GetName()
        {
            return "Titan Smart Phone";
        }
    }

    public class Genie : IDumb
    {
        public string GetName()
        {
            return "Genie Dumb Phone";
        }
    }



    public class SamsungFactory : IPhoneFactory
    {
        public IDumb DumbPhone()
        {
            return new Asha() ;
        }

        public ISmart SmartPhone()
        {
             return new Nokia() ;
        }
    }


    public class HTCFactory : IPhoneFactory
    {
        public IDumb DumbPhone()
        {
            return new Genie();
        }

        public ISmart SmartPhone()
        {
            return new Titan();
        }
    }
    public enum PhoneTypes { Nokia, Samsung, HTC }

    public class PhoneTypeChecker
    {
        public void CheckPhones(PhoneTypes phoneTypes)
        {
            IPhoneFactory phoneFactory = null;
            switch (phoneTypes)
            {
                case PhoneTypes.Nokia:
                    phoneFactory = new SamsungFactory();
                    break;
                case PhoneTypes.HTC:
                    phoneFactory = new HTCFactory();
                    break;
                default:
                    phoneFactory = new SamsungFactory();
                    break;
            }

            Console.WriteLine($"Smart Phone {phoneFactory.SmartPhone().GetName() } and Dumb phone is {phoneFactory.DumbPhone().GetName()}");
        }


    }

}
