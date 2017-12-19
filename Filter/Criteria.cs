namespace DesignPatterns.Filter
{
    using System.Collections.Generic;

    public abstract class Criteria
    {
        public abstract void Filter(List<Product> products);
    }
}