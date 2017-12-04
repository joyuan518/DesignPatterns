namespace DesignPatterns.Bridge
{
    using System;

    public class VBSyntaxAnalyzer : SyntaxAnalyzer
    {
        public override SyntaxTree SyntaxAnalyze(Lexicon lexicon)
        {
            Console.WriteLine("Doing syntax analysis using VB analyzer.");
            return new SyntaxTree();
        }
    }
}