using System;

namespace DesignPatterns.Factory
{
    public class GreenRetangle : IShape
    {
        void IShape.ShowShape()
        {
            Console.WriteLine("The shape is a green retangle.");
        }
    }
}