using System.Runtime.InteropServices.Marshalling;

class Program
{
	static void Main()
	{
		// create queue for fruits
		Queue<string> fruits = new Queue<string>();
		
		// add Lemon and Watermelon to the queue
		fruits.Enqueue("Lemon");
		fruits.Enqueue("Watermelon");
		
		// print elements of the queue
		foreach(string i in fruits)
		{
			Console.WriteLine(i);
		}
	}
}