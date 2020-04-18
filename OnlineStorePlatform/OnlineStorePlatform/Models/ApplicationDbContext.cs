using OnlineStorePlatform.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        public ApplicationDbContext() : base("OnlineStoreDB")
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }
        public DbSet<User> Users { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public void addUser(User user)
        {
            Users.Add(user);
        }
        public IEnumerable<UserDTO> listAllUsers()
        {
            return Users.Where(x => x.type.Equals("Customer")).ToList().Select(user => new UserDTO
            {
                email = user.email,
                password = user.password,
                userName = user.userName,
                type = user.type
            });
        }

    }
}