using OnlineStorePlatform.DBContext;
using OnlineStorePlatform.DTO;
using OnlineStorePlatform.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;

namespace OnlineStorePlatform.Controllers
{
    public class AdminController : ApiController
    {
        // GET: Admin
        [Authorize(Roles = "Admin")]
        public IHttpActionResult getAllUsers()
        {
            UserContext myContext = new UserContext();
            IEnumerable<UserDTO> users = myContext.getAllUsers();
            if(users.Cast<UserDTO>().Count() == 0)
                return NotFound();
            else
                return Ok(users);
        }
    }
}