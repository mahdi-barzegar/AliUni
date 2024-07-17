using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliUni.Data.Entities.Users
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserFNameLName { get; set; }

        public string? Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public DateTime RegiterDate { get; set; } = DateTime.Now;

        public string ActivationCodeForPhoneNumber { get; set; }

        public string? ActivationCodeForEmail { get; set; }

        public string UserAvatar { get; set; }

        public bool IsUserActive { get; set; } = false;




        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
