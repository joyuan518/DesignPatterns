using System;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private readonly Builder _builder;

        public Director(Builder builder)
        {
            this._builder = builder;
        }

        public Product Construct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
            this._builder.BuildPartD();

            return this._builder.GetProduct();
        }
    }
}