namespace DesignPatterns.Filter
{
    using System.Collections.Generic;

    public abstract class Criteria
    {
        public abstract bool Meet(Product product);
    }
}