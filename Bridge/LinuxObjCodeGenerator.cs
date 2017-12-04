namespace DesignPatterns.Bridge
{
    using System;

    public class LinuxObjCodeGenerator : ObjectCodeGenerator
    {
        public override byte[] GenerateObjectCode(SyntaxTree syntaxTree)
        {
            Console.WriteLine("Generating object code for Linux platform.");
            return new byte[200];
        }
    }
}