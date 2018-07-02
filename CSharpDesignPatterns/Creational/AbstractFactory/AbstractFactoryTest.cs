using CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Factory;
using CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Model;
using System.Collections.Generic;
using Xunit;

namespace CSharpDesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryTest
    {
        private readonly List<string> accounts;
        private ICreditUnionFactory abstractFactory;

        private readonly ILoanAccount loanAccount;
        private readonly ISavingsAccount savingsAccount;

        public AbstractFactoryTest()
        {
            accounts = new List<string> {
                "CITI-456",
                "NATIONAL-987",
                "CHASE-222"
            };
        }

        [Fact]
        public void NationaLoanAccount_Test() {
            abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accounts[1]);
            var loanAccount = abstractFactory.CreateLoanAccount();

            var expected = typeof(NationalLoanAccount);
            Assert.IsType(expected, loanAccount);
        }

        [Fact]
        public void NationaSavingsAccount_Test()
        {
            abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accounts[1]);
            var savingsAccount = abstractFactory.CreateSavingsAccount();

            var expected = typeof(NationalSavingsAccount);
            Assert.IsType(expected, savingsAccount);
        }

        [Fact]
        public void CitiLoanAccount_Test()
        {
            abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accounts[0]);
            var loanAccount = abstractFactory.CreateLoanAccount();

            var expected = typeof(CitiLoanAccount);
            Assert.IsType(expected, loanAccount);
        }

        [Fact]
        public void CitiSavingsAccount_Test()
        {
            abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accounts[0]);
            var savingsAccount = abstractFactory.CreateSavingsAccount();

            var expected = typeof(CitiSavingsAccount);
            Assert.IsType(expected, savingsAccount);
        }

        [Fact]
        public void InvalidAccount_Test()
        {
            abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accounts[2]);
            
            Assert.Null(abstractFactory);
        }
    }
}
