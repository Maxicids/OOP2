using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;


namespace Shop_Service.Roles
{
    public class Users
    {
        private static Users instance;
        private readonly List<Role> roles;
        private readonly DataContractJsonSerializer jsonSerializer;
        private const string JsonPath = "JsonUsers.json";

        private Users()
        {
            roles = new List<Role>();
            jsonSerializer = new DataContractJsonSerializer(typeof(List<Role>));
        }
        
        public static Users GetInstance()
        {
            if (instance != null) return instance;
            
            instance = new Users();
            instance.Deserialize();
            return instance;
        }

        public void Add(Role user)
        {
            roles.Add(user);
        }

        public Role Find(string login)
        {
            return roles.FirstOrDefault(role => role.ToString() == login);
        }
        public void Remove(Role user)
        {
            roles.Remove(user);
        }

        public Role GetActive()
        {
            return roles.FirstOrDefault(role => role.IsActive);
        }
        public bool VerifyUser(Role user)
        {
            return roles.Any(role => role.VerifyRole(user.Login, user.Password));
        }
        
        #region Serialization

        public void Serialize()
        {
            using var file = new FileStream(JsonPath, FileMode.OpenOrCreate);
            jsonSerializer.WriteObject(file, roles);
        }
        
        private void Deserialize()
        {
            var fileInfo = new FileInfo(JsonPath);
            if (!fileInfo.Exists) return;
            if (fileInfo.Length == 0) return;
            
            using var file = new FileStream(JsonPath, FileMode.OpenOrCreate);
            if (jsonSerializer.ReadObject(file) is not List<Role> deserializedRoles) return;
            foreach (var role in deserializedRoles)
            {
                roles.Add(role);
            }
        }
        #endregion
    }
}