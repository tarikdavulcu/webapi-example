﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class User
    {
        public string UserID { get; set; }
        public  string UserName { get; set; }
        public static List<User> list = new List<User>();
    }
}