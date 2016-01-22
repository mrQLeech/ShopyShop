using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class ProductsDataBaseInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            base.Seed(context);

            var studentList = new List<Product>() 
            { 
                new Product(){ Name = "Ботинок левый"},
                new Product(){ Name = "Ботинок правый"},
                new Product(){ Name = "Ботинок средний"},
                new Product(){ Name = "Ботинок вялый" },
                new Product(){ Name = "Ботинок красный"},
                
            };
            studentList.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}