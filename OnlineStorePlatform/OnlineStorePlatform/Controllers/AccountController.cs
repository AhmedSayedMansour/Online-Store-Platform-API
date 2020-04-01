using OnlineStorePlatform.DTO;
using OnlineStorePlatform.Models;
using OnlineStorePlatform.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net.Http;
using System.Net;

namespace OnlineStorePlatform.Controllers
{
    public class AccountController : ApiController
    {
        // GET: Account
        public IHttpActionResult Index()
        {
            return Ok();
        }
        [System.Web.Http.Route("api/Account/Register")]
        public IHttpActionResult Register([FromBody] UserDTO user)
        {
            var myContext = new UserContext();
            if (myContext.addUser(new User(user)) == null) return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed"));
            return Ok();
        }
    }
}