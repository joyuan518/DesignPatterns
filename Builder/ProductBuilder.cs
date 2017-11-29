using System;

namespace DesignPatterns.Builder
{
    public class ProductBuilder : Builder
    {
        public override void BuildPartA() => Console.WriteLine("Build part A.");

        public override void BuildPartB() => Console.WriteLine("Build part B.");

        public override void BuildPartC() => Console.WriteLine("Build part C.");

        public override void BuildPartD() => Console.WriteLine("Build part D.");
    }
}