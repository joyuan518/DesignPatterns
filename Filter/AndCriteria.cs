namespace DesignPatterns.Filter
{
    using System.Linq;
    using System.Collections.Generic;

    public class AndCriteria : Criteria
    {
        private readonly List<Criteria> criterias;

        public AndCriteria(List<Criteria> criterias)
        {
            this.criterias = criterias;
        }

        public override void Filter(List<Product> products)
        {
            this.criterias.ForEach(c => c.Filter(products));
        }
    }
}