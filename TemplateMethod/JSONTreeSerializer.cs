namespace DesignPatterns.TemplateMethod
{
    public class JSONTreeSerializer : TreeSerializer
    {
        public override void WriteNodeEnd()
        {
            throw new System.NotImplementedException();
        }

        public override void WriteNodeStart()
        {
            throw new System.NotImplementedException();
        }
    }
}