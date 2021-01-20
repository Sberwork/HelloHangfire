namespace HangfireWebAPIv2.Helpers
{
    public class DbContext
    {
        public string GetUserName(string email)
        {
            return "UserName";
        }

        public bool AddUser(string userName, string email, string password)
        {
            return true;
        }
    }
}