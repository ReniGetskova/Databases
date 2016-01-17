namespace DAOClassWithCRUDOperations
{

    using CreateDbContextForNorthwindDB;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Customer customerTest = new Customer
            {
                CustomerID = "101",
                CompanyName = "This will be modify"
            };

            
            CustomerOperation.Create(customerTest);

            CustomerOperation.Update(customerTest.CustomerID, "This will be delete");

            CustomerOperation.Delete("delete");
        }
    }
}
