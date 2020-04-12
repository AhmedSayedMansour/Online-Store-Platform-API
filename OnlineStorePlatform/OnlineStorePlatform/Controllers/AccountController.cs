using OnlineStorePlatform.DBContext;
using OnlineStorePlatform.DTO;
using OnlineStorePlatform.Models;
using System.Web.Http;

namespace OnlineStorePlatform.Controllers
{
    public class AccountController : ApiController
    {
        public AccountController()
        {
        }
        
        public IHttpActionResult Register([FromBody]UserDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            UserContext myContext = new UserContext();
            if (myContext.addUser(new User(user)) == -1) return BadRequest("this email already rejestered..");
            return Ok();
        }

    }
}