using OnlineStorePlatform.DBContext;
using OnlineStorePlatform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStorePlatform.Controllers
{
    public class AdminController : Controller
    {
        public UserContext myContext;
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult getAllUsers()
        {
            myContext = new UserContext();
            return View(myContext.getAllUsers());
        }
    }
}