using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem_ASP.NET.Data.Models
{
    public class Category : MainModel
    {
        public Category() {
            this.Products = new HashSet<Product>();
        }

        [Required]
        public string Name {get;set;}

        public ICollection<Product> Products { get;set;}

       

    }
}
