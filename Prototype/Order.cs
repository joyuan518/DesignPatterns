using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class Order : ICloneable
    {
        public int Id {get;set;}
        public DateTime CreateDate {get;set;}
        public string Address {get;set;}
        public List<OrderItem> Items {get;set;}

        public Order ShallowClone()
        {
            return this.MemberwiseClone() as Order;    
        }
        
        public object Clone()
        {
            //Deep copy using binary serialization/deserilization
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);
            stream.Position = 0;
            
            return formatter.Deserialize(stream);
        }
    }
}