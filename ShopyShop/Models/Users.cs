﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class Users
    {
        public uint Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMAIL { get; set; }
        public AccessGroup GROUP { get; set; }
    }
}