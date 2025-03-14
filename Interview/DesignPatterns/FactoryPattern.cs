using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.DesignPatterns
{
    internal class FactoryPattern
    {
        public FactoryPattern() {
        Product product = new Product();
           PaymentProcessor processor = new PaymentProcessor();
            product.Name = "Saving Account";
            product.Balance = 10000;
            processor.ProcessPayment(BankType.BankOne, product);
            product.Name = "Insurance";
            product.Balance = 10000;
            processor.ProcessPayment(BankType.BankTwo, product);

            product.Name = "RD";
            product.Balance = 10;
            processor.ProcessPayment(BankType.BankAny, product);


            product.Name = "Saving Account";
            product.Balance = 1000000;
            processor.ProcessPayment(BankType.BankAny, product);




        }
    }

    public class Product
    {
        public decimal Balance { get; set; }
        public string Name { get; set; }
    }

    public enum BankType { BankOne, BankTwo, BankAny }

    public interface IPaymentGateway
    {
        public void MakePayment(Product product);
    }

    public class Bank1 : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Made payment thru Bank one for Account : {product.Name} and transaction amount of {product.Balance}");
        }
    }

    public class Bank2 : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            Console.WriteLine($"Made payment thru Bank two for Account : {product.Name} and transaction amount of {product.Balance}");
        }
    }

    public class PaymentGateway
    {
        public IPaymentGateway GetGateway(Product product, BankType bankType)
        {
            IPaymentGateway gateway = null;
            switch (bankType)
            {
                case BankType.BankOne:
                    gateway = new Bank1();
                    break;
                case BankType.BankTwo:
                    gateway = new Bank2();
                    break;
                case BankType.BankAny:
                    if (product.Balance > 50000)
                    {
                        gateway = new Bank1();
                    }
                    else { gateway = new Bank2(); }
                    break;

            }
            return gateway;
        }


    }


    public class PaymentProcessor
    {
        public void ProcessPayment(BankType bankType, Product product)
        {
            IPaymentGateway gateway;
            PaymentGateway paymentGateway=new PaymentGateway();
            gateway = paymentGateway.GetGateway(product, bankType);
            gateway.MakePayment(product);
        }
    }



}