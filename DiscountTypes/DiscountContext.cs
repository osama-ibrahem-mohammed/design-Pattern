using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern.DiscountTypes
{
    internal class DiscountContext
    {
        public IDiscount discount { get; set; }

        public void initializeImplementation(IDiscount _discount)
        {
            discount= _discount;
        }
        public Invoice handleDiscount(Customer customer,double quantity,double unitPrice)
        {
            var invoice = new Invoice
            {
                customer = customer,
                invoiceLines = new List<InvoiceLine>
                    {
                       new InvoiceLine
                       {
                           Quantity = quantity,
                           UnitPrice = unitPrice,
                       }


                    },
                

            };
            invoice.discount = discount.calcDescount(invoice.totalPrice);
            return invoice;
        }
    }
}
