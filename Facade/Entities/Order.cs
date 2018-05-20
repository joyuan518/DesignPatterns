namespace DesignPatterns.Facade.Entities
{
    using System.Collections.Generic;
    
    public class Order
    {
        public int CustomerId {get; set;}

        public List<int> ProductIds {get; set;}
    }
}