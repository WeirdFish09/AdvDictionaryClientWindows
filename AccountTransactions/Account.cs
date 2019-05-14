namespace AccountTransactions
{
    public class Account
    {
        public string UserName { get; private set; }

        public string Token {get; private set;}
        public Account(string userName, string token)
        {
            UserName = userName;
            Token = token;
        }

    }
}