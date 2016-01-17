using CreateDbContextForNorthwindDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAditionalMethods
{
    public class CustomerMethods
    {
        public void OrdersByYearAndCountry(string country, int year)
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db
                    .Orders
                    .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country)
                    .Select(c => c.Customer.ContactName)
                    .Distinct()
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }

        public void OrdersByYearAndCountryWithNativeQuery(string country, int year)
        {
            using (var db = new NorthwindEntities())
            {
                string nativeSqlQuery = "SELECT DISTINCT c.ContactName" +
                           " FROM Orders o JOIN Customers c ON o.CustomerID = c.CustomerID" +
                           " WHERE o.ShipCountry = '" + country + "' AND DATEPART(YEAR, o.OrderDate) = " + year;

                var queryResult = db.Database.SqlQuery<string>(nativeSqlQuery).ToList();

                foreach (var customer in queryResult)
                {
                    Console.WriteLine(customer);
                }
            }
        }

        public void AllOrdersInRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var orders = db
                    .Orders
                    .Where(o => o.ShipRegion == region && (startDate < o.ShippedDate && o.ShippedDate < endDate))
                    .Select(order => new
                    {
                        ShipRegion = order.ShipRegion,
                        ShipName = order.ShipName,
                        ShipDate = order.ShippedDate
                    })
                    .ToList();

                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }
}
