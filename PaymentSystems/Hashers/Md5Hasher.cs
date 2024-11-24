using System.Security.Cryptography;

namespace PaymentSystems
{
    public class Md5Hasher : BasicHasher, IHasher
    {
        public string GetHash(string text)
        {
            MD5 md5 = MD5.Create();

            string hash = GetHash(md5, text);

            md5.Dispose();

            return hash;
        }
    }
}
