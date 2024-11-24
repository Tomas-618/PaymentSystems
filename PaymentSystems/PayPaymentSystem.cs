using System;

namespace PaymentSystems
{
    public class PayPaymentSystem : IPaymentSystem
    {
        private readonly IHasher _hasher;

        public PayPaymentSystem(IHasher hasher) =>
            _hasher = hasher ?? throw new ArgumentNullException(nameof(hasher));

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            string hash = _hasher.GetHash(order.Id.ToString());

            return $"pay.system1.ru/order?amount" +
            $"={order.Amount}RUB&hash={hash}";
        }
    }
}
