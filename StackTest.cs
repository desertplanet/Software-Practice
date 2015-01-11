using System;

public class Test
{
	public static void Main()
	{
		Stack stack = new Stack();
		string input = Console.ReadLine();

		while (input != "stop")
		{
			Node current = new Node(input);
			stack.push(current);
			input = Console.ReadLine();
		}

		Console.WriteLine("-------------------");

		while(stack.size > 0)
		{
			Console.Write("{0} ", stack.pop().value);
		}

		Console.Write("\n");
	}
}