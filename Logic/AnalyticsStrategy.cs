using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Logic
{
    public class AnalyticsStrategy
    {
        public IEnumerable<OrdersCount> CalculateOrdersSumByCity(IEnumerable<Order> orders, string city)
        {
            var ordersSumCount = orders.Where(x => x.Destination == city).GroupBy(x => x.Destination)
                .Select(x => new OrdersCount() { Destination = city, Sum = x.Sum(y => y.Products.) })
                     .ToList();
        }
    }
}
