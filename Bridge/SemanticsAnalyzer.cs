namespace DesignPatterns.Bridge
{
    public abstract class SemanticsAnalyzer
    {
        public abstract SyntaxTree SemanticsAnalyze(SyntaxTree lexicon);
    }
}