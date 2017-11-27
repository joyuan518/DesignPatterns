using System;

namespace designpatterns.Factory
{
    public class RedRetangle : IShape
    {
        void IShape.ShowShape()
        {
            Console.WriteLine("The shape is a red retangle.");
        }
    }
}