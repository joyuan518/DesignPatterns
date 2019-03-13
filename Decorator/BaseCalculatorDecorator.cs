namespace DesignPatterns.Decorator
{
    public abstract class BaseCalculatorDecorator : IRouteCalculator
    {
        private readonly IRouteCalculator _routeCalculator;

        protected abstract void DoAdditionalThings();

        public BaseCalculatorDecorator(IRouteCalculator routeCalculator)
        {
            _routeCalculator = routeCalculator;
        }

        public Route GetShortestRoute(int startPoint, int endPoint)
        {
            DoAdditionalThings();
            return _routeCalculator.GetShortestRoute(startPoint, endPoint);
        }
    }
}