namespace DesignPatterns.Decorator
{
    public static class Client
    {
        public static void Run()
        {
            //The key point of Decorator pattern is using aggregation instead of inheritance, to avoid the 
            // "Classes Explosion" effect when we want to add additional aspect features for the existing class hierarchial structure 
            IRouteCalculator calculator = new DijkstraCalculator();
            calculator.GetShortestRoute(1, 2);

            calculator = new CacheableCalculator(calculator);
            calculator.GetShortestRoute(1, 2);
        }
    }
}
