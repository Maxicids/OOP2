using System;

namespace Shop_Service.Roles
{
    [Serializable]
    public class Admin : Role
    {
        public Admin(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        private Admin()
        {
            
        }
    }
}