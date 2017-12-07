namespace DesignPatterns.TemplateMethod
{
    public class XMLTreeSerializer : TreeSerializer
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