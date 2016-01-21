using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class Product
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public virtual Manufacturer Maker { get; set; }
        public string BarCode { get; set; }
        public double Price { get; set; }
        public virtual Discount DiscountObj { get; set; }
        public virtual List<ProductImage> Images { get; set; }
    }
}