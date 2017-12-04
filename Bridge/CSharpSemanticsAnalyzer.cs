namespace DesignPatterns.Bridge
{
    using System;

    public class CSharpSemanticsAnalyzer : SemanticsAnalyzer
    {
        public override SyntaxTree SemanticsAnalyze(SyntaxTree lexicon)
        {
            Console.WriteLine("Doing semantics analysis using C# analyzer");
            return new SyntaxTree();            
        }
    }
}