using System;

public class Stacktest
{
	public static int Main()
	{
		string input = Console.ReadLine();
		string output;
		
		Stack S = new Stack();

		while (input != "stop")
		{
			S.push(input);
			input = Console.ReadLine();
		}

		if (S.size == 1) Console.Write("Stack is Empty!");

		while (S.size > 0)
		{
			output = S.pop();
			Console.Write("{0}",output); 
		}
	
 		Console.Write("\n");
		return 0;
	}
}

public class Stack
{
	public int size;
	static int MAX_SIZE = 6;

	string[] array = new string[MAX_SIZE];

	//CONSTRUCTOR
	public Stack()
	{
		size = 0;
	}

	public void push(string input)
	{
		if (size < MAX_SIZE)
		{
			array[size] = input;
			size++;
		}
		else
		{
			Console.WriteLine("Error: Stack Overflow!");
		}
	}

	public string pop()
	{
		string output;

		if (size > 0)
		{
			size--;
			output = array[size];
			array[size] = String.Empty;
			return output;
		}
		else
		{
			Console.WriteLine("Error: Stack is empty.");
			return String.Empty;
		}
	}
}