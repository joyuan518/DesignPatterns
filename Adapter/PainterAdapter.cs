namespace DesignPatterns.Adapter
{
    public class PainterAdapter : IPainter
    {
        private readonly Printer _printer = new Printer();

        void IPainter.DrawCircle()
        {
            this._printer.DrawShape(Shape.Circle);
            this._printer.Print();
        }

        void IPainter.DrawRetangle()
        {
            this._printer.DrawShape(Shape.Retangle);
            this._printer.Print();
        }

        void IPainter.DrawSquare()
        {
            this._printer.DrawShape(Shape.Square);
            this._printer.Print();
        }
    }
}