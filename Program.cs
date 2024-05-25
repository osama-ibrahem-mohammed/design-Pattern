using implementStrategyPattern.DiscountTypes;

namespace implementStrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerData=new customerDataReader();
            var customers = customerData.getCustomer();

            while (true)
            {
                Console.WriteLine("enter important information");
                int customerId = int.Parse(Console.ReadLine());
                double quantity = double.Parse(Console.ReadLine());
                double unitPrice = double.Parse(Console.ReadLine());
                var customer =customers.FirstOrDefault(c=> c.Id == customerId);
                IDiscount des = null;
                if (customer.type == customerType.Gold)
                {

                    des = new GoldDiscount();
                }
                else if (customer.type == customerType.Silver)
                {
                    des = new SilverDescount();

                }
                else if (customer.type == customerType.Copallet)
                {
                    des = new CopalletDescount();

                }
                else 
                {
                    des = new NewCustomerDescount();

                }
                var DiscountContext = new DiscountContext();
                DiscountContext.initializeImplementation(des);
                var invoice=DiscountContext.handleDiscount(customer, quantity, unitPrice);
               
                Console.WriteLine($"its {customer.Name} and his total is {invoice.netprice}");
            }


        }
    }
}
