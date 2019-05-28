namespace DesignPatterns.Facade
{
    using GatewayEntieis;
    using ServiceGateways;

    public class Client
    {
        public static void Run()
        {   
            //the specific consumer of the system services will consume them via the gateway services intead of 
            // invoking them directly. the consumer doesn't need to be aware of the underlying services, 
            // which might be designed to be in a good shape as public services for many consumers, but 
            // might not be straightfoward enough for one specific consumer. the gateway/facade services 
            // provide easy interface for specific consumers, and also decouple them from the detail of the 
            // underlynig services impelmentation
            var orderId = 1;
            var orderInfo = new OrderInfoServiceGateway().GetOrderInfo(orderId);
        }
    }
}
