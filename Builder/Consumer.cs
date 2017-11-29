namespace DesignPatterns.Builder
{
    public static class Consumer
    {
        public static void Run()
        {
            var director = new Director(new ProductBuilder());
            var product = director.Construct();   
        }
    }
}