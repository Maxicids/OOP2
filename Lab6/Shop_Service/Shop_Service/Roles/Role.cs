using System.Runtime.Serialization;

namespace Shop_Service.Roles
{
    [DataContract]
    [KnownType(typeof(Admin))]
    [KnownType(typeof(User))]
    public abstract class Role
    {
        [DataMember(Name = "Login")]
        protected string login;
        [DataMember(Name = "Password")]
        protected string password;

        public string Login => login.GetHashCode().ToString();

        public string Password => password.GetHashCode().ToString();

        public bool VerifyRole(string lg, string pw)
        {
            return Password.Equals(pw) && Login.Equals(lg);
        }
    }
}