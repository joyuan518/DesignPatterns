namespace DesignPatterns.Facade.Services
{
    using Entities;
    
    public class CustomerService
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer();
        }
    }
}