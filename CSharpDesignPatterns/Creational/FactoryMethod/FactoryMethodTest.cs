using Xunit;

namespace CSharpDesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethodTest
    {
        private readonly ICreditUnionFactory factory;

        public FactoryMethodTest()
        {
            factory = new SavingsAccountFactory() as ICreditUnionFactory;

        }

        [Fact]
        public void CitiSavingsAccount5000_Test() {
            var citiAccount = factory.GetSavingsAccount("CITI-321");

            Assert.Equal(5000, citiAccount.Balance);
        }

        [Fact]
        public void NationalSavingsAccount2000_Test() {
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-987");

            Assert.Equal(2000, nationalAccount.Balance);
        }
    }
}
