using System;

public class BreadthFirst
{
	public static void Main()
	{
		Node root = new Node("Root");

		Tree tree = new Tree(root);

		Queue queue = new Queue();

		queue.push(tree.root);

		Node N;

		Console.WriteLine("Traversing...");

		while (queue.size > 0)
		{
			N = queue.pop();

			Console.WriteLine("{0}", N.value);

			if (N.left != null) queue.push(N.left);
			if (N.right != null) queue.push(N.right);
		}
	}
}