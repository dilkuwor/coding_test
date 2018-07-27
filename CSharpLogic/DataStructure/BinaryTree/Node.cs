using System;
namespace CSharpLogic.DataStructure.BinaryTree
{
    public class Node
    {
        public Node(int a)
        {
			this.Data = a;	
        }
        public int Data
		{
			get;
			set;
		}

        public Node Left
		{
			get;
			set;
		}
        public Node Right
		{
			get;
			set;
		}
    }
}
