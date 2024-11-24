using System;

namespace PaymentSystems
{
    public class Order
    {
        public Order(int id, int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(amount.ToString());

            Id = id;
            Amount = amount;
        }

        public int Id { get; }

        public int Amount { get; }
    }
}
