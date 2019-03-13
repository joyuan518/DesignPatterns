namespace DesignPatterns.Decorator
{
    using System;

    public class LogDecorator : BaseCalculatorDecorator
    {
        public LogDecorator(IRouteCalculator calculator) : base(calculator)
        {
        }

        protected override void DoAdditionalThings()
        {
            Console.WriteLine("Write the log...");
        }
    }
}