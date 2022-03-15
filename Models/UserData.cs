using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SysInfo_UserManagement.Models
{
    public class UserData
    {
        static private List<User> Users = new List<User>();

        public static List<User> GetAll()
        {
            return Users;
        }

        public static User GetById(int userId)
        {
            return Users.Single(x => x.UserId == userId);
        }

        public static void Add(User newUser)
        {
            Users.Add(newUser);
        }

        public static bool Remove(int userId)
        {
            return Users.Remove(GetById(userId));
        }
    }
}
