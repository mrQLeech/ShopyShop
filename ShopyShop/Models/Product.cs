using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class Product : BaseEntity
    {       
        public string Name { get; set; }
        public Guid MakerId { get; set; }
        public Guid DiscountId { get; set; }
        public string BarCode { get; set; }
        public double Price { get; set; }

        public virtual Manufacturer Maker { get; set; }
        public virtual Discount Discount { get; set; }
        
        public virtual List<ProductImage> Images { get; set; }
    }
}