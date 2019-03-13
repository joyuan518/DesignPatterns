namespace DesignPatterns.Decorator
{
    public static class Client
    {
        public static void Run()
        {
            //The key point of Decorator pattern is using aggregation instead of inheritance, to avoid the 
            // "Classes Explosion" effect when we want to add additional aspect features for the existing class hierarchical structure 
            //It also allows us to add additonal process for an object dynamically, without the need of adding a new class 
            //in the class hierarchical structure
            IRouteCalculator calculator = new DijkstraCalculator();
            calculator.GetShortestRoute(1, 2);

            IRouteCalculator calculatorWithLog = new LogDecorator(calculator);
            calculator.GetShortestRoute(1, 2);
        }
    }
}
