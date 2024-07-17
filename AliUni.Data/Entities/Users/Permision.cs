using AliUni.Data.Entities.Users.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliUni.Data.Entities.Users
{
    public class Permision
    {
        [Key]
        public int PermisionId { get; set; }

        public string PermisionName { get; set; }

        public List<RolePermisionconnection> RolePermisionconnections { get; set; }
    }
}
