namespace DesignPattern.Creational.Singleton.EagerLoading
{
    /// <summary>
    /// Eager Initialization: Creates the object immediately at class load time.
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;

        //readonly why?- The Singleton instance is created when the class is loaded, regardless of whether it is used.
        private static readonly Singleton _instance = new Singleton();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value is - " + counter);
        }
        public static Singleton GetInstance
        {
            get
            {
                return _instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}