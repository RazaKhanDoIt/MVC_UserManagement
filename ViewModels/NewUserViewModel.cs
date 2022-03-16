using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SysInfo_UserManagement.ViewModels
{
    public class NewUserViewModel
    {
        [Required]
        [MinLength(4)]
        public string Username { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
