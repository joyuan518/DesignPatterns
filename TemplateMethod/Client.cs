namespace DesignPatterns.TemplateMethod
{
    using System;
    using System.IO;

    public static class Client
    {
        public static void Run()
        {
            var treeNode = new TreeNode { 
                Value = 12,
                LeftChild = new TreeNode {
                    Value = 23
                },
                RightChild = new TreeNode {
                    Value = 56
                }
            };

            var s = new MemoryStream();
            var sw = new StreamWriter(s);

            TreeSerializer serializer = new XMLTreeSerializer();
            serializer.Serialize(treeNode, sw);

            Console.Write((new StreamReader(s)).ReadToEnd());

            serializer = new JSONTreeSerializer();
            serializer.Serialize(treeNode, sw);

            Console.Write((new StreamReader(s)).ReadToEnd());  

            Console.Read();          
        }
    }
}