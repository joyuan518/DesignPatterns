namespace DesignPatterns.Bridge
{
    using System;

    public class VBLexicalAnalyzer : LexicalAnalyzer
    {
        public override Lexicon LexicalAnalyze(string sourceCodeString)
        {
            Console.WriteLine("Doing lexical analysis using  VB analyzer.");
            return new Lexicon();
        }
    }
}