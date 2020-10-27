using CapstoneShoppingList.Sevices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CapstoneShoppingList.Models
{
    public partial class Order
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        
        [Display(Name = "Product ID")]
        public int? ProductId { get; set; }
        
        [Display(Name = "Quantity")]
        [Range(0,1000)]
        public int? Quantity { get; set; }
        
        [Display(Name = "Item Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Total { get; set; }
        
        [Display(Name = "Product")]
        public virtual Products Product { get; set; }
        
        [Display(Name="Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ItemTotalCost
        {

            get { return Quantity* Product.ProductPrice; }
        }
        //ICalculate Calculations.Calculate(Quantity, Total);
    }

}
