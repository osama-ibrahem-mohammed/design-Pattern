using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern.DiscountTypes
{
    internal class SilverDescount : IDiscount
    {
        public double calcDescount(double totalPrice)
        {
            return totalPrice > 10000 ? .08 : 0;
        }
    }
}
