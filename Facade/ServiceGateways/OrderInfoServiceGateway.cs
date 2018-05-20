namespace DesignPatterns.Facade.ServiceGateways
{
    using Entities;
    using Services;
    using GatewayEntieis;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderInfoServiceGateway
    {
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        private readonly ProductService _productService;

        private OrderInfo BuildOrderInfo(Order order, Customer customer, IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }

        public OrderInfoServiceGateway()
        {
            _orderService = new OrderService();
            _customerService = new CustomerService();
            _productService = new ProductService();
        }

        public OrderInfo GetOrderInfo(int orderId)
        {
            var order = _orderService.GetOrder(orderId);
            var customer = _customerService.GetCustomer(order.CustomerId);
            var products = order.ProductIds.Select(pid => _productService.GetProduct(pid));

            return BuildOrderInfo(order, customer, products);
        }
    }
}