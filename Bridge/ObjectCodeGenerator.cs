namespace DesignPatterns.Bridge
{
    public abstract class ObjectCodeGenerator
    {
        public abstract byte[] GenerateObjectCode(SyntaxTree syntaxTree);
    }
}