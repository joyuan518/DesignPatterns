namespace DesignPatterns.Decorator
{
    using System;
    
    public class DijkstraCalculator : IRouteCalculator
    {
        Route IRouteCalculator.GetShortestRoute(int startPoint, int endPoint)
        {
            Console.WriteLine($"Calculate the shortest route using Dijkstra algorithm.");
            return new Route();
        }
    }
}