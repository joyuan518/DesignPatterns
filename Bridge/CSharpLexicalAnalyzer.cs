namespace DesignPatterns.Bridge
{
    using System;

    public class CSharpLexicalAnalyzer : LexicalAnalyzer
    {
        public override Lexicon LexicalAnalyze(string sourceCodeString)
        {
            Console.WriteLine("Doing lexcial analysis using C# analyzer.");
            return new Lexicon();        
        }
    }
}