using System;

public class Tree
{
	public Node root;

	//CONSTRUCTOR
	public Tree(Node newRoot)
	{
		root = newRoot;

		Node current = root;

		string input = Console.ReadLine();

		while (input != "stop")
		{
			switch(input)
			{
				case "left": 
					if (current.left != null) current = current.left;
					else Console.WriteLine("No node left.");
					break;
				case "right":
					if (current.right != null) current = current.right;
					else Console.WriteLine("No node right.");
					break;
				case "new left":
					if (current.left != null) Console.WriteLine("Node exists.");
					else current.left = new Node(Console.ReadLine());
					break;
				case "new right":
					if (current.right != null) Console.WriteLine("Node exists.");
					else current.right = new Node(Console.ReadLine());
					break;
				case "root":
					current = root;
					break;
				default:
					Console.WriteLine("Misc Error (default).");
					break;
			}

			input = Console.ReadLine();
		}
	}
}