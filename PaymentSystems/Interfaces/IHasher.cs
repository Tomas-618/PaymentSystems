namespace PaymentSystems
{
    public interface IHasher
    {
        string GetHash(string text);
    }
}
