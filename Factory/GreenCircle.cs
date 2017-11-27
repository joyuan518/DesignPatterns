using System;

namespace designpatterns.Factory
{
    public class GreenCircle : IShape
    {
        void IShape.ShowShape()
        {
            Console.WriteLine("The shape is a green circle.");
        }
    }
}