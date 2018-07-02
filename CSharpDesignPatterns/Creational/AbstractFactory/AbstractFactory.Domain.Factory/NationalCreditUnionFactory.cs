using CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Model;

namespace CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Factory
{
    // Concrete Factory 2
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var account = new NationalLoanAccount();
            return account;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var account = new NationalSavingsAccount();
            return account;
        }
    }
}
