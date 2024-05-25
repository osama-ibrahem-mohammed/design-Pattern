using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern
{
    internal class Invoice
    {
        public Customer customer { get; set; }
        public IEnumerable<InvoiceLine> invoiceLines { get; set; }
        public double totalPrice => invoiceLines.Sum(x => x.UnitPrice * x.Quantity);
        public double discount { get; set; }
        public double netprice => invoiceLines.Sum(x => (1-discount)* x.UnitPrice * x.Quantity);
    }
}
