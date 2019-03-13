namespace DesignPatterns.Decorator
{
    using System;

    public class BellmanFordCalculator : IRouteCalculator
    {
        Route IRouteCalculator.GetShortestRoute(int startPoint, int endPoint)
        {
            Console.WriteLine("Calculate the shortest route using BellmanFord algorithm.");
            return new Route();
        }
    }
}