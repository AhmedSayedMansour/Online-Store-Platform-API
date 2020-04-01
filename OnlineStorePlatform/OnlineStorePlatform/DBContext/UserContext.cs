using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.DBContext
{
    public class UserContext
    {
        public int? addUser(User user)
        {
            var context = ApplicationDbContext.Create();
            context.Users.Add(user);
            if (context.SaveChanges() == 0)
            {
                context.Dispose();
                return null;
            }
            context.Dispose();
            return user.Id;
        }
    }
}