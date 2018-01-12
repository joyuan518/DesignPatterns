namespace DesignPatterns.Decorator
{
    using System;

    public class CacheableCalculator : IRouteCalculator
    {
        private readonly IRouteCalculator _calculator;

        public CacheableCalculator(IRouteCalculator calculator)
        {
            this._calculator = calculator;
        }

        Route IRouteCalculator.GetShortestRoute(int startPoint, int endPoint)
        {
            Console.WriteLine("Try to get the route from the cache.");

            //TODO: Try to get the route from the cache first

            //If can't find it in cache, do the calculation
            var route = this._calculator.GetShortestRoute(startPoint, endPoint);

            //TODO: Put the route into the cache

            return route;
        }
    }
}