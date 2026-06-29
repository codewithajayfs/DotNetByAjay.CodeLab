namespace DesignPattern.Creational.Singleton.WithoutSingleton
{
    public class Singleton
    {
        private static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value is - {counter.ToString()}");
        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}