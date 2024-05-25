using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern.DiscountTypes
{
    internal class NewCustomerDescount : IDiscount
    {
        public double calcDescount(double totalPrice)
        {
            return 0;
        }
    }
}
