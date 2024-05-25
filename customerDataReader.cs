using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementStrategyPattern
{
    internal class customerDataReader
    {
        public IEnumerable<Customer> getCustomer()
        {
            return new[]
            {
           new Customer{
                      Id=2,
                       Name="osama",
                       type=customerType.Gold
                        },
           new Customer{
                      Id=2,
                       Name="ali",
                       type=customerType.Silver

                       },
            new Customer{
                      Id=3,
                       Name="said",
                       type=customerType.Copallet

                       },
             new Customer{
                      Id=4,
                       Name="ibrahem",
                       type=customerType.New

                       },
            };
        }
    }
}
