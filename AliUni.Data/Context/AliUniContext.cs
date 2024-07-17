using AliUni.Data.Entities.Users;
using AliUni.Data.Entities.Users.Connections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliUni.Data.Context
{
    public class AliUniContext : DbContext
    {
        public AliUniContext(DbContextOptions<AliUniContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Permision> Permisions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermisionconnection> RolePermisionconnections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId = 1,RoleName = "Admin"},
                new Role() { RoleId = 2,RoleName = "Student"},
                new Role() { RoleId = 3,RoleName = "Teacher"}
                );
            modelBuilder.Entity<Permision>().HasData(
                new Permision() { PermisionId=1,PermisionName="Admin Panel"},
                new Permision() { PermisionId = 2,PermisionName="Student Panel"},
                new Permision() { PermisionId = 3, PermisionName="Manage Students"}
                );
            modelBuilder.Entity<RolePermisionconnection>().HasData(
                new RolePermisionconnection() { RPCId=1,RoleId=1,PermisionId=1},
                new RolePermisionconnection() { RPCId=2,RoleId=1,PermisionId=2},
                new RolePermisionconnection() { RPCId=3,RoleId=1,PermisionId=3},
                new RolePermisionconnection() { RPCId=4,RoleId=3,PermisionId=3},
                new RolePermisionconnection() { RPCId=5,RoleId=2,PermisionId=2}
                );
        }

    }
}
