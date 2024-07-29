using System.Diagnostics.Contracts;

class Program
{
	static void Main()
	{
		Console.WriteLine("Starting");
		Task t1 = new Task(() => Print("this is message"));
		t1.Start();
		Task t2 = new Task(() => Print("this is message"));
		Console.WriteLine("Finished");
	}
	static void Print(string message)
	{
		Console.WriteLine("Print start");
		Thread.Sleep(5000);
		Console.WriteLine("Print finished" + message);
	}
}