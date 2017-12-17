namespace DesignPatterns.TemplateMethod
{
    using System;
    using System.IO;
    using System.Text;

    public class XMLTreeSerializer : TreeSerializer
    {
        public override void WriteNodeEnd(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth);
            stream.WriteLine($"{indentation}</TreeNode>");            
        }

        public override void WriteNodeStart(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth);
            stream.WriteLine($"{indentation}<TreeNode>");            
        }

        public override void WriteNodeValue(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth + 4);
            stream.WriteLine($"{indentation}");            
        }
    }
}