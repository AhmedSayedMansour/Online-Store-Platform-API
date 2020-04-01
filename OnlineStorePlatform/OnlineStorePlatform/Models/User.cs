using OnlineStorePlatform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
    public class User
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Index(IsUnique = true), StringLength(256)]
        public String email { get; set; }

        public String password { get; set; }
        public String userName { get; set; }
        public String type { get; set; }

        public User(UserDTO user)
        {
            this.email = user.email;
            this.password = user.password;
            this.userName = user.userName;
            this.type = "Customer";
        }
    }

}