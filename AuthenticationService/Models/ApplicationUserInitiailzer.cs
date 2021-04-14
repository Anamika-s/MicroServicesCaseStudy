using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthenticationService.Models
{
    public class ApplicationUserInitiailzer : DropCreateDatabaseIfModelChanges<AuthContext>
    {
        protected override void Seed(AuthContext context)

        {
            var users = new List<ApplicationUser>
            {
                new ApplicationUser() { UserId=1, Username="user1" , Password="user1"},

                new ApplicationUser() { UserId=2, Username="user2" , Password="user2"},

                new ApplicationUser() { UserId=3, Username="user3" , Password="user3"},

                new ApplicationUser() { UserId=4, Username="user4" , Password="user4"},
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

        }

    }

}