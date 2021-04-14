using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthenticationService.Models
{
    public class AuthContext : DbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
    }
}