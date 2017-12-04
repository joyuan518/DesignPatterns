namespace DesignPatterns.Bridge
{
    using System;

    public class WindowsObjCodeGenerator : ObjectCodeGenerator
    {
        public override byte[] GenerateObjectCode(SyntaxTree syntaxTree)
        {
            Console.WriteLine("Generating object code for Windows platform.");
            return new byte[200];
        }
    }
}