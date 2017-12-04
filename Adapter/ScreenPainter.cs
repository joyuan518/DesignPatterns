using System;

namespace DesignPatterns.Adapter
{
    public class ScreenPainter : IPainter
    {
        void IPainter.DrawCircle()
        {
            Console.WriteLine("Draw a circle on the screen.");
        }

        void IPainter.DrawRetangle()
        {
            Console.WriteLine("Draw a retangle on the screen.");
        }

        void IPainter.DrawSquare()
        {
            Console.WriteLine("Draw a square on the screen.");
        }
    }
}