namespace DesignPatterns.Builder
{
    public static class Client
    {
        public static void Run()
        {
            var director = new Director(new ProductBuilder());
            var product = director.Construct();   
        }
    }
}