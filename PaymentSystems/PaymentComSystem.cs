using System;

namespace PaymentSystems
{
    public class PaymentComSystem : IPaymentSystem
    {
        private readonly IHasher _hasher;
        private readonly int _secretKey;

        public PaymentComSystem(IHasher hasher, int secretKey)
        {
            _hasher = hasher ?? throw new ArgumentNullException(nameof(hasher));
            _secretKey = secretKey;
        }

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            string hash = _hasher.GetHash(order.Amount.ToString() + order.Id + _secretKey);

            return $"system3.com/pay?amount={order.Amount}" +
                $"&curency=RUB&hash={hash}";
        }
    }
}
