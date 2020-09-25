using System;

namespace ConsoleApp
{
    class User
    {
        private int _userID;
        private string _userName;
        private string _password;
        private int _floor;

        /*
         * Properties Definition
         */
        public int UserID
        {
            get { return _userID; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Floor
        {
            get { return _floor; }
        }
        
        
        /*
         * Method : Login()
         * Input Parameters : UserName and Password
         * Output Parameter : Boolean value : Returns True if the Username and Passoword Matched 
         * else it returns False
         */
        public Boolean Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
            if (userName == "Smith" & password == "js")
            {
                _userID = 1;
                _floor = 2;
                return true;
            }
            else if (userName == "Jones" & password == "mj")
            {
                _userID = 2;
                _floor = 4;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * User Object calls Login Method
         */
        static void Main(string[] args)
        {
            User objUser = new User();
            objUser.Login("Smith", "js");
        }
    }
}
