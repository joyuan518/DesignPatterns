namespace DesignPatterns.Filter
{
    using System.Linq;
    using System.Collections.Generic;

    public class AndCriteria : Criteria
    {
        private readonly List<Criteria> _criterias;

        public AndCriteria(List<Criteria> criterias) => this._criterias = criterias;

        public override bool Meet(Product product) => this._criterias.All(c => c.Meet(product));
    }
}