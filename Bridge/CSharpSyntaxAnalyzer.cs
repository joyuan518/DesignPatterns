namespace DesignPatterns.Bridge
{
    using System;

    public class CSharpSyntaxAnalyzer : SyntaxAnalyzer
    {
        public override SyntaxTree SyntaxAnalyze(Lexicon lexicon)
        {
            Console.WriteLine("Doing syntax analysis using C# analyzer.");
            return new SyntaxTree();
        }
    }
}