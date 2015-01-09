using System;

public class String
{
	public static void Main(string[] args){
		string input = args[0];

		string result = interview(input);

		Console.Write("{0}\n", result);
	} 

	public static string interview(string s)
	{
		while(s.IndexOf("%20") >= 0)
		{
			s = s.Replace("%20"," ");
		}

		return s;
	}
}