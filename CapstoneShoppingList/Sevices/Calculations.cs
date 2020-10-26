using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneShoppingList.Sevices
{
    public class Calculations:ICalculate
    {
        public decimal Calculate(int quantity, decimal price)
        {
            var total = quantity * price;
            return total;
        }
    }
}
