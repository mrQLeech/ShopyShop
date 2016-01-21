using System;
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
        public string EMail { get; set; }

        public uint Version { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<AccessGroup> GROUPS { get; set; }
    }
}