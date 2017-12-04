namespace DesignPatterns.Bridge
{
    using System;

    public class VBSemanticsAnalyzer : SemanticsAnalyzer
    {
        public override SyntaxTree SemanticsAnalyze(SyntaxTree lexicon)
        {
            Console.WriteLine("Doing semantics analysis using VB analyzer.");
            return new SyntaxTree();
        }
    }
}