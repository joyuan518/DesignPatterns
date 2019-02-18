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
            //The intention of adapter pattern is to make it possible to use underlying providers which 
            // provide different interfaces through one specific interface 
            IPainter screenPainter = new ScreenPainter();
            DrawAllShapes(screenPainter);

            IPainter printerPainter = new PainterAdapter(new LaserPrinter());
            DrawAllShapes(printerPainter);
        }
    }
}