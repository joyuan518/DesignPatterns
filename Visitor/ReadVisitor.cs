namespace DesignPatterns.Visitor
{
    public class ReadVisitor : IVisitor
    {
        void IVisitor.visit(TextElement element)
        {
            throw new System.NotImplementedException();
        }

        void IVisitor.visit(ImageElement element)
        {
            throw new System.NotImplementedException();
        }

        void IVisitor.visit(TableElement element)
        {
            throw new System.NotImplementedException();
        }
    }
}