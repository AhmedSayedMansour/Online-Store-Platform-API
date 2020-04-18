using OnlineStorePlatform.DTO;
using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.DBContext
{
    public class UserContext
    {
        public int addUser(User user)
        {
            ApplicationDbContext context = ApplicationDbContext.Create();
            context.addUser(user);
            try
            {
                if (context.SaveChanges() == 0)
                {
                    context.Dispose();
                    return -1;
                }
                context.Dispose();
                return user.Id;
            }
            catch
            {
                return -1;
            }
            
        }

        public IEnumerable<UserDTO> getAllUsers()
        {
            ApplicationDbContext context = ApplicationDbContext.Create();
            return context.listAllUsers();
        }

        public UserDTO getUserByEmailPassword(String email, String password)
        {
            ApplicationDbContext context = ApplicationDbContext.Create();

            return context.Users.Where(u => u.email.Equals(email) && u.password.Equals(password)).Select(a => new UserDTO()
            {
                email = a.email,
                userName = a.userName,
                password = a.password,
                type = a.type
            }).FirstOrDefault<UserDTO>();
            
        }
    }
}