namespace SOLID.ISP
{
    public interface IPrintTask
    {
        bool Print(string content);
        bool Scan(string content);
        bool Fax(string content);
        bool PhotoCopy(string content);
        bool PrintDuplex(string content);
    }
}
