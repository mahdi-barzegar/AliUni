using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliUni.Data.Entities.Users.Connections
{
    public class RolePermisionconnection
    {
        [Key]
        public int RPCId { get; set; }

        public int RoleId { get; set; }

        public int PermisionId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [ForeignKey("PermisionId")]
        public Permision Permision { get; set; }

    }
}
