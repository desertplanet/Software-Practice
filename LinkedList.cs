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

            node x = reverse(head);
            while (x != null)
            {
                Console.Write("{0} ", x.value);
                x = x.next;
            }
        }
        else
        {
            Console.Write("You did not provide any input.");
        }

        Console.Write("\n");
    }

    private static node reverse(node head)
    {
        node first = head;
        node second = first.next;

        head.next = null;

        if (second != null)
        {

            if (second.next != null)
            {
                node third = second.next;

                while (third != null)
                {
                    second.next = first;
                    first = second;
                    second = third;
                    third = third.next;
                }

                second.next = first;
                return second;
            }
            else
            {
                second.next = first;
                return second;
            }
        }
        else return first;
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