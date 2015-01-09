using System;

public class StringProc
{
	public static void Main(string[] args){
		string input = Console.ReadLine();

		string result = input.Replace("%20", " ");

		Console.Write("{0}\n", result);
	} 
}