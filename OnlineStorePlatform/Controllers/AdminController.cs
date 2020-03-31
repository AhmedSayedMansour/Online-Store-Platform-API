using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStorePlatform.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminView()
        {
            return View();
        }
        public ActionResult ListAllUsers()
        {
            var context = new ApplicationDbContext();
       
            return View(context.Users.ToList());
        }
    }
}