using System;

public class QueueTest
{
	public static void Main()
	{
		Queue queue = new Queue();
		string input = Console.ReadLine();

		while (input != "stop")
		{
			Node current = new Node(input);
			queue.push(current);
			input = Console.ReadLine();
		}

		Console.WriteLine("-------------------");

		while(queue.size > 0)
		{
			Console.Write("{0} ", queue.pop().value);
		}

		Console.Write("\n");
	}
}