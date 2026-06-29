using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPattern.Creational.Singleton.ThreadSafe
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? _instance = null;
        private static readonly object _lockObject = new object();
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
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}