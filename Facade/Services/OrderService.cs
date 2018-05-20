namespace DesignPatterns.Facade.Services
{
    using Entities;

    public class OrderService
    {
        public Order GetOrder(int orderId)
        {
            return new Order();
        }
    }
}