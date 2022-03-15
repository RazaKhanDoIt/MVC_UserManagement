using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SysInfo_UserManagement.Models;


namespace MVC_SysInfo_UserManagement.ViewModels
{
    public class UserListViewModel
    {
        public string Title { get; set; } = "All Users";
        public List<User> Users { get; set; }


    }
}
