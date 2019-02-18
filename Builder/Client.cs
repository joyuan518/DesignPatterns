namespace DesignPatterns.Builder
{
    public static class Client
    {
        public static void Run()
        {
            //The intention of the "Builder" pattern is to decouple the process of building a complex object from the concrete parts which 
            // form the object, so that these two aspects of building a complex object can be reused independently. 
            var director = new Director(new ProductBuilder());
            var product = director.Construct();   
        }
    }
}
