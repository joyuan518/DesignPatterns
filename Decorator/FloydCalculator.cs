namespace DesignPatterns.Decorator
{
    using System;
    
    public class FloydCalculator : IRouteCalculator
    {
        Route IRouteCalculator.GetShortestRoute(int startPoint, int endPoint)
        {
            Console.WriteLine("Calculate the shortest route using Floyd algorithm.");
            return new Route();
        }
    }
}