using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem_ASP.NET.Data.Models
{
    public class Product : MainModel
    {
        [Required]
        [MaxLength (60, ErrorMessage ="Max Length should not be more than 60 characters")]
        [MinLength (3, ErrorMessage ="Product name should be at lest 3 characters")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Max Length should not be more than 100 characters")]
        public string Description { get; set; }

        [Required]
        [Range(0, 999999, ErrorMessage ="Cannot be less than 0 and no more than 999,999")]
        public decimal Cost { get; set; }

        [Required]
        [Range(0, 999999, ErrorMessage = "Cannot be less than 0 and no more than 999,999")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 9000, ErrorMessage = "Can not be less than 0... more than 9,000")]
        public int Count { get; set; }

        public string ImageURL { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
