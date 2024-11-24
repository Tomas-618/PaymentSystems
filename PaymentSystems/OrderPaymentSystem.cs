using System;

namespace PaymentSystems
{
    public class OrderPaymentSystem : IPaymentSystem
    {
        private readonly IHasher _hasher;

        public OrderPaymentSystem(IHasher hasher) =>
            _hasher = hasher ?? throw new ArgumentNullException(nameof(hasher));

        public string GetPayingLink(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            string hash = _hasher.GetHash(order.Id.ToString() + order.Amount);

            return $"order.system2.ru/pay?hash={hash}";
        }
    }
}
