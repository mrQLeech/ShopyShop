using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class ProductImage: BaseEntity
    {
        
        public uint ProductId  { get; set; }
        public int PersonBusinessEntityID { get; set; }
        public byte[] Photo { get; set; }
        public string LargePhotoFile { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool PrimaryPhoto { get; set; }
        public System.Guid rowguid { get; set; }

        public virtual Product Product { get; set; }
    }
}