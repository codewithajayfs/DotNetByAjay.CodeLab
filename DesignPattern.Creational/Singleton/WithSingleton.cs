namespace DesignPattern.Creational.Singleton.WithSingleton
{
    /// <summary>
    /// Why can't readonly be used with manual lazy instance creation?
    /// Because a readonly field can only be assigned during declaration or in a static constructor, 
    /// whereas manual lazy initialization assigns the instance later on first access.
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? _instance = null;
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value is - " + counter);
        }
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Uncomment code and remove sealed keyword from Singleton class
        /// Allowed here when class not sealed
        /// Not Allowed when sealed - 'Singleton.DriveSingleton': cannot derive from sealed type 'Singleton'
        /// </summary>
        // public class DriveSingleton : Singleton
        // {

        // }
    }

    /// <summary>
    /// Uncomment code and remove sealed keyword from Singleton class
    /// Not Allowed: 'Singleton.Singleton()' is inaccessible due to its protection level
    /// </summary>
    // public class DriveSingleton : Singleton
    // {

    // }
}
