namespace DesignPatterns.Adapter
{
    public static class Client
    {
        private static void DrawAllShapes(IPainter painter)
        {
            painter.DrawCircle();
            painter.DrawRetangle();
            painter.DrawSquare();
        }

        public static void Run()
        {
            IPainter painter = new ScreenPainter();
            DrawAllShapes(painter);

            painter = new PainterAdapter();
            DrawAllShapes(painter);
        }
    }
}