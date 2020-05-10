namespace DesignPatterns.Visitor
{
    public abstract class BaseDocElement
    {
        public string Value { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}