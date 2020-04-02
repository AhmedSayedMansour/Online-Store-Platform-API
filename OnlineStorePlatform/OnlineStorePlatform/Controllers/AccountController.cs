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
        public UserDTO user;
        public UserContext myContext;
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(String email, String password, String userName)
        {
            user = new UserDTO(email, password, userName);
            myContext = new UserContext();
            if (myContext.addUser(new User(user)) == null) return Content("ERROR");
            return Content("Created Successfully");
        }
    }
}