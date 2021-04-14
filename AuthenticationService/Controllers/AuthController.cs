using AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthenticationService.Controllers
{
    public class AuthController : ApiController
    {
        public IHttpActionResult Get()
        {
            AuthContext db = new AuthContext();
            return Ok(db.Users.ToList());
            
        }

        public IHttpActionResult Post([FromUri] string Username, [FromBody] string Password)
        {
            AuthContext db = new AuthContext();
            ApplicationUser user = db.Users.FirstOrDefault(s => s.Username == Username && s.Password == Password);
            if (user != null)
                return Ok();
            else
                return NotFound();

        }
    }
}
