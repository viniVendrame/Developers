using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class DevContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DevContext() : base("Data Source=192.168.0.117;Initial Catalog=Developers;Persist Security Info=True;User ID=Developers;Password=@devlabs1")
        {

        }
    }
}
