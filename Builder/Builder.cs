using System;

namespace DesignPatterns.Builder
{
    public abstract class Builder
    {
        protected Product _product;
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract void BuildPartD();    

        public Product GetProduct()
        {
            return this._product;
        }    
    }
}