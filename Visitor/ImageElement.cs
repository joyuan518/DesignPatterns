namespace DesignPatterns.Visitor
{
    public class ImageElement : BaseDocElement
    {
        public byte[] Image { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}