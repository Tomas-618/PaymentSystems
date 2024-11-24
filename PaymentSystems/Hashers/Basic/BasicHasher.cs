using System;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystems
{
    public abstract class BasicHasher
    {
        protected string GetHash(HashAlgorithm hashAlgorithm, string text)
        {
            if (hashAlgorithm == null)
                throw new ArgumentNullException(nameof(hashAlgorithm));

            if (text == null)
                throw new ArgumentNullException(nameof(text));

            byte[] hash = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(text));

            return Convert.ToBase64String(hash);
        }
    }
}
