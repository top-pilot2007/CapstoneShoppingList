using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CapstoneShoppingList.Models
{
    public partial class Products
    {
        public Products()
        {
            Order = new HashSet<Order>();
        }
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]

        public string ProductName { get; set; }
        [Display(Name = "Product Description")]

        public string ProductDescription { get; set; }
        [Display(Name = "Product Price")]

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ProductPrice { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
