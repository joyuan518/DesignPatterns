namespace DesignPatterns.TemplateMethod
{
    using System;
    using System.IO;

    public abstract class TreeSerializer
    {
        public abstract void WriteNodeStart(TreeNode treeNode, StreamWriter stream);
        public abstract void WriteNodeValue(TreeNode treeNode, StreamWriter stream);
        public abstract void WriteNodeEnd(TreeNode treeNode, StreamWriter stream);
        
        public void Serialize(TreeNode treeNode, StreamWriter stream)
        {
            WriteNodeStart(treeNode, stream);
            WriteNodeValue(treeNode, stream);

            var leftChild = treeNode.LeftChild;

            if (leftChild != null)
            {
                Serialize(leftChild, stream);
            }

            var rightChild = treeNode.RightChild;

            if (rightChild != null)
            {
                Serialize(rightChild, stream);
            }

            WriteNodeEnd(treeNode, stream);
        }
    }
}