namespace DesignPatterns.Visitor
{
    //The intention of the Visitor pattern is to decouple the complex data/object structure which we need to visit and 
    // the exact operations that we want to performan when we visit them... 
    public static class Client
    {
        public static void Run()
        {
            var document = new Document();
            IVisitor readVisitor = (IVisitor)new ReadVisitor();

            //Here we want to visit all the elements of the doc in a read-only way...
            document.Accept(readVisitor);

            IVisitor writeVisitor = (IVisitor)new WriteVisitor();

            //Here we want to visit all the elements of the doc in a read-write way...
            document.Accept(writeVisitor);
        }
    }
}