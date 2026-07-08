using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP.Client
{
    public class HPLaserJet : IPrintTask
    {
        public bool Fax(string content)
        {
            Console.WriteLine("Fax done");
            return true;
        }

        public bool PhotoCopy(string content)
        {
            Console.WriteLine("PhotoCopy done");
            return true;
        }

        public bool Print(string content)
        {
            Console.WriteLine("Print done");
            return true;
        }

        public bool PrintDuplex(string content)
        {
            throw new NotImplementedException();
        }

        public bool Scan(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
    }
}
