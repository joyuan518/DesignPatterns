using System;

namespace designpatterns.Factory
{
    public class RedCircle : IShape
    {
        void IShape.ShowShape()
        {
            
            Console.WriteLine("The shape is a red circle.");
        }
    }
}