using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Login
    {

        public static User login(string username,string password)
        {
            string u = "admin", s = "1";
            User user = new User();
            //veritanaına bağlandım
            if (u== username && s==password)
            {
                user.UserID = "12";
                user.UserName = "tarık davulcu";
            }
            return user;        
        }
    }
}