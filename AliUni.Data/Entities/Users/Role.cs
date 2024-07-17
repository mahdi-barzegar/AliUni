using AliUni.Data.Entities.Users.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliUni.Data.Entities.Users
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public List<RolePermisionconnection> RolePermisionconnections { get; set; }
        public List<User> Users { get; set; }
    }
}
