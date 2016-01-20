using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class AccessGroup
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public bool IsCanEditProducts { get; set; }
        
    }
}