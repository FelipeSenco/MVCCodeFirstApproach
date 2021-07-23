using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Company.DomainModels
{
    public class Product
    {
        [Key]
        [Display(Name = "Product ID")]
        public long ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Must provide a name")]
        [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "Alphabets only")]
        [MaxLength(20, ErrorMessage = "Product name must not exceed 20 characters")]
        public string ProductName { get; set; }

        [Display(Name = "Price")]
        [Required]
        [Range(0, 1000000, ErrorMessage = "Price can't be higher than 1000000")]
        [DivisibleBy10(ErrorMessage = "Price must be divisible by 10")]
        public Nullable<decimal> Price { get; set; }

        [Display(Name = "Date of Purchase")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }

        [Display(Name = "Availability Status")]
        [Required(ErrorMessage = "This is a required field")]
        public string AvailabilityStatus { get; set; }

        [Required(ErrorMessage = "Category is necessary")]
        [Display(Name = "Category ID")]
        public long CategoryID { get; set; }

        [Required(ErrorMessage = "Brand is necessary")]
        [Display(Name = "Brand ID")]
        public long BrandID { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        public string Photo { get; set; }

        public Nullable<decimal> Quantity { get; set; }


        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}