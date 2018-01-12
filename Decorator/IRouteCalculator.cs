namespace DesignPatterns.Decorator
{
    public interface IRouteCalculator
    {
        Route GetShortestRoute(int startPoint, int endPoint);
    }
}