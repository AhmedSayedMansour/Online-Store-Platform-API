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
            user.defaultType();
            if (myContext.addUser(new User(user)) == -1) return BadRequest("this email already rejestered or Invalid email");
            return Ok();
        }

        public IHttpActionResult Login(string email, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            UserContext myContext = new UserContext();
            UserDTO user = myContext.getUserByEmailPassword(email, password);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

    }
}