namespace DesignPatterns.Adapter
{
    public interface IPrinter
    {
         void DrawShape(Shape shape);

         void Print();
    }
}