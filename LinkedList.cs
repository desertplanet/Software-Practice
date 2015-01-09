using System;

public class list
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            node head = new node(args[0]);
            node p = head;

            for (int i=1; i < args.Length; i++)
            {
                p.next = new node(args[i]);
                p = p.next;
            }

           //Here I will invert the linked list

            node x = head;
            while (x != null)
            {
                Console.Write("{0}", x.value);
                x = x.next;
            }
        }
        else
        {
            Console.Write("You did not provide any input.");
        }

        Console.Write("\n");
    }
}

public class node
{
    public string value;
    public node next;

    public node(string val)
    {
        value = val;
        next = null;
    }
}