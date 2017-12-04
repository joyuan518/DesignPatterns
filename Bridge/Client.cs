namespace DesignPatterns.Bridge
{
    public static class Client
    {
        public static void Run()
        {
            var windowsVBCompiler = new Compiler(
                                        new VBLexicalAnalyzer(),
                                        new VBSyntaxAnalyzer(),
                                        new VBSemanticsAnalyzer(),
                                        new WindowsObjCodeGenerator()
                                    );

            var winObjCodeFromVB = windowsVBCompiler.Compile("[Some code in VB ...]");

            var linuxCSharpCompiler = new Compiler(
                                        new CSharpLexicalAnalyzer(),
                                        new CSharpSyntaxAnalyzer(),
                                        new CSharpSemanticsAnalyzer(),
                                        new LinuxObjCodeGenerator()
                                    );

            var linuxObjCodeFromCSharp = linuxCSharpCompiler.Compile("[Some code in C# ...]");                
        }
    }
}