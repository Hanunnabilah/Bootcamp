using System.Collections;

class Program
{
	static void Main()
	{
		ArrayList myArray = new();
		myArray.Add(true);
		
		bool result = (bool) myArray[1];
		Console.WriteLine(result);
	}
}

// You can define other methods, fields, classes and namespaces here
