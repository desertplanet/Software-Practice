using System;

public class TreeTest
{
	public static void Main()
	{
		Node root = new Node("root");
		Tree tree = new Tree(root);

		Console.WriteLine("-----TREE BUILT------");

		Console.WriteLine("Start at root:");

		string input = Console.ReadLine();

		Node current = tree.root;

		while (input != "stop")
		{
			switch (input)
			{
				case "left": 
					if (current.left != null) 
					{
						current = current.left;
						Console.WriteLine("{0}", current.value);
						break;
					}
					else goto case "wrong";
				case "right":
					if (current.right != null) 
					{
						current = current.right;
						Console.WriteLine("{0}", current.value);
						break;
					} 
					else goto case "wrong";
				case "root":
					current = tree.root;
					Console.WriteLine("{0}", current.value);
					break;
				case "wrong":
					Console.WriteLine("Nothing here...");
					break;
				default:
					break;
			}
			
			input = Console.ReadLine();
		}
	}
}