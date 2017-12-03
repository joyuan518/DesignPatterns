namespace DesignPatterns.Bridge
{
    public abstract class LexicalAnalyzer
    {
         public abstract Lexicon LexicalAnalyze(string sourceCodeString);
    }
}