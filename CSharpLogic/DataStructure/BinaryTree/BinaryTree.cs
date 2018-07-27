using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpLogic.DataStructure.BinaryTree
{
    public class BinaryTree
    {
	    public Node root;
        public BinaryTree()
        {
        }
		public void PreorderTraversal(){
			Preorder(root);
		}
		private void Preorder(Node node){
			// Base case
			if (node == null)
				return;

			Stack<Node> stack = new Stack<Node>();
			stack.Push(node);
			while(stack.Count!=0){
				// Pop the top item from stack
				Node myNode = stack.Peek();
				Console.WriteLine(myNode.Data);
				stack.Pop();
				if (myNode.Right != null)
					stack.Push(myNode.Right);
				if (myNode.Left != null)
					stack.Push(myNode.Left);
			}
		}

    }
}
