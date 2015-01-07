using System;

public class hello{
	public static int Main(string[] args){
		Console.WriteLine("Hello World!");
        Console.Write("Your arguments were: ");
        for (int i = 0; i < args.Length; i++) Console.Write("{0} ", args[i]);
        Console.Write("\n");
        return 0;
	}
}