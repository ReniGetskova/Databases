namespace CustomerAditionalMethods
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string country = "Canada";
            int year = 1997;
            string region = "RJ";
            DateTime startDate = DateTime.Parse("1991-01-01");
            DateTime endDate = DateTime.Parse("2000-12-31");

            CustomerMethods customerMethodsTest = new CustomerMethods();
            customerMethodsTest.OrdersByYearAndCountry(country, year);
            customerMethodsTest.OrdersByYearAndCountryWithNativeQuery(country, year);
            customerMethodsTest.AllOrdersInRegionAndPeriod(region, startDate, endDate);
        }
    }
}
