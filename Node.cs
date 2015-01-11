
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
