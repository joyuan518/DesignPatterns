namespace DesignPatterns.TemplateMethod
{
    using System;
    using System.IO;

    public abstract class TreeSerializer
    {
        public abstract void WriteNodeStart();
        public abstract void WriteNodeEnd();
        
        public string Serialize()
        {
            throw new NotImplementedException();
        }
    }
}