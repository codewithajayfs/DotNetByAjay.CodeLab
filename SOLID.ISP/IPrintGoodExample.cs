namespace SOLID.ISP
{
    public interface IPrinter
    {
        bool Print(string content);
        
        bool PhotoCopy(string content);
    }
    public interface IScanner
    {
        bool Scan(string content);
    }
    public interface IFax
    {
        bool Fax(string content);
    }
    public interface IPrintDuplex
    {
        bool PrintDuplex(string content);
    }
}
