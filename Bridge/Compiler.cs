namespace DesignPatterns.Bridge
{
    public class Compiler
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

        public byte[] Compile(string sourceCodeString)
        {
            var lexicon = this._lexicalAnalyzer.LexicalAnalyze(sourceCodeString);
            var syntaxTree = this._syntaxAnalyer.SyntaxAnalyze(lexicon);
            syntaxTree = this._semanticsAnalyer.SemanticsAnalyze(syntaxTree);

            return this._objCodeGenerator.GenerateObjectCode(syntaxTree);
        }
    }
}