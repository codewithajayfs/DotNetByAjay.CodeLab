namespace DesignPattern.Creational.Singleton.LazyLoading
{
    /// <summary>
    /// Lazy Initialization: Creates the object only when needed (first use).
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(()=> new Singleton());
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value is - " + counter);
        }
        public static Singleton GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}