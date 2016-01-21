using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class Discount
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int DiscountValue { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}