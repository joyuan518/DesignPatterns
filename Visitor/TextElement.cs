namespace DesignPatterns.Visitor
{
    public class TextElement : BaseDocElement
    {
        public string Text { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}