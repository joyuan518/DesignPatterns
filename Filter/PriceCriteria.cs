namespace DesignPatterns.Filter
{
    public class PriceCriteria : ValueCriteria<decimal>
    {
        public PriceCriteria(decimal price) : base(price)
        {

        }

        protected override bool ValueMeet(Product product, decimal value)
        {
            if (product.Price == value)
            {
                return true;
            }

            return false;
        }
    }
}