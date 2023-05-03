using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFDBFirstApproach.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product ID")]
        public long ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name cannot be blank")]
        public string ProductName { get; set; }

        [Display(Name = "Price")]
        [Range(0,100000, ErrorMessage ="Prices should be inbetween 0 and 100000")]
        [Required (ErrorMessage ="Price cannot be blank")]
        public Nullable<decimal> Price { get; set; }

        [Display(Name = "Date of Purchase")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }

        [Display(Name = "Availability Status")]
        public string AvailabilityStatus { get; set; }

        [Display(Name = "Category ID")]
        [Required]
        public long CategoryID { get; set; }

        [Display(Name = "Brand ID")]
        [Required]
        public long BrandID { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }
        public string Photo { get; set; }


        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}