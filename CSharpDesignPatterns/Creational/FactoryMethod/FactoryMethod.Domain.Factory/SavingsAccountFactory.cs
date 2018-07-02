using CSharpDesignPatterns.Common.Domain.Constant;
using System;

namespace CSharpDesignPatterns.Creational.FactoryMethod
{
    // Concrete Creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string accountNumber)
        {
            if (accountNumber.Contains(AccountType.Citi)) { return new CitiSavingsAccount(); }
            else
            if (accountNumber.Contains(AccountType.National)) { return new NationalSavingsAccount(); }
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
