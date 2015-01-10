using System;

public class bfs
{
	public static void Main()
	{
		string input = Console.ReadLine();

		Queue myQueue = new Queue();

		while (input != "stop")
		{
			Node thisNode = new Node(input);
			myQueue.enqueue(thisNode);
			input = Console.ReadLine();
		}

		Node current = myQueue.dequeue();

		while (current != null)
		{
			Console.Write("{0}",current.value);
			current = myQueue.dequeue();
		}
	}
}

public class Queue
{
	public int size;

	public Node head;
	public Node tail;

	public void enqueue(Node newNode)
	{
		if(head == null)
		{
			head = newNode;
			tail = newNode;
		} 
		else 
		{
			newNode.next = tail;
			tail.previous = newNode;
			tail = newNode;
		}
	}

	public Node dequeue()
	{
		Node output;

		if (head == null)
		{
			return null;
		}
		else if (head != tail)
		{
			head = head.previous;
			output = head.next;
			head.next = null;
			return output;
		} 
		else
		{
			output = head;
			head = null;
			tail = null;
			return output;
		} 
	}

	public Queue()
	{	
		head = null;
		tail = null;
		size = 0;
	}
}

public class Node
{
	public Node previous;
	public Node next;

	public string value;
	//public int x;
	//public int y;

	public Node(string val)
	{
		//x = xCoord;
		//y = yCoord;

		value = val;
		previous = null;
		next = null;
	}
}