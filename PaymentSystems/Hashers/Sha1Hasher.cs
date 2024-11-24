using System.Security.Cryptography;

namespace PaymentSystems
{
    public class Sha1Hasher : BasicHasher, IHasher
    {
        public string GetHash(string text)
        {
            SHA1 sha1 = SHA1.Create();

            string hash = GetHash(sha1, text);

            sha1.Dispose();

            return hash;
        }
    }
}
