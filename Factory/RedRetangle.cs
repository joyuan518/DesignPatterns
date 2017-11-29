using System;

namespace DesignPatterns.Factory
{
    public class RedRetangle : IShape
    {
        void IShape.ShowShape()
        {
            Console.WriteLine("The shape is a red retangle.");
        }
    }
}