using OnlineStorePlatform.DBContext;
using OnlineStorePlatform.DTO;
using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStorePlatform.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(String email, String password, String userName)
        {
            UserDTO user = new UserDTO(email, password, userName);
            var myContext = new UserContext();
            if (myContext.addUser(new User(user)) == null) return Content("ERROR");
            return Content("Created Successfully");
        }
    }
}