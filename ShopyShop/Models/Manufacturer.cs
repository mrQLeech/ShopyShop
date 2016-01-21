using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class Manufacturer: BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        ///  Юридический адресс
        /// </summary>
        public string PostAdress { get; set; }

        public string TaxId { get; set; }
        public uint Version { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}