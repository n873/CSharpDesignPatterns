namespace CSharpDesignPatterns.Creational.FactoryMethod
{
    // Concrete Product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
}
