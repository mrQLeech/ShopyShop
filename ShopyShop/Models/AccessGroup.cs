using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class AccessGroup: BaseEntity
    {
        public string Name { get; set; }
      
        public bool IsCanEditProducts { get; set; }

        public virtual List<LocalUser> Users { get; set; }

        
        public virtual ICollection<AccessGroup> AccessGroups { get; set; }

        public AccessGroup()
        {
            this.AccessGroups = new HashSet<AccessGroup>();
        }
        
    }
}