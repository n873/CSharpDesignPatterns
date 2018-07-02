using Xunit;

namespace CSharpDesignPatterns.Creational.Singleton
{
    public class SingletonTest
    {
        [Fact]
        public void PolicyInsuredName_Test() {
            var insuredName = Policy.Instance.GetInsuredName();

            Assert.Equal("Nathan Alard", insuredName);
        }

        [Fact]
        public void IsPolicyASingleton_Test() {
            Assert.Same(Policy.Instance, Policy.Instance);
        }
    }
}
