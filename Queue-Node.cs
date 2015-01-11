using System;

public class Queue
{
	public int size;

	public Node head;
	public Node tail;

	public void push(Node newNode)
	{
		if(head == null)
		{
			head = newNode;
			tail = newNode;
			size++;
		} 
		else 
		{
			newNode.next = tail;
			tail.previous = newNode;
			tail = newNode;
			size++;
		}
	}

	public Node pop()
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
			size--;
			return output;
		} 
		else
		{
			output = head;
			head = null;
			tail = null;
			size--;
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
	public Node left;
	public Node right;

	public string value;

	public Node(string val)
	{
		value = val;
		previous = null;
		next = null;
		left = null;
		right = null;
	}
}