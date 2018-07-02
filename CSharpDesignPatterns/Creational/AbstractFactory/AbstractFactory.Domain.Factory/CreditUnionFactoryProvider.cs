using CSharpDesignPatterns.Common.Domain.Constant;

namespace CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Factory
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNumber)
        {
            if (accountNumber.Contains(AccountType.Citi)) { return new CitiCreditUnionFactory(); }
            else
            if (accountNumber.Contains(AccountType.National)) { return new NationalCreditUnionFactory(); }
            else
                return null;
        }
    }
}
