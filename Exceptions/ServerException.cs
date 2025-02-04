namespace SchoolApp.Exceptions
{
    public class ServerException : AppException
    {
        private static readonly string DEFAULT_CODE = "AlreadyExists";

        public ServerException(string code, string message) : base(code, message)
        {
        }
    }
}
