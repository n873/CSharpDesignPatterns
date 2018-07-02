namespace CSharpDesignPatterns.Creational.FactoryMethod
{
    // Creator
    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string accountNumber);
    }
}
