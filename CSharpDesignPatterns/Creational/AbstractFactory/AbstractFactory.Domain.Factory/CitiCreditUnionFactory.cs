using CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Model;

namespace CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Factory
{
    // Concrete Factory 1
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var account = new CitiLoanAccount();
            return account;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var account = new CitiSavingsAccount();
            return account;
        }
    }
}
