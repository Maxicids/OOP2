using System;

namespace Shop_Service.Roles
{
    [Serializable]
    public class User : Role
    {
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        private User()
        {
            
        }
    }
}