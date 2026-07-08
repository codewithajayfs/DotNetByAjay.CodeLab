namespace SOLID.ISP.Client
{
    /// <summary>
    /// EPSON L3100 - Does not support Fax, so here ISP is violating
    /// </summary>
    public class EPSONL3100 : IPrintTask
    {
        public bool Fax(string content)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException("Printer does not support.");
        }

        public bool Scan(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
    }
}
