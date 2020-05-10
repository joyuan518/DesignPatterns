namespace DesignPatterns.Visitor
{
    using System.Collections.Generic;

    public class Document
    {
        public List<BaseDocElement> Elements { get; set; }

        public void Accept(IVisitor visitor) 
        {
            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }
        }
    }
}