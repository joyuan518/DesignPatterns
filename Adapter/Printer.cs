namespace DesignPatterns.Adapter
{
    using System;

    public enum Shape
    {
        Circle,
        Retangle,
        Square
    }

    public class Printer
    {
        private Shape _shape {get;set;}

        public void DrawShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.Circle:
                {
                    Console.WriteLine("Draw a circle in memory bitmap.");                    
                    break;
                }

                case Shape.Retangle:
                {
                    Console.WriteLine("Draw a retangle in memory bitmap.");                    
                    break;
                }

                case Shape.Square:
                {
                    Console.WriteLine("Draw a square in memory bitmap.");
                    break;
                }
            }
        }

        public void Print()
        {
            switch (this._shape)
            {
                case Shape.Circle:
                {
                    Console.WriteLine("Print a circle on the paper.");                    
                    break;
                }

                case Shape.Retangle:
                {
                    Console.WriteLine("Print a retangle on the paper.");                    
                    break;
                }

                case Shape.Square:
                {
                    Console.WriteLine("Print a square on the paper.");
                    break;
                }
            }            
        }
    }
}