using System;


public class Stack
{
	public int size;
	public Node head;

	public void push(Node input)
	{
		if (size == 0)
		{
			head = input;
			size++;
		}
		else
		{
			Node last = head;
			head = input;
			head.next = last; 
			size++; 
		}
	}

	public Node pop()
	{
		if (head == null)
		{
			Console.WriteLine("Stack is empty!");
			return null;
		}
		else
		{
			Node output;
			output = head;
			head = head.next;
			size--;
			return output;
		}
	}

	//CONSTRUCTOR
	public Stack()
	{
		size = 0;
		head = null;
	}
}
