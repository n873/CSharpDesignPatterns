namespace CSharpDesignPatterns.Creational.FactoryMethod
{
    // Concrete Product
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }
}
