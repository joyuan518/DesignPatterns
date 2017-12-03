namespace DesignPatterns.Bridge
{
    public abstract class SyntaxAnalyzer
    {
        public abstract SyntaxTree SyntaxAnalyze(Lexicon lexicon);
    }
}