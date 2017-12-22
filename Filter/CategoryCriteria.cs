namespace DesignPatterns.Filter
{
    public class CategoryCriteria : ValueCriteria<Category>
    {
        public CategoryCriteria(Category category) : base(category)
        {

        }

        protected override bool ValueMeet(Product product, Category value)
        {
            if (product.Category == value)
            {
                return true;
            }

            return false;
        }
    }
}