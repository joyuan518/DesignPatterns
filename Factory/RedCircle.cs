using System;

namespace DesignPatterns.Factory
{
    public class RedCircle : IShape
    {
        void IShape.ShowShape()
        {
            
            Console.WriteLine("The shape is a red circle.");
        }
    }
}