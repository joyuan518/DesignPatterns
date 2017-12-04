using System;
using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public static class Client
    {
        public static void Run()
        {
            var order1 = new Order() {
                                        Id = 1,
                                        CreateDate = DateTime.Now,
                                        Address = "#123, West Street",                                        
                                        Items = new List<OrderItem>()
                                        {
                                            new OrderItem 
                                            {
                                                ProductId = 1,
                                                Quantity = 3
                                            }
                                        }
                                     };
            
            var order2 = order1.ShallowClone();
            var order3 = order1.Clone() as Order;

            if (object.ReferenceEquals(order1.Items, order2.Items))
            {
                Console.WriteLine("order1.Items and order2.Items are refer to the same object.");
            }
            else
            {
                Console.WriteLine("order1.Items and order2.Items are not refer to the same object.");                
            }

            if (object.ReferenceEquals(order1.Items, order3.Items))
            {
                Console.WriteLine("order1.Items and order3.Items are refer to the same object.");
            }
            else
            {
                Console.WriteLine("order1.Items and order3.Items are not refer to the same object.");                
            }            
        }
    }
}