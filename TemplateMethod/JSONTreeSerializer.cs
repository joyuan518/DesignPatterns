
namespace DesignPatterns.TemplateMethod
{
    using System.IO;

    public class JSONTreeSerializer : TreeSerializer
    {
        public override void WriteNodeEnd(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth);
            stream.WriteLine($"{indentation}}}");            
        }

        public override void WriteNodeStart(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth);

            if (treeNode.Depth == 0)
            {
                stream.WriteLine($"{indentation}{{");            
            }
            else
            {
                stream.WriteLine($"{indentation}TreeNode:{{");                
            }
        }

        public override void WriteNodeValue(TreeNode treeNode, StreamWriter stream)
        {
            var indentation = " ".Range(treeNode.Depth + 4);
            stream.WriteLine($"{indentation}NodeValue:{treeNode.Value}");            
        }
    }
}