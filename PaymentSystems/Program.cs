using System;

namespace PaymentSystems
{
    internal class Program
    {
        private static void Main()
        {
            IHasher hasher = new Md5Hasher();

            IPaymentSystem payment1 = new PayPaymentSystem(hasher);
            IPaymentSystem payment2 = new OrderPaymentSystem(hasher);
            IPaymentSystem payment3 = new PaymentComSystem(new Sha1Hasher(), 11232);

            Order order = new Order(1211, 12000);

            Console.WriteLine(payment1.GetPayingLink(order));
            Console.WriteLine(payment2.GetPayingLink(order));
            Console.WriteLine(payment3.GetPayingLink(order));
        }
    }
}
