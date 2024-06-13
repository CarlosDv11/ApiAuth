using ApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuth.Repositories
    {
        public class UserRepository
        {
            public static User Get(string username, string password)
            {
                var users = new List<User>();
                users.Add(new User { Id = 1, Username = "adm", Password = "admin", Role = "manager" });
                users.Add(new User { Id = 2, Username = "user", Password = "123", Role = "employee" });
                return users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);

            }
    }
    }


