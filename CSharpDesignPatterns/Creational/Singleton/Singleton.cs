namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// Ensures a class has only one instance, and provides a 
    /// global point of access to it.
    /// 
    /// Eliminates the option of instantiating more than one of 
    /// the same object.
    /// </summary>
    public class Policy
    {
        //private static readonly object _lock = new object();

        private static readonly Policy _instance = new Policy();
        public static Policy Instance
        {
            get
            {
                return _instance;
            }
        }

        public Policy()
        {

        }
        private int Id { get; set; } = 123;
        public string Insured { get; set; } = "Nathan Alard";

        public string GetInsuredName() => Insured;
    }
}
