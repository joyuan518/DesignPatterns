namespace DesignPatterns.Decorator
{
    public static class Client
    {
        public static void Run()
        {
            IRouteCalculator calculator = new DijkstraCalculator();
            calculator.GetShortestRoute(1, 2);

            calculator = new CacheableCalculator(calculator);
            calculator.GetShortestRoute(1, 2);
        }
    }
}