using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SysInfo_UserManagement.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        private static int nextId = 1;

        public User(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }

        public User()
        {
            UserId = nextId;
            nextId++;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return UserId == (obj as User).UserId;
        }

        public override int GetHashCode()
        {
            return UserId;
        }
    }
}
