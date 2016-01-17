namespace DAOClassWithCRUDOperations
{
    using System.Linq;


    using CreateDbContextForNorthwindDB;

    // see this article for static DAO methods 
    // http://stackoverflow.com/questions/2523804/using-static-methods-or-none-static-methods-in-dao-class

    public static class CustomerOperation
    {
        public static void Create(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void Delete(string deletingCriteria)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers.FirstOrDefault(c => c.CompanyName.Contains(deletingCriteria));
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }
        }

        // Work only with original object. Don't use select with update
        public static void Update(string customerId, string newCompanyName)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                customerToUpdate.CompanyName = newCompanyName;
                db.SaveChanges();
            }
        }
    }
}
