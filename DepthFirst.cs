using System;

public class DepthFirst
{
	public static void Main()
	{
		Node root = new Node("Root");

		Tree tree = new Tree(root);

		Stack stack = new Stack();

		stack.push(tree.root);

		Node N;

		Console.WriteLine("Traversing...");

		while (stack.size > 0)
		{
			N = stack.pop();

			Console.WriteLine("{0}", N.value);

			if (N.left != null) stack.push(N.left);
			if (N.right != null) stack.push(N.right);
		}
	}
}