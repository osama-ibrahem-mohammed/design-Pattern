using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern.DiscountTypes
{
    internal class GoldDiscount : IDiscount
    {
        public double calcDescount(double totalPrice)
        {
            return totalPrice > 10000 ? .1 : 0;
        }
    }
}
