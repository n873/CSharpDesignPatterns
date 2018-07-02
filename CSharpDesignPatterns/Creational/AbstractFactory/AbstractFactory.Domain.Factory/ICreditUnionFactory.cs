using CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Model;

namespace CSharpDesignPatterns.Creational.AbstractFactory.AbstractFactory.Domain.Factory
{
    //Abstract Factory
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }
}
