namespace DesignPatterns.Bridge
{
    public abstract class Compiler
    {
        protected readonly LexicalAnalyzer _lexicalAnalyzer;
        protected readonly SyntaxAnalyzer _syntaxAnalyer;
        protected readonly SemanticsAnalyzer _semanticsAnalyer;
        protected readonly ObjectCodeGenerator _objCodeGenerator;
        
        public Compiler(LexicalAnalyzer lexicalAnalyzer,
                        SyntaxAnalyzer syntaxAnalyer,
                        SemanticsAnalyzer semanticsAnalyzer,
                        ObjectCodeGenerator objCodeGenerator)
        {
            this._lexicalAnalyzer = lexicalAnalyzer;
            this._syntaxAnalyer = syntaxAnalyer;
            this._semanticsAnalyer = semanticsAnalyzer;
            this._objCodeGenerator = objCodeGenerator;
        }

        public void Compile(string sourceCodeString)
        {
        }
    }
}