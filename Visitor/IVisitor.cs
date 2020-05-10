namespace DesignPatterns.Visitor
{
    public interface IVisitor
    {
         void visit(TextElement element);
         void visit(ImageElement element);
         void visit(TableElement element);         
    }
}