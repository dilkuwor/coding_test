using System;
namespace CSharpLogic.DataStructure.BinaryTree
{
    public class BinarySTree
    {
		private Node _root;
        public BinarySTree()
        {
			
        }

		public void Add(int a)
		{
			if (_root == null)
				_root = new Node(a)
				{
					
				};
			else{
				var node = FindNode(_root, a);
			}
		}
		public void PreorderTraversal(){
			Preorder(_root);
		}
		public void PostorderTraversal(){
			Postorder(_root);
		}
		private void Postorder(Node node){
			if (node == null)
				return;
			if(node.Left == null)
			{
				Console.WriteLine(node.Data);
				Postorder(node.Right);
			}
			
		}
		private void Preorder(Node node){
			if (node == null)
				return;
			else{
				Console.Write($"{node.Data},");
				Preorder(node.Left);
				Preorder(node.Right);
			}
			
		}
		private Node FindNode(Node node, int data){
			
			if(node.Data>data){
				if (node.Left == null)
				{
					var newNode = new Node(data)
					{
						Data = data
					};
					node.Left = newNode;
					return newNode;
				}
				return FindNode(node.Left, data);
			}
			else{
				if (node.Right == null)
                {
					var newNode = new Node(data)
                    {
                        Data = data
                    };
					node.Right = newNode;
                    return newNode;
                }
				return FindNode(node.Right, data);
			}
				
		}
    }
}
