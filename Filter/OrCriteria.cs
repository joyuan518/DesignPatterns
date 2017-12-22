namespace DesignPatterns.Filter
{
    using System.Linq;    
    using System.Collections.Generic;

    public class OrCriteria : Criteria
    {
        private readonly List<Criteria> criterias;

        public OrCriteria(List<Criteria> criterias) => this.criterias = criterias;

        public override bool Meet(Product product) => this.criterias.Any(c => c.Meet(product));
    }
}