namespace DesignPatterns.Visitor
{
    public class TableElement : BaseDocElement
    {
        public int Length { get; set; }

        public int Width { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}