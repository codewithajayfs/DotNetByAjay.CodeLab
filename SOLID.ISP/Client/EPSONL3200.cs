namespace SOLID.ISP.Client
{
    public class BasicPrinter : IPrinter
    {
        public bool PhotoCopy(string content)
        {
            Console.WriteLine("Photocopy done");
            return true;
        }

        public bool Print(string content)
        {
            Console.WriteLine("Print done");
            return true;
        }
    }

    public class EPSONL3200 : IPrinter, IScanner, IFax
    {
        public bool PhotoCopy(string content)
        {
            Console.WriteLine("Photocopy done");
            return true;
        }

        public bool Print(string content)
        {
            Console.WriteLine("Print done");
            return true;
        }

        public bool Scan(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }

        public bool Fax(string content)
        {
            Console.WriteLine("Fax done");
            return true;
        }
    }
}
