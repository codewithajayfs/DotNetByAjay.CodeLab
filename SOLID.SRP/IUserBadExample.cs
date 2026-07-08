namespace SOLID.SRP
{
    internal interface IUserBadExample
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        void LogError(string error);
        bool SendEmail(string emailContent);
    }
}
