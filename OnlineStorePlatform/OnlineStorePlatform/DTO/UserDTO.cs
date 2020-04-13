using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.DTO
{
    public class UserDTO
    {
        //public String email, userName, password, type;
        public String email { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public String type { get; set; }
        public UserDTO(String email, String password, String userName, String type)
        {
            this.email = email;
            this.password = password;
            this.userName = userName;
            this.type = type;
        }
        public UserDTO() { }

        public void defaultType()
        {
            this.type = "Customer";
        }
    }
}