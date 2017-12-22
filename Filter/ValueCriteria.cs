namespace DesignPatterns.Filter
{
    public abstract class ValueCriteria<T>  : Criteria where T:struct
    {
        protected abstract bool ValueMeet(Product product, T value);
        protected readonly T _value;

        public ValueCriteria(T value)
        {
            this._value = value;
        }
        
        public override bool Meet(Product product) => ValueMeet(product, this._value);
    }
}